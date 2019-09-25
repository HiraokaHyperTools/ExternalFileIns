namespace ExternalFileIns
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.installUserControl1 = new ExternalFileIns.Control.InstallUserControl();
            this.installUserControl2 = new ExternalFileIns.Control.InstallUserControl();
            this.installUserControl3 = new ExternalFileIns.Control.InstallUserControl();
            this.installUserControl4 = new ExternalFileIns.Control.InstallUserControl();
            this.installUserControl5 = new ExternalFileIns.Control.InstallUserControl();
            this.installUserControl6 = new ExternalFileIns.Control.InstallUserControl();
            this.SuspendLayout();
            // 
            // installUserControl1
            // 
            this.installUserControl1.InstallSoftName = "poppler-0.68.0";
            this.installUserControl1.InstallSoftPath = "poppler-0.68.0";
            this.installUserControl1.InstallSoftUrl = "http://blog.alivate.com.au/wp-content/uploads/2018/10/poppler-0.68.0_x86.7z";
            this.installUserControl1.Location = new System.Drawing.Point(2, 6);
            this.installUserControl1.Name = "installUserControl1";
            this.installUserControl1.Size = new System.Drawing.Size(361, 24);
            this.installUserControl1.TabIndex = 0;
            // 
            // installUserControl2
            // 
            this.installUserControl2.InstallSoftName = "ThumbGensPack";
            this.installUserControl2.InstallSoftPath = "Setup_ThumbGensPack.exe";
            this.installUserControl2.InstallSoftUrl = "https://github.com/kenjiuno/ThumbGensPack/releases";
            this.installUserControl2.Location = new System.Drawing.Point(2, 36);
            this.installUserControl2.Name = "installUserControl2";
            this.installUserControl2.Size = new System.Drawing.Size(361, 24);
            this.installUserControl2.TabIndex = 1;
            // 
            // installUserControl3
            // 
            this.installUserControl3.InstallSoftName = "pdftifcutter";
            this.installUserControl3.InstallSoftPath = "Setup_pdftifcutter.exe";
            this.installUserControl3.InstallSoftUrl = "https://github.com/HiraokaHyperTools/pdftifcutter/releases";
            this.installUserControl3.Location = new System.Drawing.Point(2, 66);
            this.installUserControl3.Name = "installUserControl3";
            this.installUserControl3.Size = new System.Drawing.Size(361, 24);
            this.installUserControl3.TabIndex = 2;
            // 
            // installUserControl4
            // 
            this.installUserControl4.InstallSoftName = "ddprint";
            this.installUserControl4.InstallSoftPath = "Setup_ddprint_v5_0_4.exe";
            this.installUserControl4.InstallSoftUrl = "http://go-to-url.appspot.com/g2?80bad76b89c54e7aae0acf403e7d91f9";
            this.installUserControl4.Location = new System.Drawing.Point(2, 96);
            this.installUserControl4.Name = "installUserControl4";
            this.installUserControl4.Size = new System.Drawing.Size(361, 24);
            this.installUserControl4.TabIndex = 3;
            // 
            // installUserControl5
            // 
            this.installUserControl5.InstallSoftName = "PdfNup";
            this.installUserControl5.InstallSoftPath = "Setup_PdfNup.exe";
            this.installUserControl5.InstallSoftUrl = "https://github.com/HiraokaHyperTools/PdfNup";
            this.installUserControl5.Location = new System.Drawing.Point(2, 126);
            this.installUserControl5.Name = "installUserControl5";
            this.installUserControl5.Size = new System.Drawing.Size(361, 24);
            this.installUserControl5.TabIndex = 4;
            // 
            // installUserControl6
            // 
            this.installUserControl6.InstallSoftName = "7zip";
            this.installUserControl6.InstallSoftPath = "なし";
            this.installUserControl6.InstallSoftUrl = "https://sevenzip.osdn.jp";
            this.installUserControl6.Location = new System.Drawing.Point(3, 156);
            this.installUserControl6.Name = "installUserControl6";
            this.installUserControl6.Size = new System.Drawing.Size(361, 24);
            this.installUserControl6.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 184);
            this.Controls.Add(this.installUserControl6);
            this.Controls.Add(this.installUserControl5);
            this.Controls.Add(this.installUserControl4);
            this.Controls.Add(this.installUserControl3);
            this.Controls.Add(this.installUserControl2);
            this.Controls.Add(this.installUserControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExternalFileIns";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.InstallUserControl installUserControl1;
        private Control.InstallUserControl installUserControl2;
        private Control.InstallUserControl installUserControl3;
        private Control.InstallUserControl installUserControl4;
        private Control.InstallUserControl installUserControl5;
        private Control.InstallUserControl installUserControl6;
    }
}

