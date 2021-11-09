
namespace aQuang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.uploadStatustxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apiUrlTxt = new System.Windows.Forms.TextBox();
            this.apiUrllb = new System.Windows.Forms.Label();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 225);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(398, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 0;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(156, 145);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(94, 37);
            this.uploadBtn.TabIndex = 1;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // uploadStatustxt
            // 
            this.uploadStatustxt.AutoSize = true;
            this.uploadStatustxt.Location = new System.Drawing.Point(12, 205);
            this.uploadStatustxt.Name = "uploadStatustxt";
            this.uploadStatustxt.Size = new System.Drawing.Size(56, 17);
            this.uploadStatustxt.TabIndex = 3;
            this.uploadStatustxt.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upload Large File";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apiUrlTxt
            // 
            this.apiUrlTxt.Location = new System.Drawing.Point(91, 71);
            this.apiUrlTxt.Name = "apiUrlTxt";
            this.apiUrlTxt.Size = new System.Drawing.Size(275, 22);
            this.apiUrlTxt.TabIndex = 5;
            this.apiUrlTxt.Text = "http://localhost:3519/api/v2/UploadLargeFileV2Controller";
            // 
            // apiUrllb
            // 
            this.apiUrllb.AutoSize = true;
            this.apiUrllb.Location = new System.Drawing.Point(34, 74);
            this.apiUrllb.Name = "apiUrllb";
            this.apiUrllb.Size = new System.Drawing.Size(55, 17);
            this.apiUrllb.TabIndex = 6;
            this.apiUrllb.Text = "API Url:";
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(329, 109);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(37, 23);
            this.chooseFileBtn.TabIndex = 8;
            this.chooseFileBtn.Text = "...";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "File:";
            // 
            // fileNametxt
            // 
            this.fileNametxt.Location = new System.Drawing.Point(91, 109);
            this.fileNametxt.Name = "fileNametxt";
            this.fileNametxt.Size = new System.Drawing.Size(232, 22);
            this.fileNametxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 260);
            this.Controls.Add(this.fileNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.apiUrllb);
            this.Controls.Add(this.apiUrlTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadStatustxt);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label uploadStatustxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiUrlTxt;
        private System.Windows.Forms.Label apiUrllb;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileNametxt;
    }
}

