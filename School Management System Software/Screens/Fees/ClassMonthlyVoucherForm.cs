using School_Management_System_Software.Models.Fees;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities;
using School_Management_System_Software.Utilities.Lists;
using SMDBFramework;
using SMDBFramework.Windows;
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
    public partial class ClassMonthlyVoucherForm : TemplateForm
    {
        public ClassMonthlyVoucherForm()
        {
            InitializeComponent();
        }

        private void ClassMonthlyVoucherForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }
        public int ClassID
        {
            get;
            set;
        }
        public string MonthName
        {
            get;
            set;
        }
        public Boolean IsAnnualFees { get; set; }
        private void LoadDataIntoComboBox()
        {
            ListData.LoadDataIntoComboBox(ClassesComboBox, new DBParameter { Parameter = "@ListTypeId", Value = ListTypes.Class });
        }

        private void GenerateVoucherButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                ClassID = Convert.ToInt32(ClassesComboBox.SelectedValue);
                MonthName = MonthPicker.Text;
                SaveMonthlyFeesDetails();
                SMMessageBox.ShowSuccessMessage("Fees Voucher Generated Successfully");
                ReportForm rpf = new ReportForm();
                rpf.Show();
                if (IsAnnualFeesCheckBox.Checked)
                {
                    //rpf.ShowClassWiseFeesVoucherMonthlyWithAnnualFees(ClassID, MonthName);
                    IsAnnualFees = true;
                }
                else
                {
                    IsAnnualFees = false;
                }
                rpf.ShowClassWiseFeesVoucherMonthly(ClassID, MonthName, IsAnnualFees);
                this.Close();
            }
        }

        private void SaveMonthlyFeesDetails()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_FeesSaveGenerated_Month_MonthlyVoucher", GetVoucherObject());
        }

        private object GetVoucherObject()
        {
            ClassMonthlyFees cmf = new ClassMonthlyFees();
            cmf.ClassId = Convert.ToInt32(ClassesComboBox.SelectedValue);
            cmf.MonthName = MonthPicker.Text;
            cmf.IsPaid = false;

            return cmf;
        }

        private bool IsFormValidate()
        {
            if (ClassesComboBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("Class is required");
                ClassesComboBox.Focus();
                return false;
            }
            return true;
        }
    }
}
