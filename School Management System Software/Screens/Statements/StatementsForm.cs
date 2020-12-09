using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;

namespace School_Management_System_Software.Screens.Statements
{
    public partial class StatementsForm : TemplateForm
    {
        public StatementsForm()
        {
            InitializeComponent();
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            ReportForm rpf = new ReportForm();
            rpf.Show();
            rpf.ShowDailyEarningsStatement();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            ReportForm rpf = new ReportForm();
            rpf.Show();
            rpf.ShowDuesStatement();
        }

        private void AllStudentsButton_Click(object sender, EventArgs e)
        {
            ReportForm rpf = new ReportForm();
            rpf.Show();
            rpf.ShowAllStudentsStatement();
        }
    }
}
