namespace School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen
{
    partial class AnnualByClassForm
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
            this.IncreaseAmountButton = new System.Windows.Forms.Button();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.GRNoGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.MonthGroupBox.SuspendLayout();
            this.GRNoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncreaseAmountButton
            // 
            this.IncreaseAmountButton.Location = new System.Drawing.Point(404, 42);
            this.IncreaseAmountButton.Name = "IncreaseAmountButton";
            this.IncreaseAmountButton.Size = new System.Drawing.Size(116, 49);
            this.IncreaseAmountButton.TabIndex = 7;
            this.IncreaseAmountButton.Text = "Increase Amount";
            this.IncreaseAmountButton.UseVisualStyleBackColor = true;
            this.IncreaseAmountButton.Click += new System.EventHandler(this.IncreaseAmountButton_Click);
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.AmountTextBox);
            this.MonthGroupBox.Location = new System.Drawing.Point(258, 13);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(127, 98);
            this.MonthGroupBox.TabIndex = 6;
            this.MonthGroupBox.TabStop = false;
            this.MonthGroupBox.Text = "Amount";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(11, 42);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(105, 23);
            this.AmountTextBox.TabIndex = 0;
            // 
            // GRNoGroupBox
            // 
            this.GRNoGroupBox.Controls.Add(this.ClassesComboBox);
            this.GRNoGroupBox.Controls.Add(this.ClassLabel);
            this.GRNoGroupBox.Location = new System.Drawing.Point(18, 12);
            this.GRNoGroupBox.Name = "GRNoGroupBox";
            this.GRNoGroupBox.Size = new System.Drawing.Size(224, 98);
            this.GRNoGroupBox.TabIndex = 5;
            this.GRNoGroupBox.TabStop = false;
            this.GRNoGroupBox.Text = "Class";
            // 
            // ClassesComboBox
            // 
            this.ClassesComboBox.FormattingEnabled = true;
            this.ClassesComboBox.Location = new System.Drawing.Point(81, 42);
            this.ClassesComboBox.Name = "ClassesComboBox";
            this.ClassesComboBox.Size = new System.Drawing.Size(121, 24);
            this.ClassesComboBox.TabIndex = 3;
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(23, 45);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(42, 17);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Class";
            // 
            // ByClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 123);
            this.Controls.Add(this.IncreaseAmountButton);
            this.Controls.Add(this.MonthGroupBox);
            this.Controls.Add(this.GRNoGroupBox);
            this.Name = "ByClassForm";
            this.Text = "ByClassForm";
            this.Load += new System.EventHandler(this.ByClassForm_Load);
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.GRNoGroupBox.ResumeLayout(false);
            this.GRNoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IncreaseAmountButton;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.GroupBox GRNoGroupBox;
        private System.Windows.Forms.ComboBox ClassesComboBox;
        private System.Windows.Forms.Label ClassLabel;
    }
}