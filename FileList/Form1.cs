using System;
using System.Windows.Forms;

namespace FileList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.folderNameSource.Text) || String.IsNullOrEmpty(this.folderNameTarget.Text))
            {
                MessageBox.Show("フォルダが指定されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Execute())
            {
                MessageBox.Show("正常終了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("異常終了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFolderSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "フォルダを指定してください。";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.folderNameSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void openFolderTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "フォルダを指定してください。";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.folderNameTarget.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private bool Execute()
        {
            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(this.folderNameSource.Text);
            System.IO.FileInfo[] files = directoryInfo.GetFiles("*.java", System.IO.SearchOption.AllDirectories);

            string fileName = GetSaveFileName();
            if (!String.IsNullOrEmpty(fileName))
            {
                WriteCSV(fileName, files);
                CopyClassFile(files);
            }
            return true;
        }

        private string GetSaveFileName()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "result.csv";
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "CSV Files (.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.Title = "保存先のファイルを選択してください";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }

        private bool WriteCSV(string fileName, System.IO.FileInfo[] files)
        {
            using (var sw = new System.IO.StreamWriter(fileName))
            {
                foreach (System.IO.FileInfo file in files)
                {
                    sw.WriteLine("{0}, {1}", file.Name, file.LastWriteTime.ToString("yyyy/MM/dd hh:mm:ss"));
                }
            }
            return true;
        }

        private bool CopyClassFile(System.IO.FileInfo[] files)
        {
            foreach (System.IO.FileInfo file in files)
            {
                // Path.GetExtentionでした方がよかったかな
                string fileName = file.Name.Substring(0, file.Name.LastIndexOf(".java")) + ".class";
                string sourcePath = file.DirectoryName.Replace(this.folderNameSource.Text, this.folderNameTarget.Text) + System.IO.Path.DirectorySeparatorChar + fileName;
                string copyToPath = file.DirectoryName + System.IO.Path.DirectorySeparatorChar + fileName;
                System.IO.File.Copy(sourcePath, copyToPath, false);
                System.IO.File.Delete(file.FullName);
            }
            return true;
        }
    }
}
