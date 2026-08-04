namespace Notepad__
{
    partial class FindForm
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
            findWord = new TextBox();
            findButton = new Button();
            top = new RadioButton();
            bottom = new RadioButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 56);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Find word:";
            // 
            // findWord
            // 
            findWord.Location = new Point(134, 53);
            findWord.Name = "findWord";
            findWord.Size = new Size(100, 23);
            findWord.TabIndex = 1;
            // 
            // findButton
            // 
            findButton.Location = new Point(320, 52);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 2;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // top
            // 
            top.AutoSize = true;
            top.Location = new Point(134, 153);
            top.Name = "top";
            top.Size = new Size(74, 19);
            top.TabIndex = 3;
            top.TabStop = true;
            top.Text = "From top";
            top.UseVisualStyleBackColor = true;
            // 
            // bottom
            // 
            bottom.AutoSize = true;
            bottom.Location = new Point(234, 153);
            bottom.Name = "bottom";
            bottom.Size = new Size(96, 19);
            bottom.TabIndex = 4;
            bottom.TabStop = true;
            bottom.Text = "From bottom";
            bottom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 135);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 5;
            label2.Text = "Search order:";
            // 
            // findForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 268);
            Controls.Add(label2);
            Controls.Add(bottom);
            Controls.Add(top);
            Controls.Add(findButton);
            Controls.Add(findWord);
            Controls.Add(label1);
            Name = "findForm";
            Text = "Find";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox findWord;
        private Button findButton;
        private RadioButton top;
        private RadioButton bottom;
        private Label label2;
    }
}