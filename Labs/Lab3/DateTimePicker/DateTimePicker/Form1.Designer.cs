namespace DateTimePicker {
    partial class DateTimePicker {
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DropOffDate = new System.Windows.Forms.Label();
            this.EstimatedDeliveryDate = new System.Windows.Forms.Label();
            this.EstimatedDeliveryDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // DropOffDate
            // 
            this.DropOffDate.AutoSize = true;
            this.DropOffDate.Location = new System.Drawing.Point(12, 6);
            this.DropOffDate.Name = "DropOffDate";
            this.DropOffDate.Size = new System.Drawing.Size(76, 13);
            this.DropOffDate.TabIndex = 1;
            this.DropOffDate.Text = "Drop Off Date:";
            // 
            // EstimatedDeliveryDate
            // 
            this.EstimatedDeliveryDate.AutoSize = true;
            this.EstimatedDeliveryDate.Location = new System.Drawing.Point(12, 69);
            this.EstimatedDeliveryDate.Name = "EstimatedDeliveryDate";
            this.EstimatedDeliveryDate.Size = new System.Drawing.Size(123, 13);
            this.EstimatedDeliveryDate.TabIndex = 2;
            this.EstimatedDeliveryDate.Text = "Estimated Delivery Date:";
            // 
            // EstimatedDeliveryDateLabel
            // 
            this.EstimatedDeliveryDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EstimatedDeliveryDateLabel.Location = new System.Drawing.Point(15, 86);
            this.EstimatedDeliveryDateLabel.Name = "EstimatedDeliveryDateLabel";
            this.EstimatedDeliveryDateLabel.Size = new System.Drawing.Size(197, 23);
            this.EstimatedDeliveryDateLabel.TabIndex = 3;
            this.EstimatedDeliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 126);
            this.Controls.Add(this.EstimatedDeliveryDateLabel);
            this.Controls.Add(this.EstimatedDeliveryDate);
            this.Controls.Add(this.DropOffDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DateTimePicker";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.DateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DropOffDate;
        private System.Windows.Forms.Label EstimatedDeliveryDate;
        private System.Windows.Forms.Label EstimatedDeliveryDateLabel;
    }
}

