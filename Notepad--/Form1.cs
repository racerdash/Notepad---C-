namespace Notepad__
{
    public partial class Form1 : Form
    {
        string file = "", path = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.S): //ctrl + s to save
                    saveFile();
                    
                    break;
                case (Keys.Control | Keys.O): //ctrl + o to open
                    openFile();
                    break;
            }
            

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            isChanged.Text = "Text: changed";
        }

        //when save has been activated
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        //when open file has been activated
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveFile()
        {
            if (path != "")
            {
                File.WriteAllText(path, content.Text);
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text file|*.txt|All files|*.*";
                saveFile.Title = "Save the written content";
                saveFile.ShowDialog();
                path = saveFile.FileName;
                
                if(saveFile.FileName != "")
                    File.WriteAllText(saveFile.FileName, content.Text);

                file = showFileNameOnly(path);
            }

            fileName.Text = "File: " + file;
            isChanged.Text = "Text: saved";
        }

        private void openFile()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files|*.txt|All files|*.*",
                Title = "Open a text file"
            };
            openFile.ShowDialog();
            path = openFile.FileName;
            if(openFile.FileName != "")
                content.Text = File.ReadAllText(path); 

            file = showFileNameOnly(path);
            fileName.Text = "File: " + file;
        }

        private string showFileNameOnly(string pathFile)
        {
            string fileName = Path.GetFileName(pathFile);
            return fileName;
        }

    }
}
