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
using School_Management_System_Software.Models.Increment;
using SMDBFramework.Windows;

namespace School_Management_System_Software.Screens.Increment.Increment_ExtraFees_Screen
{
    public partial class ExtraFeesByClassForm : TemplateForm
    {
        public ExtraFeesByClassForm()
        {
            InitializeComponent();
        }

        private void ExtraFeesByClassForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void LoadDataIntoComboBox()
        {
            ListData.LoadDataIntoComboBox(ClassesComboBox, new DBParameter { Parameter = "@ListTypeId", Value = ListTypes.Class });
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

        private void AddIncrement()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_Increment_ExtraFeesByClass", Getobj());
            SMMessageBox.ShowSuccessMessage("Increment Applied Successful");
            this.Close();
        }

        private MonthlyIncrementByClass Getobj()
        {
            MonthlyIncrementByClass mbc = new MonthlyIncrementByClass();
            mbc.ClassId = Convert.ToInt32(ClassesComboBox.SelectedValue);
            mbc.Amount = Convert.ToInt32(AmountTextBox.Text.Trim());
            return mbc;
        }

        private bool IsFormValidate()
        {
            if (ClassesComboBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("Class is required");
                ClassesComboBox.Focus();
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
