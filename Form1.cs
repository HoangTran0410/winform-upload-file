using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace aQuang
{
    public partial class Form1 : Form
    {

        private int _retryCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileNametxt.Text = dlg.FileName;
                uploadStatustxt.Text = "Status: ready to upload";
            } 
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if(fileNametxt.Text != "")
            {
                Upload(fileNametxt.Text, apiUrlTxt.Text, 5, 3000);
            } 
            else
            {
                MessageBox.Show("Please select file to upload");
            }
        }

        // Upload không bảo mật
        // https://stackoverflow.com/a/40219504
        private void Upload(
            string fileName, 
            string serverUrl,
            int retryLimit = 5,
            int retryInterval =  3000)
        {
            using (var client = new WebClient())
            {
                try
                {
                    // Init data
                    uploadStatustxt.Text = "Status: Loading file data...";
                    var uri = new Uri(serverUrl);
                    var data = File.ReadAllBytes(fileName);
                    uploadStatustxt.Text = "Status: Uploading...";

                    // Init event handlers - Phải để trước khi bắt đầu upload hmmm...
                    // https://stackoverflow.com/a/982332
                    client.UploadProgressChanged += (object sender, UploadProgressChangedEventArgs e) =>
                    {
                        progressBar.Value = e.ProgressPercentage;
                    };
                    client.UploadDataCompleted += (s, e) =>
                    {
                        if (e.Error != null)
                        {
                            _retryCount++;
                            if (_retryCount < retryLimit)
                            {
                                MessageBox.Show(e.Error.Message + $"\nRetry {_retryCount} after {retryInterval/1000}s...");
                                SetTimeout(() =>
                                {
                                    client.UploadDataAsync(uri, data);
                                }, retryInterval);
                            }
                            else
                            {
                                _retryCount = 0;
                                uploadStatustxt.Text = "Status: Upload Failed";
                                MessageBox.Show(e.Error.Message + "\nReached retry limit. Will stop retry!");
                            }
                        }
                        else
                        {
                            _retryCount = 0;
                            uploadStatustxt.Text = "Status: Upload Success";
                            MessageBox.Show("Upload Data Completed");
                        }
                    };

                    // Begin upload
                    client.Headers.Add("fileName", Path.GetFileName(fileName));
                    client.UploadDataAsync(uri, data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // https://stackoverflow.com/a/57694261
        public void SetTimeout(Action action, int timeout)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = timeout;
            timer.Tick += delegate (object sender, EventArgs args)
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }
    }
}
