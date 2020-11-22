namespace LINQToFileDirectory {
    partial class LINQToFileDirectoryForm {
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
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Location = new System.Drawing.Point(13, 13);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(106, 13);
            this.InputTextLabel.TabIndex = 0;
            this.InputTextLabel.Text = "Enter path to search:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(16, 29);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(213, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(131, 56);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(97, 21);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Search Directory";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory:";
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Enabled = false;
            this.DirectoryTextBox.Location = new System.Drawing.Point(75, 84);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(153, 20);
            this.DirectoryTextBox.TabIndex = 4;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(19, 110);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(210, 319);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.Text = "";
            // 
            // LINQToFileDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputTextLabel);
            this.Name = "LINQToFileDirectoryForm";
            this.Text = "Search Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
    }
}

