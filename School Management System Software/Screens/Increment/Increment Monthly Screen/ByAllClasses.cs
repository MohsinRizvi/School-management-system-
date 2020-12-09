using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using School_Management_System_Software.Screens.Templates;
using SMDBFramework;
using SMDBFramework.Windows;
using School_Management_System_Software.Utilities;
using School_Management_System_Software.Models.Increment;

namespace School_Management_System_Software.Screens.Increment.Increment_Monthly_Screen
{
    public partial class AnnualByAllClasses : TemplateForm
    {
        public AnnualByAllClasses()
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

        private void AddIncrement()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_Increment_MonthlyByAllClass", Getobj());
            SMMessageBox.ShowSuccessMessage("Increment Applied Successful");
            this.Close();
        }

        private MonthlyIncrementByAllClass Getobj()
        {
            MonthlyIncrementByAllClass miac = new MonthlyIncrementByAllClass();
            miac.Amount = Convert.ToInt32(AmountTextBox.Text.Trim());

            return miac;
        }

        private bool IsFormValidate()
        {
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
