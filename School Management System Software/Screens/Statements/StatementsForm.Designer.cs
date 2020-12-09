namespace School_Management_System_Software.Screens.Statements
{
    partial class StatementsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllStudentsButton = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.GRButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllStudentsButton);
            this.panel1.Controls.Add(this.ClassButton);
            this.panel1.Controls.Add(this.GRButton);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 79);
            this.panel1.TabIndex = 4;
            // 
            // AllStudentsButton
            // 
            this.AllStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStudentsButton.Location = new System.Drawing.Point(425, 3);
            this.AllStudentsButton.Name = "AllStudentsButton";
            this.AllStudentsButton.Size = new System.Drawing.Size(205, 71);
            this.AllStudentsButton.TabIndex = 2;
            this.AllStudentsButton.Text = "All Students";
            this.AllStudentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllStudentsButton.UseVisualStyleBackColor = true;
            this.AllStudentsButton.Click += new System.EventHandler(this.AllStudentsButton_Click);
            // 
            // ClassButton
            // 
            this.ClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassButton.Location = new System.Drawing.Point(214, 3);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(205, 71);
            this.ClassButton.TabIndex = 1;
            this.ClassButton.Text = "Dues Statement";
            this.ClassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // GRButton
            // 
            this.GRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRButton.Location = new System.Drawing.Point(3, 3);
            this.GRButton.Name = "GRButton";
            this.GRButton.Size = new System.Drawing.Size(205, 71);
            this.GRButton.TabIndex = 0;
            this.GRButton.Text = "Daily Earnings";
            this.GRButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GRButton.UseVisualStyleBackColor = true;
            this.GRButton.Click += new System.EventHandler(this.GRButton_Click);
            // 
            // StatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 96);
            this.Controls.Add(this.panel1);
            this.Name = "StatementsForm";
            this.Text = "StatementsForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AllStudentsButton;
        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button GRButton;


    }
}