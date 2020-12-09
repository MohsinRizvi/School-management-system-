namespace School_Management_System_Software.Screens.Fees
{
    partial class AllClassesMonthlyVoucherForm
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
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.IsAnnualFeesCheckBox = new System.Windows.Forms.CheckBox();
            this.MonthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateVoucherButton
            // 
            this.GenerateVoucherButton.Location = new System.Drawing.Point(294, 42);
            this.GenerateVoucherButton.Name = "GenerateVoucherButton";
            this.GenerateVoucherButton.Size = new System.Drawing.Size(233, 49);
            this.GenerateVoucherButton.TabIndex = 8;
            this.GenerateVoucherButton.Text = "Generate Voucher";
            this.GenerateVoucherButton.UseVisualStyleBackColor = true;
            this.GenerateVoucherButton.Click += new System.EventHandler(this.GenerateVoucherButton_Click);
            // 
            // MonthPicker
            // 
            this.MonthPicker.CustomFormat = "MMMM";
            this.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthPicker.Location = new System.Drawing.Point(16, 41);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(211, 23);
            this.MonthPicker.TabIndex = 0;
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.IsAnnualFeesCheckBox);
            this.MonthGroupBox.Controls.Add(this.MonthPicker);
            this.MonthGroupBox.Location = new System.Drawing.Point(23, 12);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(244, 98);
            this.MonthGroupBox.TabIndex = 7;
            this.MonthGroupBox.TabStop = false;
            this.MonthGroupBox.Text = "Month";
            // 
            // IsAnnualFeesCheckBox
            // 
            this.IsAnnualFeesCheckBox.AutoSize = true;
            this.IsAnnualFeesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAnnualFeesCheckBox.Location = new System.Drawing.Point(16, 73);
            this.IsAnnualFeesCheckBox.Name = "IsAnnualFeesCheckBox";
            this.IsAnnualFeesCheckBox.Size = new System.Drawing.Size(94, 19);
            this.IsAnnualFeesCheckBox.TabIndex = 8;
            this.IsAnnualFeesCheckBox.Text = "Annual Fees";
            this.IsAnnualFeesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AllClassesMonthlyVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 123);
            this.Controls.Add(this.GenerateVoucherButton);
            this.Controls.Add(this.MonthGroupBox);
            this.Name = "AllClassesMonthlyVoucherForm";
            this.Text = "AllClassesMonthlyVoucherForm";
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateVoucherButton;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.CheckBox IsAnnualFeesCheckBox;
    }
}