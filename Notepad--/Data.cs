using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Notepad__
{
    internal class Data
    { 
        public static int searchString(string source, string toFind, int currentPos, bool isChecked)
        {
            int posCursor = 0; 

            if (isChecked == true)
            {
                posCursor = source.IndexOf(toFind, currentPos);
            }
            else
            {
                posCursor = source.LastIndexOf(toFind, currentPos);
            }

            return posCursor;
        }

        //Saves the file accordingly.
        public static bool SaveFile(FormMain form)
        {
            string path = form.getPath(), file = form.getFile();
            RichTextBox content = form.getContentBox();
            Label fileName = form.getFileName(), isChanged = form.getIsChanged();


            if (path != "")
            {
                File.WriteAllText(path, content.Text);
                fileName.Text = "File: " + file;
                isChanged.Text = "Text: saved";

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
                    file = form.showFileNameOnly(path);
                    fileName.Text = "File: " + file;
                    isChanged.Text = "Text: saved";

                    return true;
                }
            }
            return false;
        }

        public static void OpenFile(FormMain form)
        {
            string path = form.getPath(), file = form.getFile();
            RichTextBox content = form.getContentBox();
            Label fileName = form.getFileName();

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

                file = form.showFileNameOnly(path);
                fileName.Text = "File: " + file;

                //HIGHLY UNORTHODOX, I DO NOT RECOMMEND THIS, WILL BE REWRITTEN IN A NEW ENGINE SOMETIME
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show("File too big to be opened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show("Not enough permissions to read the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException exception)
            {
                MessageBox.Show("There was a problem when reading the file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
