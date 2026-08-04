using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notepad__
{
    public partial class FindForm : Form
    {
        private FormMain notepad;
        public FindForm(FormMain main)
        {
            InitializeComponent();
            this.notepad = main;

            this.FormClosing += new FormClosingEventHandler(HandleFormClosing);
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                if(this.notepad != null && !this.notepad.Visible)
                    this.notepad.Show();
            }
        }
            
        private void findButton_Click(object sender, EventArgs e)
        {
            RichTextBox content = this.notepad.getContentBox();
            content.SelectionStart = 0;
            content.SelectionLength = 10;
            content.Select();
        }
    }

}
