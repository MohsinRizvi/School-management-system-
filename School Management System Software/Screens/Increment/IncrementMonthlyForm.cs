using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen;

namespace School_Management_System_Software.Models.Increment
{
    public partial class IncrementMonthlyForm : TemplateForm
    {
        public IncrementMonthlyForm()
        {
            InitializeComponent();
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            ByGRForm bgrfrm = new ByGRForm();
            bgrfrm.ShowDialog();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            AnnualByClassForm bsf = new AnnualByClassForm();
            bsf.ShowDialog();
        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {
            AnnualByAllClasses bac = new AnnualByAllClasses();
            bac.ShowDialog();
        }
    }
}
