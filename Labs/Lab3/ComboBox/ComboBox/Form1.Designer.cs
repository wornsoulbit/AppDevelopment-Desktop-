namespace ComboBox {
    partial class ComboBoxForm {
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
            this.ImageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ImageComboBox
            // 
            this.ImageComboBox.FormattingEnabled = true;
            this.ImageComboBox.Items.AddRange(new object[] {
            "Ellipse",
            "Rectangle",
            "Bigger Ellipse",
            "Pie",
            "Filled Ellipse",
            "Filled Rectangle",
            "Filled Bigger Ellipse",
            "Filled Pie"});
            this.ImageComboBox.Location = new System.Drawing.Point(13, 13);
            this.ImageComboBox.Name = "ImageComboBox";
            this.ImageComboBox.Size = new System.Drawing.Size(121, 21);
            this.ImageComboBox.TabIndex = 0;
            this.ImageComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 240);
            this.Controls.Add(this.ImageComboBox);
            this.Name = "ComboBoxForm";
            this.Text = "Combo Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ImageComboBox;
    }
}

