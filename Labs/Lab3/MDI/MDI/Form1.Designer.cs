namespace MDI {
    partial class MDI {
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lavenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVirticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.WindowToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(407, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavenderToolStripMenuItem,
            this.purpleFlowersToolStripMenuItem,
            this.yellowFlowersToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // lavenderToolStripMenuItem
            // 
            this.lavenderToolStripMenuItem.Name = "lavenderToolStripMenuItem";
            this.lavenderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.lavenderToolStripMenuItem.Text = "Lavender Flowers";
            this.lavenderToolStripMenuItem.Click += new System.EventHandler(this.LavenderToolStripMenuItem_Click);
            // 
            // purpleFlowersToolStripMenuItem
            // 
            this.purpleFlowersToolStripMenuItem.Name = "purpleFlowersToolStripMenuItem";
            this.purpleFlowersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.purpleFlowersToolStripMenuItem.Text = "Purple Flowers";
            this.purpleFlowersToolStripMenuItem.Click += new System.EventHandler(this.PurpleFlowersToolStripMenuItem_Click);
            // 
            // yellowFlowersToolStripMenuItem
            // 
            this.yellowFlowersToolStripMenuItem.Name = "yellowFlowersToolStripMenuItem";
            this.yellowFlowersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.yellowFlowersToolStripMenuItem.Text = "Yellow Flowers";
            this.yellowFlowersToolStripMenuItem.Click += new System.EventHandler(this.YellowFlowersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casadeToolStripMenuItem,
            this.tileHorizontallyToolStripMenuItem,
            this.tileVirticalToolStripMenuItem,
            this.toolStripSeparator1});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.WindowToolStripMenuItem.Text = "Window";
            // 
            // casadeToolStripMenuItem
            // 
            this.casadeToolStripMenuItem.Name = "casadeToolStripMenuItem";
            this.casadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.casadeToolStripMenuItem.Text = "Casade";
            this.casadeToolStripMenuItem.Click += new System.EventHandler(this.CasadeToolStripMenuItem_Click);
            // 
            // tileHorizontallyToolStripMenuItem
            // 
            this.tileHorizontallyToolStripMenuItem.Name = "tileHorizontallyToolStripMenuItem";
            this.tileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontallyToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontallyToolStripMenuItem_Click);
            // 
            // tileVirticalToolStripMenuItem
            // 
            this.tileVirticalToolStripMenuItem.Name = "tileVirticalToolStripMenuItem";
            this.tileVirticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVirticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVirticalToolStripMenuItem.Click += new System.EventHandler(this.TileVirticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 355);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "MDI";
            this.Text = "Using MDI";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lavenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVirticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

