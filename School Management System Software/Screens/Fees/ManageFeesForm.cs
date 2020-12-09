using School_Management_System_Software.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System_Software.Screens.Fees
{
    public partial class ManageFeesForm : TemplateForm
    {
        public ManageFeesForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageFeesForm_Load(object sender, EventArgs e)
        {

        }

        private void byGRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRMonthlyVoucherForm gr = new GRMonthlyVoucherForm();
            gr.ShowDialog();
        }

        private void byClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMonthlyVoucherForm cmv = new ClassMonthlyVoucherForm();
            cmv.ShowDialog();
        }

        private void allClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClassesMonthlyVoucherForm acf = new AllClassesMonthlyVoucherForm();
            acf.ShowDialog();
        }
    }
}
