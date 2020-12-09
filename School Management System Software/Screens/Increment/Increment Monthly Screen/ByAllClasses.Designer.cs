namespace School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen
{
    partial class AnnualByAllClasses
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
            this.MonthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncreaseAmountButton
            // 
            this.IncreaseAmountButton.Location = new System.Drawing.Point(160, 41);
            this.IncreaseAmountButton.Name = "IncreaseAmountButton";
            this.IncreaseAmountButton.Size = new System.Drawing.Size(116, 49);
            this.IncreaseAmountButton.TabIndex = 9;
            this.IncreaseAmountButton.Text = "Increase Amount";
            this.IncreaseAmountButton.UseVisualStyleBackColor = true;
            this.IncreaseAmountButton.Click += new System.EventHandler(this.IncreaseAmountButton_Click);
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.AmountTextBox);
            this.MonthGroupBox.Location = new System.Drawing.Point(14, 12);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(127, 98);
            this.MonthGroupBox.TabIndex = 8;
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
            // ByAllClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 123);
            this.Controls.Add(this.IncreaseAmountButton);
            this.Controls.Add(this.MonthGroupBox);
            this.Name = "ByAllClasses";
            this.Text = "ByAllClasses";
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IncreaseAmountButton;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}