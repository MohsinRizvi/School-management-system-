using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using School_Management_System_Software.Utilities;

namespace School_Management_System_Software
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

        }

        public void ShowGRMonthlyFeesVoucher(int GRNNumber, string MonthName, Boolean IsAnnualFees)
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_VoucherReport_GR_Monthly", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@GRNNumber", GRNNumber);
                    cmd.Parameters.AddWithValue("@MonthName", MonthName);
                    cmd.Parameters.AddWithValue("@IsAnnualFees", IsAnnualFees);

                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);

                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\FeeVoucher_GR_Monthly.rpt");
                    rdoc.SetParameterValue("@GRNNumber", GRNNumber);
                    rdoc.SetParameterValue("@MonthName", MonthName);
                    rdoc.SetParameterValue("@IsAnnualFees", IsAnnualFees);
                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
        }

        public void ShowClassWiseFeesVoucherMonthly(int ClassID, string MonthName, Boolean IsAnnualFees)
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_VoucherReportClassWise", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@ClassId", ClassID);
                    cmd.Parameters.AddWithValue("@MonthName", MonthName);
                    cmd.Parameters.AddWithValue("@IsAnnualFees", IsAnnualFees);

                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);


                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\FeeVoucher_Class_Monthly.rpt");
                    rdoc.SetParameterValue("@ClassId", ClassID);
                    rdoc.SetParameterValue("@MonthName", MonthName);
                    rdoc.SetParameterValue("@IsAnnualFees", IsAnnualFees);
                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
           
        }

        public void ShowAllClassesFeesVoucherMonthly(string MonthName, Boolean IsAnnualFees)
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_VoucherReportAllClasses", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@MonthName", MonthName);
                    cmd.Parameters.AddWithValue("@IsAnnualFees", IsAnnualFees);

                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);


                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\FeeVoucher_AllClasses_Monthly.rpt");
                    rdoc.SetParameterValue("@MonthName", MonthName);
                    rdoc.SetParameterValue("@IsAnnualFees", IsAnnualFees);
                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
        }

        public void ShowDailyEarningsStatement()
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Report_DailyEarnings", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);

                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\DailyEarnings.rpt");
                    
                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
        }

        public void ShowDuesStatement()
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Report_TotalDues", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);

                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\Dues.rpt");

                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
        }

        public void ShowAllStudentsStatement()
        {
            CrystalReptViewer.Refresh();
            DataTable dtData = new DataTable();
            using (SqlConnection con = new SqlConnection(AppSetting.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Report_TotalStudents", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();

                    SqlDataReader DataReader = cmd.ExecuteReader();
                    dtData.Load(DataReader);

                    ReportDocument rdoc = new ReportDocument();

                    rdoc.Load(@"Reports\TotalStudents.rpt");

                    CrystalReptViewer.ReportSource = rdoc;
                }
            }
        }

        private void CrystalReptViewer_Load(object sender, EventArgs e)
        {
            CrystalReptViewer.Refresh();
            CrystalReptViewer.ReportSource = null;
            CrystalReptViewer.Refresh();
            CrystalReptViewer.RefreshReport();
        }
    }
}
