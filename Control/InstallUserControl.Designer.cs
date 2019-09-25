namespace ExternalFileIns.Control
{
    partial class InstallUserControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Installbutton = new System.Windows.Forms.Button();
            this.InstallWebbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Installbutton
            // 
            this.Installbutton.Location = new System.Drawing.Point(111, 0);
            this.Installbutton.Name = "Installbutton";
            this.Installbutton.Size = new System.Drawing.Size(117, 23);
            this.Installbutton.TabIndex = 4;
            this.Installbutton.Text = "内臓からインストール";
            this.Installbutton.UseVisualStyleBackColor = true;
            this.Installbutton.Click += new System.EventHandler(this.Installbutton_Click);
            // 
            // InstallWebbutton
            // 
            this.InstallWebbutton.Location = new System.Drawing.Point(245, 0);
            this.InstallWebbutton.Name = "InstallWebbutton";
            this.InstallWebbutton.Size = new System.Drawing.Size(117, 23);
            this.InstallWebbutton.TabIndex = 5;
            this.InstallWebbutton.Text = "ウェブから取得";
            this.InstallWebbutton.UseVisualStyleBackColor = true;
            this.InstallWebbutton.Click += new System.EventHandler(this.InstallWebbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "SoftName";
            // 
            // InstallUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Installbutton);
            this.Controls.Add(this.InstallWebbutton);
            this.Controls.Add(this.label1);
            this.Name = "InstallUserControl";
            this.Size = new System.Drawing.Size(361, 24);
            this.Load += new System.EventHandler(this.InstallUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Installbutton;
        private System.Windows.Forms.Button InstallWebbutton;
        private System.Windows.Forms.Label label1;
    }
}
