namespace Notepad__
{
    partial class ReplaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            replaceButton = new Button();
            stringFind = new TextBox();
            stringReplace = new TextBox();
            label3 = new Label();
            bottom = new RadioButton();
            top = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Replace";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 127);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "with";
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(424, 81);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(94, 29);
            replaceButton.TabIndex = 2;
            replaceButton.Text = "Replace";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // stringFind
            // 
            stringFind.Location = new Point(188, 55);
            stringFind.Name = "stringFind";
            stringFind.Size = new Size(125, 27);
            stringFind.TabIndex = 3;
            // 
            // stringReplace
            // 
            stringReplace.Location = new Point(188, 120);
            stringReplace.Name = "stringReplace";
            stringReplace.Size = new Size(125, 27);
            stringReplace.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 194);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 8;
            label3.Text = "Search order:";
            // 
            // bottom
            // 
            bottom.AutoSize = true;
            bottom.Location = new Point(272, 218);
            bottom.Margin = new Padding(3, 4, 3, 4);
            bottom.Name = "bottom";
            bottom.Size = new Size(118, 24);
            bottom.TabIndex = 7;
            bottom.TabStop = true;
            bottom.Text = "From bottom";
            bottom.UseVisualStyleBackColor = true;
            // 
            // top
            // 
            top.AutoSize = true;
            top.Location = new Point(158, 218);
            top.Margin = new Padding(3, 4, 3, 4);
            top.Name = "top";
            top.Size = new Size(91, 24);
            top.TabIndex = 6;
            top.TabStop = true;
            top.Text = "From top";
            top.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 292);
            Controls.Add(label3);
            Controls.Add(bottom);
            Controls.Add(top);
            Controls.Add(stringReplace);
            Controls.Add(stringFind);
            Controls.Add(replaceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReplaceForm";
            Text = "Replace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button replaceButton;
        private TextBox stringFind;
        private TextBox stringReplace;
        private Label label3;
        private RadioButton bottom;
        private RadioButton top;
    }
}