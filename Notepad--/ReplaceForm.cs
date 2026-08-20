using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/*
 * To be fixed: same thing as in FindForm.cs (ui elements wise)
 */

namespace Notepad__
{
    public partial class ReplaceForm : Form
    {
        private FormMain notepad;
        private int cursor = 0;
        public ReplaceForm(FormMain main)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.notepad = main;
            top.Checked = true;

            this.FormClosing += new FormClosingEventHandler(HandleFormClosing);
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                if (this.notepad != null && !this.notepad.Visible)
                    this.notepad.Show();
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            RichTextBox content = this.notepad.getContentBox();

            if (cursor >= 0)
                cursor = Data.searchString(content.Text, stringFind.Text, cursor, top.Checked);

            if (cursor >= 0 && cursor < content.TextLength)
            {
                content.SelectionStart = cursor;
                content.SelectionLength = stringFind.TextLength;
                content.Select();

                if(stringReplace.Text != stringFind.Text && stringReplace.Text != "") 
                    content.SelectedText = stringReplace.Text;

                if (top.Checked)
                    cursor += stringFind.TextLength;
                else
                    cursor -= stringFind.TextLength;
            }
            else
            {
                if (top.Checked)
                    cursor = 0;
                else
                    cursor = content.TextLength - 1;
            }

            this.notepad.getTmp().Text = cursor.ToString();
        }
    }
}
