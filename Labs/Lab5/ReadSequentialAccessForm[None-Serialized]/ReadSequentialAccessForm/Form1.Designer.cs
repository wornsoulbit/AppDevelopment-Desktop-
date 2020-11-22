namespace ReadSequentialAccessForm {
    partial class ReadSequentialAccessForm {
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.NextResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(39, 142);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 8;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // NextResultButton
            // 
            this.NextResultButton.Enabled = false;
            this.NextResultButton.Location = new System.Drawing.Point(146, 142);
            this.NextResultButton.Name = "NextResultButton";
            this.NextResultButton.Size = new System.Drawing.Size(75, 23);
            this.NextResultButton.TabIndex = 9;
            this.NextResultButton.Text = "Next Result";
            this.NextResultButton.UseVisualStyleBackColor = true;
            this.NextResultButton.Click += new System.EventHandler(this.NextResultButton_Click);
            // 
            // ReadSequentialAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 199);
            this.Controls.Add(this.NextResultButton);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "ReadSequentialAccessForm";
            this.Text = "Reading a Sequential File";
            this.Controls.SetChildIndex(this.OpenFileButton, 0);
            this.Controls.SetChildIndex(this.NextResultButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button NextResultButton;
    }
}

