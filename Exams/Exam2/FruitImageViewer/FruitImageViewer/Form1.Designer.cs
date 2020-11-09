namespace FruitImageViewer {
    partial class FruitImgApp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitImgApp));
            this.fruitPictureBox = new System.Windows.Forms.PictureBox();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.fruitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitPictureBox
            // 
            this.fruitPictureBox.Image = global::FruitImageViewer.Properties.Resources.alexMango;
            this.fruitPictureBox.Location = new System.Drawing.Point(10, 12);
            this.fruitPictureBox.Name = "fruitPictureBox";
            this.fruitPictureBox.Size = new System.Drawing.Size(326, 193);
            this.fruitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fruitPictureBox.TabIndex = 0;
            this.fruitPictureBox.TabStop = false;
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Location = new System.Drawing.Point(10, 211);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(261, 211);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next>";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // fruitLabel
            // 
            this.fruitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fruitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitLabel.Location = new System.Drawing.Point(91, 211);
            this.fruitLabel.Name = "fruitLabel";
            this.fruitLabel.Size = new System.Drawing.Size(164, 23);
            this.fruitLabel.TabIndex = 3;
            this.fruitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FruitImgApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 253);
            this.Controls.Add(this.fruitLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.fruitPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FruitImgApp";
            this.Text = "Fruit Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.fruitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fruitPictureBox;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label fruitLabel;
    }
}

