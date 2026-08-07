namespace Notepad__
{
    /*To be fixed:
     * When doing key shortcuts, the letter gets written in the textbox.
     * Auto resize everything
     */
    public partial class FormMain : Form
    {
        private string file = "", path = "";
        FindForm findForm;
        public FormMain()
        { 
            InitializeComponent();
            findForm = new FindForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        public Label getTmp()
        {
            return tmp;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = base.ProcessCmdKey(ref msg, keyData);
            switch (keyData)
            {
                case (Keys.Control | Keys.S): //ctrl + s to save
                    saveFile();
                    break;
                case (Keys.Control | Keys.O): //ctrl + o to open
                    openFile();
                    break;
                case (Keys.Control | Keys.F): //ctrl + f to find
                    find();
                    break;
            }


            return result; // ruturn 
        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            isChanged.Text = "Text: changed";
            this.findForm.updateCursor();
            tmp.Text = this.findForm.getCursor().ToString();

        }

        private void content_LostFocus(object sender, EventArgs e)
        {
            
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

                if (saveFile.FileName != "")
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
            if (openFile.FileName != "")
                content.Text = File.ReadAllText(path);

            file = showFileNameOnly(path);
            fileName.Text = "File: " + file;
        }

        private string showFileNameOnly(string pathFile)
        {
            string fileName = Path.GetFileName(pathFile);
            return fileName;
        }
        //when find has been activated
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find();
        }

        private void find()
        {
            findForm.Show();
        }

        public RichTextBox getContentBox()
        {
            return content;
        }
    }
}
