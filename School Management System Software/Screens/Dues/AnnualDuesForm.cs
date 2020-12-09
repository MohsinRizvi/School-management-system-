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
using SMDBFramework.Windows;
using School_Management_System_Software.Utilities;
using School_Management_System_Software.Models.Dues;

namespace School_Management_System_Software.Screens.Dues
{
    public partial class AnnualDuesForm : TemplateForm
    {
        public AnnualDuesForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnnualDuesForm_Load(object sender, EventArgs e)
        {
            LoadAnnualDuesData();
        }

        private void LoadAnnualDuesData()
        {
            ListData.LoadDataIntoDataGridView(AnnualDuesDataGridView, "usp_AnnualDuesGetAllDues");
        }

        private void PaidButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AnnualDuesDataGridView.SelectedRows)
            {
                AnnualDues ad = new AnnualDues();
                ad.GRNumber = Convert.ToInt32(row.Cells["G.R#"].Value);
                ad.Year = row.Cells["Year"].Value.ToString().Trim();
                ad.IsPaid = true;
                DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_Dues_UpdateAnnualDues_AS_Paid", ad);
                
            }
            SMMessageBox.ShowSuccessMessage("Selected Annual Fees are Paid");
            LoadAnnualDuesData();
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
                    bs.DataSource = AnnualDuesDataGridView.DataSource;
                    bs.Filter = "StudentName" + " like '%" + SearchBarTextBox.Text + "%'";
                    AnnualDuesDataGridView.DataSource = bs;
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
                    bs.DataSource = AnnualDuesDataGridView.DataSource;
                    bs.Filter = "[G.R#] " + "=" + SearchBarTextBox.Text + "";
                    AnnualDuesDataGridView.DataSource = bs;
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
                    bs.DataSource = AnnualDuesDataGridView.DataSource;
                    bs.Filter = "FatherName" + " like '%" + SearchBarTextBox.Text + "%'";
                    AnnualDuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarComboBox.SelectedIndex == 3)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(SearchBarTextBox.Text, @"^\d+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Numbers are allowed");
                    SearchBarTextBox.Text = string.Empty;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = AnnualDuesDataGridView.DataSource;
                    bs.Filter = "Year" + " like '%" + SearchBarTextBox.Text + "%'";
                    AnnualDuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarTextBox.Text == "")
            {
                LoadAnnualDuesData();
            }
        }
    }
}
