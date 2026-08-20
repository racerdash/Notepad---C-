namespace Notepad__
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            content = new RichTextBox();
            isChanged = new Label();
            fileName = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutNotepadToolStripMenuItem = new ToolStripMenuItem();
            tmp = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // content
            // 
            content.Location = new Point(0, 34);
            content.Margin = new Padding(3, 4, 3, 4);
            content.Name = "content";
            content.Size = new Size(915, 548);
            content.TabIndex = 0;
            content.Text = "";
            content.TextChanged += content_TextChanged;
            // 
            // isChanged
            // 
            isChanged.AutoSize = true;
            isChanged.Location = new Point(265, 588);
            isChanged.Name = "isChanged";
            isChanged.Size = new Size(130, 20);
            isChanged.TabIndex = 1;
            isChanged.Text = "Text: not modified";
            // 
            // fileName
            // 
            fileName.AutoSize = true;
            fileName.Location = new Point(14, 588);
            fileName.Name = "fileName";
            fileName.Size = new Size(72, 20);
            fileName.TabIndex = 2;
            fileName.Text = "File: none";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(915, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(194, 26);
            openToolStripMenuItem.Text = "Open (Ctrl + O)";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(194, 26);
            saveToolStripMenuItem.Text = "Save (Ctrl + S)";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(194, 26);
            quitToolStripMenuItem.Text = "Quit (Ctrl + Q)";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, replaceToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(209, 26);
            findToolStripMenuItem.Text = "Find (Ctrl + F)";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(209, 26);
            replaceToolStripMenuItem.Text = "Replace (Ctrl + R)";
            replaceToolStripMenuItem.Click += replaceToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutNotepadToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutNotepadToolStripMenuItem
            // 
            aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            aboutNotepadToolStripMenuItem.Size = new Size(208, 26);
            aboutNotepadToolStripMenuItem.Text = "About Notepad--";
            // 
            // tmp
            // 
            tmp.AutoSize = true;
            tmp.Location = new Point(679, 588);
            tmp.Name = "tmp";
            tmp.Size = new Size(50, 20);
            tmp.TabIndex = 4;
            tmp.Text = "label1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 613);
            Controls.Add(tmp);
            Controls.Add(fileName);
            Controls.Add(isChanged);
            Controls.Add(content);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Notepad--";
            Load += Form1_Load;
            ResizeEnd += FormMain_ResizeEnd;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox content;
        private Label isChanged;
        private Label fileName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private Label tmp;
    }
}
