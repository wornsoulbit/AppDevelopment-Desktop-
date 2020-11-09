namespace TabControl {
    partial class TabControlForm {
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ColorTab = new System.Windows.Forms.TabPage();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.BlackRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeTab = new System.Windows.Forms.TabPage();
            this.FontSizeButton3 = new System.Windows.Forms.RadioButton();
            this.FontSizeButton2 = new System.Windows.Forms.RadioButton();
            this.FontSizeButton1 = new System.Windows.Forms.RadioButton();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.MessageButton2 = new System.Windows.Forms.RadioButton();
            this.MessageButton1 = new System.Windows.Forms.RadioButton();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.ColorTab.SuspendLayout();
            this.SizeTab.SuspendLayout();
            this.MessageTab.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ColorTab);
            this.Tabs.Controls.Add(this.SizeTab);
            this.Tabs.Controls.Add(this.MessageTab);
            this.Tabs.Controls.Add(this.AboutTab);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(200, 157);
            this.Tabs.TabIndex = 0;
            // 
            // ColorTab
            // 
            this.ColorTab.Controls.Add(this.GreenRadioButton);
            this.ColorTab.Controls.Add(this.RedRadioButton);
            this.ColorTab.Controls.Add(this.BlackRadioButton);
            this.ColorTab.Location = new System.Drawing.Point(4, 22);
            this.ColorTab.Name = "ColorTab";
            this.ColorTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColorTab.Size = new System.Drawing.Size(192, 131);
            this.ColorTab.TabIndex = 0;
            this.ColorTab.Text = "Color";
            this.ColorTab.UseVisualStyleBackColor = true;
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(7, 62);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRadioButton.TabIndex = 2;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.GreenRadioButton_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(7, 39);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.TabStop = true;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // BlackRadioButton
            // 
            this.BlackRadioButton.AutoSize = true;
            this.BlackRadioButton.Location = new System.Drawing.Point(7, 16);
            this.BlackRadioButton.Name = "BlackRadioButton";
            this.BlackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.BlackRadioButton.TabIndex = 0;
            this.BlackRadioButton.TabStop = true;
            this.BlackRadioButton.Text = "Black";
            this.BlackRadioButton.UseVisualStyleBackColor = true;
            this.BlackRadioButton.CheckedChanged += new System.EventHandler(this.BlackRadioButton_CheckedChanged);
            // 
            // SizeTab
            // 
            this.SizeTab.Controls.Add(this.FontSizeButton3);
            this.SizeTab.Controls.Add(this.FontSizeButton2);
            this.SizeTab.Controls.Add(this.FontSizeButton1);
            this.SizeTab.Location = new System.Drawing.Point(4, 22);
            this.SizeTab.Name = "SizeTab";
            this.SizeTab.Padding = new System.Windows.Forms.Padding(3);
            this.SizeTab.Size = new System.Drawing.Size(192, 131);
            this.SizeTab.TabIndex = 1;
            this.SizeTab.Text = "Size";
            this.SizeTab.UseVisualStyleBackColor = true;
            // 
            // FontSizeButton3
            // 
            this.FontSizeButton3.AutoSize = true;
            this.FontSizeButton3.Location = new System.Drawing.Point(6, 64);
            this.FontSizeButton3.Name = "FontSizeButton3";
            this.FontSizeButton3.Size = new System.Drawing.Size(63, 17);
            this.FontSizeButton3.TabIndex = 5;
            this.FontSizeButton3.TabStop = true;
            this.FontSizeButton3.Text = "20 point";
            this.FontSizeButton3.UseVisualStyleBackColor = true;
            this.FontSizeButton3.CheckedChanged += new System.EventHandler(this.FontSizeButton3_CheckedChanged);
            // 
            // FontSizeButton2
            // 
            this.FontSizeButton2.AutoSize = true;
            this.FontSizeButton2.Location = new System.Drawing.Point(6, 41);
            this.FontSizeButton2.Name = "FontSizeButton2";
            this.FontSizeButton2.Size = new System.Drawing.Size(63, 17);
            this.FontSizeButton2.TabIndex = 4;
            this.FontSizeButton2.TabStop = true;
            this.FontSizeButton2.Text = "16 point";
            this.FontSizeButton2.UseVisualStyleBackColor = true;
            this.FontSizeButton2.CheckedChanged += new System.EventHandler(this.FontSizeButton2_CheckedChanged);
            // 
            // FontSizeButton1
            // 
            this.FontSizeButton1.AutoSize = true;
            this.FontSizeButton1.Location = new System.Drawing.Point(6, 18);
            this.FontSizeButton1.Name = "FontSizeButton1";
            this.FontSizeButton1.Size = new System.Drawing.Size(63, 17);
            this.FontSizeButton1.TabIndex = 3;
            this.FontSizeButton1.TabStop = true;
            this.FontSizeButton1.Text = "12 point";
            this.FontSizeButton1.UseVisualStyleBackColor = true;
            this.FontSizeButton1.CheckedChanged += new System.EventHandler(this.FontSizeButton1_CheckedChanged);
            // 
            // MessageTab
            // 
            this.MessageTab.Controls.Add(this.MessageButton2);
            this.MessageTab.Controls.Add(this.MessageButton1);
            this.MessageTab.Location = new System.Drawing.Point(4, 22);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Padding = new System.Windows.Forms.Padding(3);
            this.MessageTab.Size = new System.Drawing.Size(192, 131);
            this.MessageTab.TabIndex = 2;
            this.MessageTab.Text = "Message";
            this.MessageTab.UseVisualStyleBackColor = true;
            // 
            // MessageButton2
            // 
            this.MessageButton2.AutoSize = true;
            this.MessageButton2.Location = new System.Drawing.Point(7, 50);
            this.MessageButton2.Name = "MessageButton2";
            this.MessageButton2.Size = new System.Drawing.Size(71, 17);
            this.MessageButton2.TabIndex = 1;
            this.MessageButton2.TabStop = true;
            this.MessageButton2.Text = "Goodbye!";
            this.MessageButton2.UseVisualStyleBackColor = true;
            this.MessageButton2.CheckedChanged += new System.EventHandler(this.MessageButton2_CheckedChanged);
            // 
            // MessageButton1
            // 
            this.MessageButton1.AutoSize = true;
            this.MessageButton1.Location = new System.Drawing.Point(7, 27);
            this.MessageButton1.Name = "MessageButton1";
            this.MessageButton1.Size = new System.Drawing.Size(52, 17);
            this.MessageButton1.TabIndex = 0;
            this.MessageButton1.TabStop = true;
            this.MessageButton1.Text = "Hello!";
            this.MessageButton1.UseVisualStyleBackColor = true;
            this.MessageButton1.CheckedChanged += new System.EventHandler(this.MessageButton1_CheckedChanged);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.AboutLabel);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(192, 131);
            this.AboutTab.TabIndex = 3;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // AboutLabel
            // 
            this.AboutLabel.Location = new System.Drawing.Point(3, 15);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(183, 51);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "Tabs are used to organize controls and conserve screen space.";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Location = new System.Drawing.Point(41, 172);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(140, 42);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 223);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Tabs);
            this.Name = "TabControlForm";
            this.Text = "Tab Control";
            this.Load += new System.EventHandler(this.TabControlForm_Load);
            this.Tabs.ResumeLayout(false);
            this.ColorTab.ResumeLayout(false);
            this.ColorTab.PerformLayout();
            this.SizeTab.ResumeLayout(false);
            this.SizeTab.PerformLayout();
            this.MessageTab.ResumeLayout(false);
            this.MessageTab.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ColorTab;
        private System.Windows.Forms.TabPage SizeTab;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton BlackRadioButton;
        private System.Windows.Forms.RadioButton FontSizeButton3;
        private System.Windows.Forms.RadioButton FontSizeButton2;
        private System.Windows.Forms.RadioButton FontSizeButton1;
        private System.Windows.Forms.TabPage MessageTab;
        private System.Windows.Forms.RadioButton MessageButton2;
        private System.Windows.Forms.RadioButton MessageButton1;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label MessageLabel;
    }
}

