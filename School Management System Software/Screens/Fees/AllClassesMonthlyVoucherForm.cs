using School_Management_System_Software.Models.Fees;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities;
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
    public partial class AllClassesMonthlyVoucherForm : TemplateForm
    {
        public AllClassesMonthlyVoucherForm()
        {
            InitializeComponent();
        }
        public string MonthName
        {
            get;
            set;
        }
        public Boolean IsAnnualFees { get; set; }
        private void GenerateVoucherButton_Click(object sender, EventArgs e)
        {
            MonthName = MonthPicker.Text;
            SaveMonthlyFeesDetails();
            SMMessageBox.ShowSuccessMessage("Fees Voucher Generated Successfully");
            ReportForm rpf = new ReportForm();
            rpf.Show();
            if (IsAnnualFeesCheckBox.Checked)
            {
                IsAnnualFees = true;
                //rpf.ShowAllClassesFeesVoucherMonthlyWithAnnualFees(MonthName);
            }
            else
            {
                IsAnnualFees = false;
            }
            rpf.ShowAllClassesFeesVoucherMonthly(MonthName, IsAnnualFees);
            this.Close();
        }

        private void SaveMonthlyFeesDetails()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_FeesSaveGenerated_MonthAllClasses_MonthlyVoucher", GetVoucherObject());
        }

        private object GetVoucherObject()
        {
            AllClassesMonthlyFees acmf = new AllClassesMonthlyFees();
            acmf.MonthName = MonthPicker.Text;
            acmf.IsPaid = false;

            return acmf;
        }
    }
}
