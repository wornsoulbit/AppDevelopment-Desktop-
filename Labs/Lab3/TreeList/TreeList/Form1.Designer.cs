namespace TreeList {
    partial class TreeViewForm {
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
            this.TreeViewBox = new System.Windows.Forms.TreeView();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.IdkSomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TreeViewBox
            // 
            this.TreeViewBox.Location = new System.Drawing.Point(12, 52);
            this.TreeViewBox.Name = "TreeViewBox";
            this.TreeViewBox.Size = new System.Drawing.Size(287, 341);
            this.TreeViewBox.TabIndex = 0;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(13, 26);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(209, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(224, 24);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // IdkSomeLabel
            // 
            this.IdkSomeLabel.AutoSize = true;
            this.IdkSomeLabel.Location = new System.Drawing.Point(13, 7);
            this.IdkSomeLabel.Name = "IdkSomeLabel";
            this.IdkSomeLabel.Size = new System.Drawing.Size(270, 13);
            this.IdkSomeLabel.TabIndex = 3;
            this.IdkSomeLabel.Text = "Enter the full path to the directory you would like to view";
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 415);
            this.Controls.Add(this.IdkSomeLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TreeViewBox);
            this.Name = "TreeViewForm";
            this.Text = "Tree View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeViewBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label IdkSomeLabel;
    }
}

