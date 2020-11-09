namespace ListView {
    partial class ListViewForm {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewForm));
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.HideSelection = false;
            this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListView1.LabelWrap = false;
            this.ListView1.LargeImageList = this.ImageList1;
            this.ListView1.Location = new System.Drawing.Point(12, 22);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(372, 323);
            this.ListView1.SmallImageList = this.ImageList1;
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.List;
            this.ListView1.Click += new System.EventHandler(this.ListView1_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "folder.bmp");
            this.ImageList1.Images.SetKeyName(1, "file.bmp");
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(12, 6);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(0, 13);
            this.DisplayLabel.TabIndex = 1;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.ListView1);
            this.Name = "ListViewForm";
            this.Text = "List View";
            this.Load += new System.EventHandler(this.ListViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

