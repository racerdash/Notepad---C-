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
 * To be fixed: clicking twice the "find" button before actually restarting the search
 */
namespace Notepad__
{
    public partial class FindForm : Form
    {
        private FormMain notepad;
        private int cursor = 0;
        public FindForm(FormMain main)
        {
            InitializeComponent();
            this.notepad = main;
            top.Checked = true;

            this.FormClosing += new FormClosingEventHandler(HandleFormClosing);
        }

        public void updateCursor()
        {
            if (bottom.Checked)
                cursor = this.notepad.getContentBox().Text.Length - 1;
        }

        //temporary getter
        public int getCursor()
        {
            return cursor;
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

        private void findButton_Click(object sender, EventArgs e)
        {
            RichTextBox content = this.notepad.getContentBox();

            if(cursor >= 0)
                cursor = Data.searchString(content.Text, findWord.Text, cursor, top.Checked);

            if (cursor >= 0 && cursor < content.TextLength)
            {
                content.SelectionStart = cursor;
                content.SelectionLength = findWord.TextLength;
                content.Select();
                if (top.Checked)
                    cursor += findWord.TextLength;
                else
                    cursor -= findWord.TextLength;
            } else
            {
                if (top.Checked)
                    cursor = 0;
                else
                    cursor = content.TextLength - 1;
            }
            
            this.notepad.getTmp().Text = cursor.ToString();
        }

        private void bottom_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
