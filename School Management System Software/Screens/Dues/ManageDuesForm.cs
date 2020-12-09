using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;

namespace School_Management_System_Software.Screens.Dues
{
    public partial class ManageDuesForm : TemplateForm
    {
        public ManageDuesForm()
        {
            InitializeComponent();
        }

        private void allMonthDuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthDuesForm df = new MonthDuesForm();
            df.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allAnnualDuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnualDuesForm adf = new AnnualDuesForm();
            adf.ShowDialog();
        }

        private void allExtraFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraDuesForm edf = new ExtraDuesForm();
            edf.ShowDialog();
        }
    }
}
