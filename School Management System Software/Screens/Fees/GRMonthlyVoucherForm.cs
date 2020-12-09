using System;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using School_Management_System_Software.Models.Fees;
using School_Management_System_Software.Screens.Student;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities;
using SMDBFramework;
using SMDBFramework.Windows;


namespace School_Management_System_Software.Screens.Fees
{
    public partial class GRMonthlyVoucherForm : TemplateForm
    {
        public GRMonthlyVoucherForm()
        {
            InitializeComponent();
        }
        public int StudentId { get; set; }
        FeesVouchersEntity fve = new FeesVouchersEntity();
        private void GRButton_Click(object sender, EventArgs e)
        {
            AllStudentsForm ast = new AllStudentsForm();
            ast.ShowDialog();
            this.Hide();
        }

        private void GRVoucherForm_Load(object sender, EventArgs e)
        {
            if (IsSearched == true)
            {
                GRTextBox.Text = StudentId.ToString().Trim();
            }
        }

        private void GenerateVoucherButton_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                fve.GRNNumber = Convert.ToInt32(GRTextBox.Text.Trim());
                fve.MonthName = MonthPicker.Text;
                SaveMonthlyFeesDetails();

                SMMessageBox.ShowSuccessMessage("Fees Voucher Generated Successfully");
                ReportForm rpf = new ReportForm();
                rpf.Show();
                if (IsAnnualFeesCheckBox.Checked)
                {
                    fve.IsAnnualFees = true;
                }
                else
                {
                    fve.IsAnnualFees = false;
                }
                rpf.ShowGRMonthlyFeesVoucher(fve.GRNNumber, fve.MonthName, fve.IsAnnualFees);
                this.Close();
            }
        }




        private void SaveMonthlyFeesDetails()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_FeesSaveGenerated_GR_MonthlyVoucher", GetVoucherObject());
        }

        private object GetVoucherObject()
        {
            StudentMonthlyFees stf = new StudentMonthlyFees();
            stf.StudentId = Convert.ToInt32(GRTextBox.Text);
            stf.ClassId = ClassId;
            stf.MonthName = MonthPicker.Text;
            stf.IsPaid = false;

            return stf;
        }

        private bool IsFormValidate()
        {
            if (GRTextBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("GR Number is required");
                GRTextBox.Focus();
                return false;
            }

            return true;
        }
    }
}
