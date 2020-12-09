namespace School_Management_System_Software.Models.Increment
{
    partial class IncrementMonthlyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementMonthlyForm));
            this.GRButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassesButton = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRButton
            // 
            this.GRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRButton.Image = ((System.Drawing.Image)(resources.GetObject("GRButton.Image")));
            this.GRButton.Location = new System.Drawing.Point(3, 3);
            this.GRButton.Name = "GRButton";
            this.GRButton.Size = new System.Drawing.Size(205, 71);
            this.GRButton.TabIndex = 0;
            this.GRButton.Text = "G.R #";
            this.GRButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GRButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GRButton.UseVisualStyleBackColor = true;
            this.GRButton.Click += new System.EventHandler(this.GRButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClassesButton);
            this.panel1.Controls.Add(this.ClassButton);
            this.panel1.Controls.Add(this.GRButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 79);
            this.panel1.TabIndex = 3;
            // 
            // ClassesButton
            // 
            this.ClassesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesButton.Image = ((System.Drawing.Image)(resources.GetObject("ClassesButton.Image")));
            this.ClassesButton.Location = new System.Drawing.Point(425, 3);
            this.ClassesButton.Name = "ClassesButton";
            this.ClassesButton.Size = new System.Drawing.Size(205, 71);
            this.ClassesButton.TabIndex = 2;
            this.ClassesButton.Text = "All Classes";
            this.ClassesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClassesButton.UseVisualStyleBackColor = true;
            this.ClassesButton.Click += new System.EventHandler(this.ClassesButton_Click);
            // 
            // ClassButton
            // 
            this.ClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassButton.Image = ((System.Drawing.Image)(resources.GetObject("ClassButton.Image")));
            this.ClassButton.Location = new System.Drawing.Point(214, 3);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(205, 71);
            this.ClassButton.TabIndex = 1;
            this.ClassButton.Text = "Class";
            this.ClassButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // IncrementMonthlyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 96);
            this.Controls.Add(this.panel1);
            this.Name = "IncrementMonthlyForm";
            this.Text = "Increment Monthly Screen";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GRButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClassesButton;
        private System.Windows.Forms.Button ClassButton;
    }
}