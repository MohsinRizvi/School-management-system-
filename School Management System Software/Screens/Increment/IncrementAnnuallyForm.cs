using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Screens.Increment.Increment_Annually_Screen;

namespace School_Management_System_Software.Screens.Increment
{
    public partial class IncrementAnnuallyForm : TemplateForm
    {
        public IncrementAnnuallyForm()
        {
            InitializeComponent();
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            AnnualByGRForm abgf = new AnnualByGRForm();
            abgf.ShowDialog();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            AnnualByClassForm abcf = new AnnualByClassForm();
            abcf.ShowDialog();
        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {
            AnnualByAllClasses abac = new AnnualByAllClasses();
            abac.ShowDialog();
        }
    }
}
