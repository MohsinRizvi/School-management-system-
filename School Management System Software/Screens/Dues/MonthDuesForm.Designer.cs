namespace School_Management_System_Software.Screens.Dues
{
    partial class MonthDuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthDuesForm));
            this.PaidButton = new System.Windows.Forms.Button();
            this.SearchBarTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBarComboBox = new System.Windows.Forms.ComboBox();
            this.DuesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DuesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaidButton
            // 
            this.PaidButton.Image = ((System.Drawing.Image)(resources.GetObject("PaidButton.Image")));
            this.PaidButton.Location = new System.Drawing.Point(753, 27);
            this.PaidButton.Name = "PaidButton";
            this.PaidButton.Size = new System.Drawing.Size(72, 31);
            this.PaidButton.TabIndex = 8;
            this.PaidButton.UseVisualStyleBackColor = true;
            this.PaidButton.Click += new System.EventHandler(this.PaidButton_Click);
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Location = new System.Drawing.Point(190, 31);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(144, 23);
            this.SearchBarTextBox.TabIndex = 7;
            this.SearchBarTextBox.TextChanged += new System.EventHandler(this.SearchBarTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(1, 34);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search :";
            // 
            // SearchBarComboBox
            // 
            this.SearchBarComboBox.FormattingEnabled = true;
            this.SearchBarComboBox.Items.AddRange(new object[] {
            "G.R#",
            "Name",
            "Father Name",
            "Month Name",
            "Year"});
            this.SearchBarComboBox.Location = new System.Drawing.Point(82, 31);
            this.SearchBarComboBox.Name = "SearchBarComboBox";
            this.SearchBarComboBox.Size = new System.Drawing.Size(104, 24);
            this.SearchBarComboBox.TabIndex = 5;
            // 
            // DuesDataGridView
            // 
            this.DuesDataGridView.AllowUserToAddRows = false;
            this.DuesDataGridView.AllowUserToDeleteRows = false;
            this.DuesDataGridView.AllowUserToOrderColumns = true;
            this.DuesDataGridView.AllowUserToResizeColumns = false;
            this.DuesDataGridView.AllowUserToResizeRows = false;
            this.DuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DuesDataGridView.Location = new System.Drawing.Point(0, 61);
            this.DuesDataGridView.Name = "DuesDataGridView";
            this.DuesDataGridView.Size = new System.Drawing.Size(838, 441);
            this.DuesDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MonthDuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PaidButton);
            this.Controls.Add(this.SearchBarTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBarComboBox);
            this.Controls.Add(this.DuesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MonthDuesForm";
            this.Text = "Month Dues Screen";
            this.Load += new System.EventHandler(this.ManageDuesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DuesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView DuesDataGridView;
        private System.Windows.Forms.TextBox SearchBarTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchBarComboBox;
        private System.Windows.Forms.Button PaidButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}