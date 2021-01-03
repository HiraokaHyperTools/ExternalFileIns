using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ExternalFileIns.Control
{
    public partial class InstallUserControl : UserControl
    {
        public InstallUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ProgramFiles
        /// </summary>
        static string InstallFolderPath = "";
        /// <summary>
        /// インストールしたいファイルパスのフルパス
        /// </summary>

        [Browsable(true)]
        [Description("インストールしたいProgram内相対パス")]
        [Category("動作")]
        public string InstallSoftPath {
            get {
                return Installbutton.Tag.ToString();
            }
            set {
                Installbutton.Tag = value;
            }
        }

        /// <summary>
        /// インストールしたいソフト名（フォルダー名
        /// </summary>
        [Browsable(true)]
        [Description("インストールしたいソフト名（フォルダー名")]
        [Category("動作")]
        public string InstallSoftName {
            get {
                return label1.Text;
            }
            set {
                label1.Text = value;
            }
        }


        /// <summary>
        /// インストールしたいソフトのWebURL
        /// </summary>
        [Bindable(BindableSupport.Yes)]
        [Description("インストールしたいソフトのWebURL")]
        [Category("動作")]
        public string InstallSoftUrl {
            get {
                return InstallWebbutton.Tag.ToString();
            }
            set {
                InstallWebbutton.Tag = value.ToString();
            }
        }

     


        private void InstallUserControl_Load(object sender, EventArgs e)
        {
            if (InstallWebbutton.Tag == null 
                || InstallWebbutton.Tag.ToString() == "")
            {
                InstallWebbutton.Tag = "InstallWebbutton";
            }
            if (Installbutton.Tag == null
                || Installbutton.Tag.ToString() == "")
            {
                Installbutton.Tag = "InstallSoftPath";
            }
            
            
            if (Environment.Is64BitOperatingSystem) {
                InstallFolderPath = @"C:\Program Files (x86)";
            }   
            else
            {
                InstallFolderPath = @"C:\Program Files";
            }
                
        }

        /// <summary>
        /// ワンクリックでPopplerがファイルコピー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Installbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ///popplerはProgram内のフォルダーだけ移動
                if (label1.Text.Contains("poppler"))
                {
                    
                    var source = Path.Combine(InstallFolderPath, label1.Text);
                    
                    CopyAndReplace(Installbutton.Tag.ToString(), source);
                    MessageBox.Show("ファイルの移動が完了しました");
                }
                else if (Installbutton.Tag.ToString() == "なし")
                {
                    MessageBox.Show("Webからダウンロードしてください（´・ω・｀）");
                }
                ///poppler 以外
                else
                {
                    Process.Start(Installbutton.Tag.ToString());
                }
                
            }
            catch (Exception error)
            {

                MessageBox.Show("失敗:" + error.ToString());
            }
        }

        public static void CopyAndReplace(string sourcePath, string copyPath)
        {
            
            Directory.CreateDirectory(copyPath);

            //ファイルをコピー
            foreach (var file in Directory.GetFiles(sourcePath))
            {
                File.Copy(file, Path.Combine(copyPath, Path.GetFileName(file)),true);
            }

            //ディレクトリの中のディレクトリも再帰的にコピー
            foreach (var dir in Directory.GetDirectories(sourcePath))
            {
                CopyAndReplace(dir, Path.Combine(copyPath, Path.GetFileName(dir)));
            }
        }

        private void InstallWebbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(InstallWebbutton.Tag.ToString());
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }
    }
}
