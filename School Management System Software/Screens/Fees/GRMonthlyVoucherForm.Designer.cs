namespace School_Management_System_Software.Screens.Fees
{
    partial class GRMonthlyVoucherForm
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
            this.GRLabel = new System.Windows.Forms.Label();
            this.GRNoGroupBox = new System.Windows.Forms.GroupBox();
            this.GRButton = new System.Windows.Forms.Button();
            this.GRTextBox = new System.Windows.Forms.TextBox();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.IsAnnualFeesCheckBox = new System.Windows.Forms.CheckBox();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.GenerateVoucherButton = new System.Windows.Forms.Button();
            this.GRNoGroupBox.SuspendLayout();
            this.MonthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRLabel
            // 
            this.GRLabel.AutoSize = true;
            this.GRLabel.Location = new System.Drawing.Point(8, 44);
            this.GRLabel.Name = "GRLabel";
            this.GRLabel.Size = new System.Drawing.Size(45, 17);
            this.GRLabel.TabIndex = 0;
            this.GRLabel.Text = "G.R #";
            // 
            // GRNoGroupBox
            // 
            this.GRNoGroupBox.Controls.Add(this.GRButton);
            this.GRNoGroupBox.Controls.Add(this.GRTextBox);
            this.GRNoGroupBox.Controls.Add(this.GRLabel);
            this.GRNoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GRNoGroupBox.Name = "GRNoGroupBox";
            this.GRNoGroupBox.Size = new System.Drawing.Size(224, 98);
            this.GRNoGroupBox.TabIndex = 1;
            this.GRNoGroupBox.TabStop = false;
            this.GRNoGroupBox.Text = "G.R Number";
            // 
            // GRButton
            // 
            this.GRButton.Location = new System.Drawing.Point(131, 41);
            this.GRButton.Name = "GRButton";
            this.GRButton.Size = new System.Drawing.Size(75, 23);
            this.GRButton.TabIndex = 2;
            this.GRButton.Text = "Select";
            this.GRButton.UseVisualStyleBackColor = true;
            this.GRButton.Click += new System.EventHandler(this.GRButton_Click);
            // 
            // GRTextBox
            // 
            this.GRTextBox.Enabled = false;
            this.GRTextBox.Location = new System.Drawing.Point(59, 41);
            this.GRTextBox.Name = "GRTextBox";
            this.GRTextBox.Size = new System.Drawing.Size(66, 23);
            this.GRTextBox.TabIndex = 1;
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.IsAnnualFeesCheckBox);
            this.MonthGroupBox.Controls.Add(this.MonthPicker);
            this.MonthGroupBox.Location = new System.Drawing.Point(263, 12);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(127, 98);
            this.MonthGroupBox.TabIndex = 2;
            this.MonthGroupBox.TabStop = false;
            this.MonthGroupBox.Text = "Month";
            // 
            // IsAnnualFeesCheckBox
            // 
            this.IsAnnualFeesCheckBox.AutoSize = true;
            this.IsAnnualFeesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAnnualFeesCheckBox.Location = new System.Drawing.Point(16, 71);
            this.IsAnnualFeesCheckBox.Name = "IsAnnualFeesCheckBox";
            this.IsAnnualFeesCheckBox.Size = new System.Drawing.Size(94, 19);
            this.IsAnnualFeesCheckBox.TabIndex = 1;
            this.IsAnnualFeesCheckBox.Text = "Annual Fees";
            this.IsAnnualFeesCheckBox.UseVisualStyleBackColor = true;
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
            // GenerateVoucherButton
            // 
            this.GenerateVoucherButton.Location = new System.Drawing.Point(406, 40);
            this.GenerateVoucherButton.Name = "GenerateVoucherButton";
            this.GenerateVoucherButton.Size = new System.Drawing.Size(116, 49);
            this.GenerateVoucherButton.TabIndex = 3;
            this.GenerateVoucherButton.Text = "Generate Voucher";
            this.GenerateVoucherButton.UseVisualStyleBackColor = true;
            this.GenerateVoucherButton.Click += new System.EventHandler(this.GenerateVoucherButton_Click);
            // 
            // GRMonthlyVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 123);
            this.Controls.Add(this.GenerateVoucherButton);
            this.Controls.Add(this.MonthGroupBox);
            this.Controls.Add(this.GRNoGroupBox);
            this.Name = "GRMonthlyVoucherForm";
            this.Text = "G.R# Voucher Form";
            this.Load += new System.EventHandler(this.GRVoucherForm_Load);
            this.GRNoGroupBox.ResumeLayout(false);
            this.GRNoGroupBox.PerformLayout();
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GRLabel;
        private System.Windows.Forms.GroupBox GRNoGroupBox;
        private System.Windows.Forms.TextBox GRTextBox;
        private System.Windows.Forms.Button GRButton;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.DateTimePicker MonthPicker;
        private System.Windows.Forms.Button GenerateVoucherButton;
        private System.Windows.Forms.CheckBox IsAnnualFeesCheckBox;
    }
}