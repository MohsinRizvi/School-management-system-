namespace School_Management_System_Software.Screens.Student
{
    partial class AllStudentsForm
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
            this.SearchBarTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBarComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Location = new System.Drawing.Point(192, 14);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(144, 23);
            this.SearchBarTextBox.TabIndex = 8;
            this.SearchBarTextBox.TextChanged += new System.EventHandler(this.SearchBarTextBox_TextChanged_1);
            
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(11, 20);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(57, 16);
            this.SearchLabel.TabIndex = 7;
            this.SearchLabel.Text = "Search :";
            // 
            // SearchBarComboBox
            // 
            this.SearchBarComboBox.FormattingEnabled = true;
            this.SearchBarComboBox.Items.AddRange(new object[] {
            "G.R#",
            "Name",
            "Father Name"});
            this.SearchBarComboBox.Location = new System.Drawing.Point(84, 14);
            this.SearchBarComboBox.Name = "SearchBarComboBox";
            this.SearchBarComboBox.Size = new System.Drawing.Size(104, 24);
            this.SearchBarComboBox.TabIndex = 6;
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToAddRows = false;
            this.StudentsDataGridView.AllowUserToDeleteRows = false;
            this.StudentsDataGridView.AllowUserToResizeColumns = false;
            this.StudentsDataGridView.AllowUserToResizeRows = false;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Location = new System.Drawing.Point(0, 42);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.Size = new System.Drawing.Size(838, 445);
            this.StudentsDataGridView.TabIndex = 5;
            this.StudentsDataGridView.DoubleClick += new System.EventHandler(this.StudentsDataGridView_DoubleClick);
            // 
            // AllStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.SearchBarTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBarComboBox);
            this.Controls.Add(this.StudentsDataGridView);
            this.Name = "AllStudentsForm";
            this.Text = "AllStudentsForm";
            this.Load += new System.EventHandler(this.AllStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBarTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox SearchBarComboBox;
        private System.Windows.Forms.DataGridView StudentsDataGridView;
    }
}