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
using SMDBFramework.Windows;
using School_Management_System_Software.Models.Dues;
using SMDBFramework;
using School_Management_System_Software.Utilities;

namespace School_Management_System_Software.Screens.Dues
{
    public partial class ExtraDuesForm : TemplateForm
    {
        public ExtraDuesForm()
        {
            InitializeComponent();
        }

        private void ExtraDuesForm_Load(object sender, EventArgs e)
        {
            LoadExtraDues();
        }

        private void LoadExtraDues()
        {
            ListData.LoadDataIntoDataGridView(ExtraDuesDataGridView, "usp_ExtraDuesGetAllDues");
        }

        private void PaidButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ExtraDuesDataGridView.SelectedRows)
            {
                ExtraDues ed = new ExtraDues();
                ed.GRNumber = Convert.ToInt32(row.Cells["G.R#"].Value);
                ed.Year = row.Cells["Year"].Value.ToString().Trim();
                ed.IsPaid = true;
                DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_Dues_UpdateExtraDues_AS_Paid", ed);

            }
            SMMessageBox.ShowSuccessMessage("Selected Extra Fees are Paid");
            LoadExtraDues();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    bs.DataSource = ExtraDuesDataGridView.DataSource;
                    bs.Filter = "StudentName" + " like '%" + SearchBarTextBox.Text + "%'";
                    ExtraDuesDataGridView.DataSource = bs;
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
                    bs.DataSource = ExtraDuesDataGridView.DataSource;
                    bs.Filter = "[G.R#] " + "=" + SearchBarTextBox.Text + "";
                    ExtraDuesDataGridView.DataSource = bs;
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
                    bs.DataSource = ExtraDuesDataGridView.DataSource;
                    bs.Filter = "FatherName" + " like '%" + SearchBarTextBox.Text + "%'";
                    ExtraDuesDataGridView.DataSource = bs;
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
                    bs.DataSource = ExtraDuesDataGridView.DataSource;
                    bs.Filter = "Year" + " like '%" + SearchBarTextBox.Text + "%'";
                    ExtraDuesDataGridView.DataSource = bs;
                }
            }
            if (SearchBarTextBox.Text == "")
            {
                LoadExtraDues();
            }
        }
    }
}
