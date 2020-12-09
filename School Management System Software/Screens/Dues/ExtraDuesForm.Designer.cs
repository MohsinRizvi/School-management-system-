namespace School_Management_System_Software.Screens.Dues
{
    partial class ExtraDuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraDuesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaidButton = new System.Windows.Forms.Button();
            this.SearchBarTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBarComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtraDuesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraDuesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PaidButton
            // 
            this.PaidButton.Image = ((System.Drawing.Image)(resources.GetObject("PaidButton.Image")));
            this.PaidButton.Location = new System.Drawing.Point(758, 25);
            this.PaidButton.Name = "PaidButton";
            this.PaidButton.Size = new System.Drawing.Size(72, 31);
            this.PaidButton.TabIndex = 14;
            this.PaidButton.UseVisualStyleBackColor = true;
            this.PaidButton.Click += new System.EventHandler(this.PaidButton_Click);
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Location = new System.Drawing.Point(195, 29);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(144, 23);
            this.SearchBarTextBox.TabIndex = 13;
            this.SearchBarTextBox.TextChanged += new System.EventHandler(this.SearchBarTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(6, 32);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 12;
            this.SearchLabel.Text = "Search :";
            // 
            // SearchBarComboBox
            // 
            this.SearchBarComboBox.FormattingEnabled = true;
            this.SearchBarComboBox.Items.AddRange(new object[] {
            "G.R#",
            "Name",
            "Father Name",
            "Year"});
            this.SearchBarComboBox.Location = new System.Drawing.Point(87, 29);
            this.SearchBarComboBox.Name = "SearchBarComboBox";
            this.SearchBarComboBox.Size = new System.Drawing.Size(104, 24);
            this.SearchBarComboBox.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 10;
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
            // ExtraDuesDataGridView
            // 
            this.ExtraDuesDataGridView.AllowUserToAddRows = false;
            this.ExtraDuesDataGridView.AllowUserToDeleteRows = false;
            this.ExtraDuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExtraDuesDataGridView.Location = new System.Drawing.Point(0, 57);
            this.ExtraDuesDataGridView.Name = "ExtraDuesDataGridView";
            this.ExtraDuesDataGridView.Size = new System.Drawing.Size(838, 446);
            this.ExtraDuesDataGridView.TabIndex = 16;
            // 
            // ExtraDuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.ExtraDuesDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PaidButton);
            this.Controls.Add(this.SearchBarTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBarComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ExtraDuesForm";
            this.Text = "Extra Dues Screen";
            this.Load += new System.EventHandler(this.ExtraDuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraDuesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PaidButton;
        private System.Windows.Forms.TextBox SearchBarTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchBarComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView ExtraDuesDataGridView;
    }
}