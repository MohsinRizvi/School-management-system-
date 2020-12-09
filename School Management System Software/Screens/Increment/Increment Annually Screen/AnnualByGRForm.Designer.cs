namespace School_Management_System_Software.Screens.Increment.Increment_Annually_Screen
{
    partial class AnnualByGRForm
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
            this.GRNoGroupBox = new System.Windows.Forms.GroupBox();
            this.GRButton = new System.Windows.Forms.Button();
            this.GRTextBox = new System.Windows.Forms.TextBox();
            this.GRLabel = new System.Windows.Forms.Label();
            this.MonthGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.IncreaseAmountButton = new System.Windows.Forms.Button();
            this.GRNoGroupBox.SuspendLayout();
            this.MonthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRNoGroupBox
            // 
            this.GRNoGroupBox.Controls.Add(this.GRButton);
            this.GRNoGroupBox.Controls.Add(this.GRTextBox);
            this.GRNoGroupBox.Controls.Add(this.GRLabel);
            this.GRNoGroupBox.Location = new System.Drawing.Point(10, 13);
            this.GRNoGroupBox.Name = "GRNoGroupBox";
            this.GRNoGroupBox.Size = new System.Drawing.Size(224, 98);
            this.GRNoGroupBox.TabIndex = 2;
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
            // GRLabel
            // 
            this.GRLabel.AutoSize = true;
            this.GRLabel.Location = new System.Drawing.Point(8, 44);
            this.GRLabel.Name = "GRLabel";
            this.GRLabel.Size = new System.Drawing.Size(45, 17);
            this.GRLabel.TabIndex = 0;
            this.GRLabel.Text = "G.R #";
            // 
            // MonthGroupBox
            // 
            this.MonthGroupBox.Controls.Add(this.AmountTextBox);
            this.MonthGroupBox.Location = new System.Drawing.Point(250, 14);
            this.MonthGroupBox.Name = "MonthGroupBox";
            this.MonthGroupBox.Size = new System.Drawing.Size(127, 98);
            this.MonthGroupBox.TabIndex = 3;
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
            // IncreaseAmountButton
            // 
            this.IncreaseAmountButton.Location = new System.Drawing.Point(396, 43);
            this.IncreaseAmountButton.Name = "IncreaseAmountButton";
            this.IncreaseAmountButton.Size = new System.Drawing.Size(116, 49);
            this.IncreaseAmountButton.TabIndex = 4;
            this.IncreaseAmountButton.Text = "Increase Amount";
            this.IncreaseAmountButton.UseVisualStyleBackColor = true;
            this.IncreaseAmountButton.Click += new System.EventHandler(this.IncreaseAmountButton_Click);
            // 
            // AnnualByGRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 123);
            this.Controls.Add(this.IncreaseAmountButton);
            this.Controls.Add(this.MonthGroupBox);
            this.Controls.Add(this.GRNoGroupBox);
            this.Name = "AnnualByGRForm";
            this.Text = "Annual By GR Screen";
            this.Load += new System.EventHandler(this.AnnualByGRForm_Load);
            this.GRNoGroupBox.ResumeLayout(false);
            this.GRNoGroupBox.PerformLayout();
            this.MonthGroupBox.ResumeLayout(false);
            this.MonthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRNoGroupBox;
        private System.Windows.Forms.Button GRButton;
        private System.Windows.Forms.TextBox GRTextBox;
        private System.Windows.Forms.Label GRLabel;
        private System.Windows.Forms.GroupBox MonthGroupBox;
        private System.Windows.Forms.Button IncreaseAmountButton;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}