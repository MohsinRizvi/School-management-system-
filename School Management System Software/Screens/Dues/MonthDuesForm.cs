using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities.Lists;
using SMDBFramework;
using School_Management_System_Software.Utilities;
using School_Management_System_Software.Models.Dues;
using SMDBFramework.Windows;

namespace School_Management_System_Software.Screens.Dues
{
    public partial class MonthDuesForm : TemplateForm
    {
        public MonthDuesForm()
        {
            InitializeComponent();
        }

        private void ManageDuesForm_Load(object sender, EventArgs e)
        {
            LoadDuesDataInGridView();
        }

        private void LoadDuesDataInGridView()
        {
            ListData.LoadDataIntoDataGridView(DuesDataGridView, "usp_DuesGetAllDues");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaidButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DuesDataGridView.SelectedRows)
            {
                DuesPaid dp = new DuesPaid();
                dp.GRNumber = Convert.ToInt32(row.Cells["G.R#"].Value);
                dp.MonthName = row.Cells["MonthName"].Value.ToString().Trim();
                dp.Year = row.Cells["Year"].Value.ToString().Trim();
                dp.IsPaid = true;
                DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_Dues_UpdateSelectedDues_AS_Paid", dp);
                
            }
            SMMessageBox.ShowSuccessMessage("Selected Monthly Fees are Paid");
            LoadDuesDataInGridView();
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
                    bs.DataSource = DuesDataGridView.DataSource;
                    bs.Filter = "StudentName" + " like '%" + SearchBarTextBox.Text + "%'";
                    DuesDataGridView.DataSource = bs;
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
                    bs.DataSource = DuesDataGridView.DataSource;
                    bs.Filter = "[G.R#] " + "=" + SearchBarTextBox.Text + "";
                    DuesDataGridView.DataSource = bs;
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
                    bs.DataSource = DuesDataGridView.DataSource;
                    bs.Filter = "FatherName" + " like '%" + SearchBarTextBox.Text + "%'";
                    DuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarComboBox.SelectedIndex == 3)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^[a-zA-Z ]+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Alphabets are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = DuesDataGridView.DataSource;
                    bs.Filter = "MonthName" + " like '%" + SearchBarTextBox.Text + "%'";
                    DuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarComboBox.SelectedIndex == 4)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^\d+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Numbers are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = DuesDataGridView.DataSource;
                    bs.Filter = "Year" + " like '%" + SearchBarTextBox.Text + "%'";
                    DuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarTextBox.Text == "")
            {
                LoadDuesDataInGridView();
            }
        }
    }
}
