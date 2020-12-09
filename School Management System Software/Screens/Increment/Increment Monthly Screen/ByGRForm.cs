using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Screens.Student;
using SMDBFramework;
using School_Management_System_Software.Utilities;
using School_Management_System_Software.Models.Increment;
using SMDBFramework.Windows;

namespace School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen
{
    public partial class ByGRForm : TemplateForm
    {
        public ByGRForm()
        {
            InitializeComponent();
        }

        private void IncreaseAmountButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(AmountTextBox.Text, @"^\d+$"))
                {
                    SMMessageBox.ShowErrorMessage("Only Numbers are allowed");
                    AmountTextBox.Text = string.Empty;
                }
                else
                {
                    AddIncrement();
                }
            }
        }
        public int StudentId { get; set; }
        private void AddIncrement()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_Increment_MonthlyByGR", Getobj());
            SMMessageBox.ShowSuccessMessage("Increment Applied Successful");
            this.Close();
        }

        private MonthlyIncrement Getobj()
        {
            MonthlyIncrement mi = new MonthlyIncrement();
            mi.GRNumber = Convert.ToInt32(GRTextBox.Text.Trim());
            mi.Amount = Convert.ToInt32(AmountTextBox.Text.Trim());
            return mi;
        }

        private void GRButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllStudentsForm ast = new AllStudentsForm();
            ast.ShowDialog();


        }

        private void ByGRForm_Load(object sender, EventArgs e)
        {
            if (IsSearched == true)
            {
                GRTextBox.Text = StudentId.ToString().Trim();
            }
        }

        private bool IsFormValidate()
        {
            if (GRTextBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("GR Number is required");
                GRTextBox.Focus();
                return false;
            }
            if (AmountTextBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("Amount is required");
                AmountTextBox.Focus();
                return false;
            }
            return true;
        }

    }
}
