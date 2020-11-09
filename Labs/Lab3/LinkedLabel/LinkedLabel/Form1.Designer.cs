namespace LinkedLabel {
    partial class LinkedLabels {
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
            this.CDriveLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.DeitelLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.NotePad = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CDriveLinkedLabel
            // 
            this.CDriveLinkedLabel.AutoSize = true;
            this.CDriveLinkedLabel.Location = new System.Drawing.Point(12, 20);
            this.CDriveLinkedLabel.Name = "CDriveLinkedLabel";
            this.CDriveLinkedLabel.Size = new System.Drawing.Size(97, 13);
            this.CDriveLinkedLabel.TabIndex = 0;
            this.CDriveLinkedLabel.TabStop = true;
            this.CDriveLinkedLabel.Text = "Click to browse C:\\";
            this.CDriveLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CDriveLinkedLabel_LinkClicked);
            // 
            // DeitelLinkedLabel
            // 
            this.DeitelLinkedLabel.AutoSize = true;
            this.DeitelLinkedLabel.Location = new System.Drawing.Point(12, 52);
            this.DeitelLinkedLabel.Name = "DeitelLinkedLabel";
            this.DeitelLinkedLabel.Size = new System.Drawing.Size(141, 13);
            this.DeitelLinkedLabel.TabIndex = 1;
            this.DeitelLinkedLabel.TabStop = true;
            this.DeitelLinkedLabel.Text = "Click to visit www.deitel.com";
            this.DeitelLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeitelLinkedLabel_LinkClicked);
            // 
            // NotePad
            // 
            this.NotePad.AutoSize = true;
            this.NotePad.Location = new System.Drawing.Point(12, 81);
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(102, 13);
            this.NotePad.TabIndex = 2;
            this.NotePad.TabStop = true;
            this.NotePad.Text = "Click to run notepad";
            this.NotePad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NotePad_LinkClicked);
            // 
            // LinkedLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 134);
            this.Controls.Add(this.NotePad);
            this.Controls.Add(this.DeitelLinkedLabel);
            this.Controls.Add(this.CDriveLinkedLabel);
            this.Name = "LinkedLabels";
            this.Text = "Linked Labels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel CDriveLinkedLabel;
        private System.Windows.Forms.LinkLabel DeitelLinkedLabel;
        private System.Windows.Forms.LinkLabel NotePad;
    }
}

