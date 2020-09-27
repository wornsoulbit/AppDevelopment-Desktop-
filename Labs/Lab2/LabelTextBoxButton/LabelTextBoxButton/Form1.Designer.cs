namespace LabelTextBoxButton {
    partial class Form1 {
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
            this.displayPwdTextBox = new System.Windows.Forms.TextBox();
            this.displayPwdButton = new System.Windows.Forms.Button();
            this.displayPwdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayPwdTextBox
            // 
            this.displayPwdTextBox.Location = new System.Drawing.Point(30, 33);
            this.displayPwdTextBox.Name = "displayPwdTextBox";
            this.displayPwdTextBox.PasswordChar = '*';
            this.displayPwdTextBox.Size = new System.Drawing.Size(203, 20);
            this.displayPwdTextBox.TabIndex = 1;
            // 
            // displayPwdButton
            // 
            this.displayPwdButton.Location = new System.Drawing.Point(95, 100);
            this.displayPwdButton.Name = "displayPwdButton";
            this.displayPwdButton.Size = new System.Drawing.Size(75, 23);
            this.displayPwdButton.TabIndex = 2;
            this.displayPwdButton.Text = "Show Me";
            this.displayPwdButton.UseVisualStyleBackColor = true;
            this.displayPwdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayPwdLabel
            // 
            this.displayPwdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPwdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayPwdLabel.Location = new System.Drawing.Point(30, 65);
            this.displayPwdLabel.Name = "displayPwdLabel";
            this.displayPwdLabel.Size = new System.Drawing.Size(203, 21);
            this.displayPwdLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 157);
            this.Controls.Add(this.displayPwdLabel);
            this.Controls.Add(this.displayPwdButton);
            this.Controls.Add(this.displayPwdTextBox);
            this.Name = "Form1";
            this.Text = "Label, TextBoxes, and Buttons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox displayPwdTextBox;
        private System.Windows.Forms.Button displayPwdButton;
        private System.Windows.Forms.Label displayPwdLabel;
    }
}

