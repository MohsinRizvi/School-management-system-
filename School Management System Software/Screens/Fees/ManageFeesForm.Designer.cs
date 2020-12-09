namespace School_Management_System_Software.Screens.Fees
{
    partial class ManageFeesForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFeesForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addNewFeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // addNewFeesToolStripMenuItem
            // 
            this.addNewFeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byGRToolStripMenuItem,
            this.byClassToolStripMenuItem,
            this.allClassesToolStripMenuItem});
            this.addNewFeesToolStripMenuItem.Name = "addNewFeesToolStripMenuItem";
            this.addNewFeesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.addNewFeesToolStripMenuItem.Text = "Generate Vouchers";
            // 
            // byGRToolStripMenuItem
            // 
            this.byGRToolStripMenuItem.Name = "byGRToolStripMenuItem";
            this.byGRToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.byGRToolStripMenuItem.Text = "By G.R #";
            this.byGRToolStripMenuItem.Click += new System.EventHandler(this.byGRToolStripMenuItem_Click);
            // 
            // byClassToolStripMenuItem
            // 
            this.byClassToolStripMenuItem.Name = "byClassToolStripMenuItem";
            this.byClassToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.byClassToolStripMenuItem.Text = "By Class";
            this.byClassToolStripMenuItem.Click += new System.EventHandler(this.byClassToolStripMenuItem_Click);
            // 
            // allClassesToolStripMenuItem
            // 
            this.allClassesToolStripMenuItem.Name = "allClassesToolStripMenuItem";
            this.allClassesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.allClassesToolStripMenuItem.Text = "All Classes";
            this.allClassesToolStripMenuItem.Click += new System.EventHandler(this.allClassesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManageFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageFeesForm";
            this.Text = "Manage Fees Screen";
            this.Load += new System.EventHandler(this.ManageFeesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addNewFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClassesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}