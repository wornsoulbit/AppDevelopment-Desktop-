namespace CheckListBox {
    partial class CheckBoxListForm {
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
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.Items.AddRange(new object[] {
            "C HTP",
            "C++ HTP",
            "Internet & WWW HTP",
            "Java HTP",
            "VB 2012 HTP",
            "Visual C++ HTP",
            "Visual C# 2012 HTP"});
            this.CheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(133, 109);
            this.CheckedListBox.TabIndex = 0;
            this.CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
            this.CheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox_SelectedIndexChanged);
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(160, 13);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(123, 108);
            this.DisplayListBox.TabIndex = 1;
            // 
            // CheckBoxListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 142);
            this.Controls.Add(this.DisplayListBox);
            this.Controls.Add(this.CheckedListBox);
            this.Name = "CheckBoxListForm";
            this.Text = "Check Box List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBox;
        private System.Windows.Forms.ListBox DisplayListBox;
    }
}

