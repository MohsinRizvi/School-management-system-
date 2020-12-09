using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Screens.Increment.Increment_ExtraFees_Screen;

namespace School_Management_System_Software.Screens.Increment
{
    public partial class IncrementExtraFeesForm : TemplateForm
    {
        public IncrementExtraFeesForm()
        {
            InitializeComponent();
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            ExtraFeesByGRForm efbgf = new ExtraFeesByGRForm();
            efbgf.ShowDialog();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            ExtraFeesByClassForm efbcf = new ExtraFeesByClassForm();
            efbcf.ShowDialog();
        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {
            ExtraFeesByAllClasses efbac = new ExtraFeesByAllClasses();
            efbac.ShowDialog();
        }
    }
}
