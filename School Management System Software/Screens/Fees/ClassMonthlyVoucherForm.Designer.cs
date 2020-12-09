namespace School_Management_System_Software.Screens.Fees
{
    partial class ClassMonthlyVoucherForm
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
            this.GenerateVoucherButton = new System.Windows.Forms.Button();
            this.ClassGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.IsAnnualFeesCheckBox = new System.Windows.Forms.CheckBox();
            this.ClassGroupBox.SuspendLayout();
            this.MonthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateVoucherButton
            // 
            this.GenerateVoucherButton.Location = new System.Drawing.Point(408, 40);
            this.GenerateVoucherButton.Name = "GenerateVoucherButton";
            this.GenerateVoucherButton.Size = new System.Drawing.Size(116, 49);
            this.GenerateVoucherButton.TabIndex = 6;
            this.GenerateVoucherButton.Text = "Generate Voucher";
            this.GenerateVoucherButton.UseVisualStyleBackColor = true;
            this.GenerateVoucherButton.Click += new System.EventHandler(this.GenerateVoucherButton_Click);
            // 
            // ClassGroupBox
            // 
            this.ClassGroupBox.Controls.Add(this.ClassesComboBox);
            this.ClassGroupBox.Controls.Add(this.ClassLabel);
            this.ClassGroupBox.Location = new System.Drawing.Point(14, 12);
            this.ClassGroupBox.Name = "ClassGroupBox";
            this.ClassGroupBox.Size = new System.Drawing.Size(224, 98);
            this.ClassGroupBox.TabIndex = 4;
            this.ClassGroupBox.TabStop = false;
            this.ClassGroupBox.Text = "Class";
            // 
            // ClassesComboBox
            // 
            this.ClassesComboBox.FormattingEnabled = true;
            this.ClassesComboBox.Location = new System.Drawing.Point(66, 41);
            this.ClassesComboBox.Name = "ClassesComboBox";
            this.ClassesComboBox.Size = new System.Drawing.Size(121, 24);
            this.ClassesComboBox.TabIndex = 1;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(8, 44);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(42, 17);
            this.ClassLabel.TabIndex = 0;
            this.ClassLabel.Text = "Class";
            // 
            // MonthPicker
            // 
            this.MonthPicker.CustomFormat = "MMMM";
            this.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthPicker.Location = new System.Drawing.Point(16, 41);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(98, 23);
            this.MonthPicker.TabIndex = 0;
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.IsAnnualFeesCheckBox);
            this.MonthGroupBox.Controls.Add(this.MonthPicker);
            this.MonthGroupBox.Location = new System.Drawing.Point(265, 12);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(127, 98);
            this.MonthGroupBox.TabIndex = 5;
            this.MonthGroupBox.TabStop = false;
            this.MonthGroupBox.Text = "Month";
            // 
            // IsAnnualFeesCheckBox
            // 
            this.IsAnnualFeesCheckBox.AutoSize = true;
            this.IsAnnualFeesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAnnualFeesCheckBox.Location = new System.Drawing.Point(16, 70);
            this.IsAnnualFeesCheckBox.Name = "IsAnnualFeesCheckBox";
            this.IsAnnualFeesCheckBox.Size = new System.Drawing.Size(94, 19);
            this.IsAnnualFeesCheckBox.TabIndex = 7;
            this.IsAnnualFeesCheckBox.Text = "Annual Fees";
            this.IsAnnualFeesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClassMonthlyVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 123);
            this.Controls.Add(this.GenerateVoucherButton);
            this.Controls.Add(this.ClassGroupBox);
            this.Controls.Add(this.MonthGroupBox);
            this.Name = "ClassMonthlyVoucherForm";
            this.Text = "ClassMonthlyVoucherForm";
            this.Load += new System.EventHandler(this.ClassMonthlyVoucherForm_Load);
            this.ClassGroupBox.ResumeLayout(false);
            this.ClassGroupBox.PerformLayout();
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateVoucherButton;
        private System.Windows.Forms.GroupBox ClassGroupBox;
        private System.Windows.Forms.ComboBox ClassesComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.CheckBox IsAnnualFeesCheckBox;
    }
}