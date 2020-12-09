using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMDBFramework.Windows;

namespace School_Management_System_Software.Screens.Student
{
    public partial class ManageStudentsForm : TemplateForm
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentInfoScreen(0, false);
        }

        private void ShowStudentInfoScreen(int StudentId, bool isUpdate)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.StudentId = StudentId;
            sif.IsUpdate = isUpdate;
            sif.ShowDialog();
            LoadDataIntoDataGridView();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(StudentsDataGridView, "usp_StudentsGetAllStudents");
        }

        private void StudentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = StudentsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32(StudentsDataGridView.Rows[rowIndex].Cells["G.R#"].Value);
            ShowStudentInfoScreen(studentId, true);
        }

        private void SearchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBarComboBox.SelectedIndex == 1)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^[a-zA-Z ]+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Alphabets are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = StudentsDataGridView.DataSource;
                    bs.Filter = "StudentName" + " like '%" + SearchBarTextBox.Text + "%'";
                    StudentsDataGridView.DataSource = bs;
                }
            }
            if (SearchBarComboBox.SelectedIndex == 0 && SearchBarTextBox.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^\d+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Numbers are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = StudentsDataGridView.DataSource;
                    bs.Filter = "[G.R#] " + "=" + SearchBarTextBox.Text + "";
                    StudentsDataGridView.DataSource = bs;
                }
            }
            if (SearchBarComboBox.SelectedIndex == 2)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^[a-zA-Z ]+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Alphabets are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = StudentsDataGridView.DataSource;
                    bs.Filter = "FatherName" + " like '%" + SearchBarTextBox.Text + "%'";
                    StudentsDataGridView.DataSource = bs;
                }
            }
            if (SearchBarTextBox.Text == "")
            {
                LoadDataIntoDataGridView();
            }
        }
    }
}
