using System.Security.Cryptography.X509Certificates;
using System.Text;
using log4net;
using log4net.Config;

namespace Notepad__
{
    /*To be fixed:
     * When doing key shortcuts, the letter gets written in the textbox. --FIXED--
     * Auto resize everything --FIXED--
     * Closing the open file window without opening crashes the program --FIXED--
     */
    public partial class FormMain : Form
    {
        private string file = "", path = "";
        private bool fileChanged = false;
        FindForm findForm;
        ReplaceForm replaceForm;
        private static readonly ILog logger = LogManager.GetLogger(typeof(FormMain));
        public FormMain()
        {
            XmlConfigurator.Configure();

            InitializeComponent();
            findForm = new FindForm(this);
            replaceForm = new ReplaceForm(this);

            this.MinimumSize = new Size(933, 660);
            fileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            isChanged.Anchor = AnchorStyles.Bottom;
            content.BorderStyle = BorderStyle.None;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileChanged)
            {
                var result = MessageBox.Show("You haven't saved the file. Do you want to save it?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (!Data.SaveFile(this))
                            e.Cancel = true;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            content.Size = new Size(this.Width, this.Height - 112);
        }

        //Getter for the content RichTextBox
        public RichTextBox getContentBox()
        {
            return content;
        }
        
        //Getter for the path variable
        public string getPath()
        {
            return path;
        }

        //Getter for the fileName Label
        public Label getFileName()
        {
            return fileName;
        }

        //Getter for the isChanged Label
        public Label getIsChanged()
        {
            return isChanged;
        }

        //Getter for the file String
        public string getFile()
        {
            return file;
        }
        public Label getTmp()
        {
            return tmp;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool result = false;
            switch (keyData)
            {
                case (Keys.Control | Keys.S): //ctrl + s to save
                    SaveFile();
                    result = true;
                    break;
                case (Keys.Control | Keys.O): //ctrl + o to open
                    OpenFile();
                    result = true;
                    break;
                case (Keys.Control | Keys.F): //ctrl + f to find
                    find();
                    result = true;
                    break;
                case (Keys.Control | Keys.R): //ctrl + r to replace
                    replace();
                    result = true;
                    break;
            }
            return result;
        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            isChanged.Text = "Text: changed";
            this.findForm.updateCursor();
            tmp.Text = this.findForm.getCursor().ToString();
            fileChanged = true;
        }

        private void content_LostFocus(object sender, EventArgs e)
        {

        }

        //when save has been activated
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileChanged = !Data.SaveFile(this);
        }

        //when open file has been activated
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(); 
            
        }

        private bool SaveFile()
        {
            if (path != "")
            {
                File.WriteAllText(path, content.Text);
                fileName.Text = "File: " + file;
                isChanged.Text = "Text: saved";
                fileChanged = false;

                return true;
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text file|*.txt|All files|*.*";
                saveFile.Title = "Save the written content";
                saveFile.ShowDialog();
                path = saveFile.FileName;

                if (saveFile.FileName != "")
                {
                    File.WriteAllText(saveFile.FileName, content.Text);
                    file = showFileNameOnly(path);
                    fileName.Text = "File: " + file;
                    isChanged.Text = "Text: saved";
                    fileChanged = false;

                    return true;
                }
            }
            return false;
        }

        private void OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Text files|*.txt|All files|*.*",
                Title = "Open a text file"
            };
            try
            {
                content.Text = string.Empty;
                content.Clear();
                content.ClearUndo();
                openFile.ShowDialog();
                path = openFile.FileName;
                
                if (path != "")
                {
                    content.Text = File.ReadAllText(path);
                }

                file = showFileNameOnly(path);
                fileName.Text = "File: " + file;
                
                /*if(path != "")
                {
                    content.Text = "";

                    StringBuilder sb = new StringBuilder();
                    using (StreamReader read = new StreamReader(path))
                    {
                        string line;

                        while ((line = read.ReadLine()) != null)
                        {
                            sb.Append(line);
                        }
                        content.Text = sb.ToString();
                        file = showFileNameOnly(path);
                        fileName.Text = "File: " + file;
           
                        //read.Dispose();
                        read.Close();

                    }
                }*/

                //HIGHLY UNORTHODOX, I DO NOT RECOMMEND THIS, WILL BE REWRITTEN IN A NEW ENGINE SOMETIME
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

            } catch (OutOfMemoryException exception)
            {
                MessageBox.Show("File too big to be opened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show("Not enough permissions to read the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (IOException exception)
            {
                MessageBox.Show("There was a problem when reading the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string showFileNameOnly(string pathFile)
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


        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replace();
        }

        private void replace()
        {
            replaceForm.Show();
        }

    }
}
