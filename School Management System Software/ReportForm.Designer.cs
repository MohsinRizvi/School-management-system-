namespace School_Management_System_Software
{
    partial class ReportForm
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
            this.CrystalReptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalReptViewer
            // 
            this.CrystalReptViewer.ActiveViewIndex = -1;
            this.CrystalReptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReptViewer.Location = new System.Drawing.Point(0, 0);
            this.CrystalReptViewer.Name = "CrystalReptViewer";
            this.CrystalReptViewer.ShowCloseButton = false;
            this.CrystalReptViewer.ShowGroupTreeButton = false;
            this.CrystalReptViewer.ShowParameterPanelButton = false;
            this.CrystalReptViewer.Size = new System.Drawing.Size(787, 506);
            this.CrystalReptViewer.TabIndex = 0;
            this.CrystalReptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrystalReptViewer.Load += new System.EventHandler(this.CrystalReptViewer_Load);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 506);
            this.Controls.Add(this.CrystalReptViewer);
            this.Name = "ReportForm";
            this.Text = "Report Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReptViewer;
    }
}