using School_Management_System_Software.Screens.Fees;
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
using School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen;
using School_Management_System_Software.Screens.Increment.Increment_Annually_Screen;
using School_Management_System_Software.Screens.Increment.Increment_ExtraFees_Screen;
using SMDBFramework.Windows;

namespace School_Management_System_Software.Screens.Student
{
    public partial class AllStudentsForm : TemplateForm
    {
        public AllStudentsForm()
        {
            InitializeComponent();
        }
       
        private void AllStudentsForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            if (CheckOpened("Annual By GR Screen"))
            {
                ListData.LoadDataIntoDataGridView(StudentsDataGridView, "usp_StudentsGetAnnualFeesStudents");
            }
            else if (CheckOpened("ExtraFees By GR Screen"))
            {
                ListData.LoadDataIntoDataGridView(StudentsDataGridView, "usp_StudentsGetExtraFeesStudents");
            }
            else
            {
                ListData.LoadDataIntoDataGridView(StudentsDataGridView, "usp_StudentsGetAllStudents");
            }
        }

        //public bool IsFormOpen(Type formType)
        //{
        //    foreach (Form form in Application.OpenForms)
        //        if (form.GetType().Name == form.Name)
        //            return true;
        //    return false;
        //}

        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void StudentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
            int rowIndex = StudentsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32(StudentsDataGridView.Rows[rowIndex].Cells["G.R#"].Value);
            int ClassId = Convert.ToInt32(StudentsDataGridView.Rows[rowIndex].Cells["ClassId"].Value);
           
            if (CheckOpened("G.R# Voucher Form"))
            {
                ShowGRVoucherScreen(studentId, ClassId, true);
            }
            if (CheckOpened("By GR Screen"))
            {
                ShowIncrementMonthlyByGRScreen(studentId, ClassId, true);
            }
            if (CheckOpened("Annual By GR Screen"))
            {
                ShowIncrementAnnuallyByGRScreen(studentId, ClassId, true);
            }
            if (CheckOpened("ExtraFees By GR Screen"))
            {
                ShowIncrementExtraFeesByGRScreen(studentId, ClassId, true);
            }
        }

        private void ShowIncrementExtraFeesByGRScreen(int studentId, int ClassId, bool IsSearched)
        {
            this.Hide();
            ExtraFeesByGRForm ebgrfm = new ExtraFeesByGRForm();
            ebgrfm.StudentId = studentId;
            ebgrfm.IsSearched = IsSearched;
            ebgrfm.ClassId = ClassId;
            ebgrfm.ShowDialog();
        }

        private void ShowIncrementAnnuallyByGRScreen(int studentId, int ClassId, bool IsSearched)
        {
            this.Hide();
            AnnualByGRForm abgrfm = new AnnualByGRForm();
            abgrfm.StudentId = studentId;
            abgrfm.IsSearched = IsSearched;
            abgrfm.ClassId = ClassId;
            abgrfm.ShowDialog();
        }

        private void ShowIncrementMonthlyByGRScreen(int studentId, int ClassId, bool IsSearched)
        {
            this.Hide();
            ByGRForm bgrfm = new ByGRForm();
            bgrfm.StudentId = studentId;
            bgrfm.IsSearched = IsSearched;
            bgrfm.ClassId = ClassId;
            bgrfm.ShowDialog();
        }

        private void ShowGRVoucherScreen(int studentId,int ClassId, bool IsSearched)
        {
            this.Hide();
            GRMonthlyVoucherForm grfrm = new GRMonthlyVoucherForm();
            grfrm.StudentId = studentId;
            grfrm.IsSearched = IsSearched;
            grfrm.ClassId = ClassId;
            grfrm.ShowDialog();
            
        }


        private void SearchBarTextBox_TextChanged_1(object sender, EventArgs e)
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
