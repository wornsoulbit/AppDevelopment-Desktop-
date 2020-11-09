namespace HugeIntegerGUI {
    partial class HugeIntegerForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HugeInteger1 = new System.Windows.Forms.TextBox();
            this.HugeInteger2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.IsEqualTo = new System.Windows.Forms.Button();
            this.IsNotEqualTo = new System.Windows.Forms.Button();
            this.IsGreaterThan = new System.Windows.Forms.Button();
            this.IsLessThan = new System.Windows.Forms.Button();
            this.IsLessThanOrEqual = new System.Windows.Forms.Button();
            this.IsGreaterThanOrEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Huge Integer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Huge Integer 2";
            // 
            // HugeInteger1
            // 
            this.HugeInteger1.Location = new System.Drawing.Point(29, 57);
            this.HugeInteger1.Name = "HugeInteger1";
            this.HugeInteger1.Size = new System.Drawing.Size(318, 20);
            this.HugeInteger1.TabIndex = 4;
            // 
            // HugeInteger2
            // 
            this.HugeInteger2.Location = new System.Drawing.Point(29, 117);
            this.HugeInteger2.Name = "HugeInteger2";
            this.HugeInteger2.Size = new System.Drawing.Size(318, 20);
            this.HugeInteger2.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(27, 152);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Location = new System.Drawing.Point(14, 307);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(333, 44);
            this.OutputLabel.TabIndex = 7;
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(108, 152);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 23);
            this.SubtractButton.TabIndex = 8;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(190, 151);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 23);
            this.MultiplyButton.TabIndex = 9;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(272, 151);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 10;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // IsEqualTo
            // 
            this.IsEqualTo.Location = new System.Drawing.Point(27, 188);
            this.IsEqualTo.Name = "IsEqualTo";
            this.IsEqualTo.Size = new System.Drawing.Size(75, 39);
            this.IsEqualTo.TabIndex = 11;
            this.IsEqualTo.Text = "Is Equal To";
            this.IsEqualTo.UseVisualStyleBackColor = true;
            this.IsEqualTo.Click += new System.EventHandler(this.IsEqualTo_Click);
            // 
            // IsNotEqualTo
            // 
            this.IsNotEqualTo.Location = new System.Drawing.Point(108, 188);
            this.IsNotEqualTo.Name = "IsNotEqualTo";
            this.IsNotEqualTo.Size = new System.Drawing.Size(75, 39);
            this.IsNotEqualTo.TabIndex = 12;
            this.IsNotEqualTo.Text = "Is Not Equal To";
            this.IsNotEqualTo.UseVisualStyleBackColor = true;
            this.IsNotEqualTo.Click += new System.EventHandler(this.IsNotEqualTo_Click);
            // 
            // IsGreaterThan
            // 
            this.IsGreaterThan.Location = new System.Drawing.Point(190, 188);
            this.IsGreaterThan.Name = "IsGreaterThan";
            this.IsGreaterThan.Size = new System.Drawing.Size(75, 39);
            this.IsGreaterThan.TabIndex = 13;
            this.IsGreaterThan.Text = "Is Greater Than";
            this.IsGreaterThan.UseVisualStyleBackColor = true;
            this.IsGreaterThan.Click += new System.EventHandler(this.IsGreaterThan_Click);
            // 
            // IsLessThan
            // 
            this.IsLessThan.Location = new System.Drawing.Point(272, 188);
            this.IsLessThan.Name = "IsLessThan";
            this.IsLessThan.Size = new System.Drawing.Size(75, 39);
            this.IsLessThan.TabIndex = 14;
            this.IsLessThan.Text = "Is Less Than";
            this.IsLessThan.UseVisualStyleBackColor = true;
            this.IsLessThan.Click += new System.EventHandler(this.IsLessThan_Click);
            // 
            // IsLessThanOrEqual
            // 
            this.IsLessThanOrEqual.Location = new System.Drawing.Point(272, 233);
            this.IsLessThanOrEqual.Name = "IsLessThanOrEqual";
            this.IsLessThanOrEqual.Size = new System.Drawing.Size(75, 54);
            this.IsLessThanOrEqual.TabIndex = 19;
            this.IsLessThanOrEqual.Text = "Is Less Than or Equal";
            this.IsLessThanOrEqual.UseVisualStyleBackColor = true;
            this.IsLessThanOrEqual.Click += new System.EventHandler(this.IsLessThanOrEqual_Click_1);
            // 
            // IsGreaterThanOrEqual
            // 
            this.IsGreaterThanOrEqual.Location = new System.Drawing.Point(190, 233);
            this.IsGreaterThanOrEqual.Name = "IsGreaterThanOrEqual";
            this.IsGreaterThanOrEqual.Size = new System.Drawing.Size(75, 54);
            this.IsGreaterThanOrEqual.TabIndex = 18;
            this.IsGreaterThanOrEqual.Text = "Is Greater Than or Equal";
            this.IsGreaterThanOrEqual.UseVisualStyleBackColor = true;
            this.IsGreaterThanOrEqual.Click += new System.EventHandler(this.IsGreaterThanOrEqual_Click);
            // 
            // HugeIntegerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 360);
            this.Controls.Add(this.IsLessThanOrEqual);
            this.Controls.Add(this.IsGreaterThanOrEqual);
            this.Controls.Add(this.IsLessThan);
            this.Controls.Add(this.IsGreaterThan);
            this.Controls.Add(this.IsNotEqualTo);
            this.Controls.Add(this.IsEqualTo);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HugeInteger2);
            this.Controls.Add(this.HugeInteger1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HugeIntegerForm";
            this.Text = "Huge Integer Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HugeInteger1;
        private System.Windows.Forms.TextBox HugeInteger2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button IsEqualTo;
        private System.Windows.Forms.Button IsNotEqualTo;
        private System.Windows.Forms.Button IsGreaterThan;
        private System.Windows.Forms.Button IsLessThan;
        private System.Windows.Forms.Button IsLessThanOrEqual;
        private System.Windows.Forms.Button IsGreaterThanOrEqual;
    }
}

