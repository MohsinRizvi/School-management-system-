using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Screens.Increment;

namespace School_Management_System_Software.Models.Increment
{
    public partial class ManageIncrementForm : TemplateForm
    {
        public ManageIncrementForm()
        {
            InitializeComponent();
        }

        private void incrementMonthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncrementMonthlyForm imf = new IncrementMonthlyForm();
            imf.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incrementAnnuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncrementAnnuallyForm iaf = new IncrementAnnuallyForm();
            iaf.ShowDialog();
        }

        private void incrementExtraFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncrementExtraFeesForm ieff = new IncrementExtraFeesForm();
            ieff.ShowDialog();
        }
    }
}
