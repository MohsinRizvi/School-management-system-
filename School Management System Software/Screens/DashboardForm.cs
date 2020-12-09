using School_Management_System_Software.Screens.Fees;
using School_Management_System_Software.Screens.Student;
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
using School_Management_System_Software.Screens.Dues;
using School_Management_System_Software.Models.Increment;
using School_Management_System_Software.Screens.Statements;

namespace School_Management_System_Software.Screens
{
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageStudentsToolStripButton_Click(object sender, EventArgs e)
        {
            ManageStudentsForm msf = new ManageStudentsForm();
            msf.ShowDialog();
        }

        private void ManageFeesToolStripButton_Click(object sender, EventArgs e)
        {
            ManageFeesForm mff = new ManageFeesForm();
            mff.ShowDialog();
        }

        private void ManageDuesToolStripButton_Click(object sender, EventArgs e)
        {
            ManageDuesForm mdf = new ManageDuesForm();
            mdf.ShowDialog();
        }

        private void NewStudentToolStripButton_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void IncrementToolStripButton_Click(object sender, EventArgs e)
        {
            ManageIncrementForm mif = new ManageIncrementForm();
            mif.ShowDialog();
        }

        private void StatementsToolStripButton_Click(object sender, EventArgs e)
        {
            StatementsForm stf = new StatementsForm();
            stf.ShowDialog();
        }
    }
}
