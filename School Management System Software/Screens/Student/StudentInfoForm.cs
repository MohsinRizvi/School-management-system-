using School_Management_System_Software.Models.Students;
using School_Management_System_Software.Models.Users;
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
using System.Globalization;

namespace School_Management_System_Software.Screens.Student
{
    public partial class StudentInfoForm : TemplateForm
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        public int StudentId { get; set; }

        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = StudentNameTextBox.Text;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Logo";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LogoPictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {

            if (this.IsUpdate == false)
            {
                int max = LoadMaxStudentId();
                StudentIdTextBox.Text = max.ToString().Trim();
            }

            LoadDataIntoComboBox();
            LoadDataAndBindToControlIfUpdate();
        }

        private Int32 LoadMaxStudentId()
        {
            DataTable dt = new DataTable();
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            dt = db.Getdata("usp_StudtdentsGetMaxStudentId");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["StudentId"]);
            }
            else
            {
                return 0;
            }
        }

        private void LoadDataIntoComboBox()
        {
            ListData.LoadDataIntoComboBox(ClassComboBox, new DBParameter { Parameter = "@ListTypeId", Value = ListTypes.Class });
            ListData.LoadDataIntoComboBox(GenderComboBox, new DBParameter { Parameter = "@ListTypeId", Value = ListTypes.Gender });
            ListData.LoadDataIntoComboBox(ExtraFeesNameComboBox, new DBParameter { Parameter = "@ListTypeId", Value = ListTypes.ExtraFees });
        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            {
                DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
                DBParameter para = new DBParameter();
                para.Parameter = "@StudentId";
                para.Value = this.StudentId;
                DataTable dt = db.GetDataList("usp_StudentsGetStudentsDetailsByStudentId", para);

                DataRow row = dt.Rows[0];

                StudentIdTextBox.Text = row["G.R#"].ToString().Trim();
                StudentNameTextBox.Text = row["StudentName"].ToString().Trim();
                FatherNameTextBox.Text = row["FatherName"].ToString().Trim();
                ClassComboBox.SelectedValue = Convert.ToInt32(row["ClassId"]);
                AddressTextBox.Text = row["Address"].ToString().Trim();
                TelephoneTextBox.Text = row["Telephone"].ToString().Trim();
                LogoPictureBox.Image = (row["StudentImage"] is DBNull)? null :ImageManipulations.GetImage((byte[])row["StudentImage"]);
                CNICTextBox.Text = row["CNIC"].ToString().Trim();
                OccupationTextBox.Text = row["Occupation"].ToString().Trim();
                ReligionTextBox.Text = row["Religion"].ToString().Trim();
                GenderComboBox.SelectedValue = Convert.ToInt32(row["GenderId"]);
                MotherNameTextBox.Text = row["MotherName"].ToString().Trim();
                LastSchoolTextBox.Text = row["LastSchool"].ToString().Trim();
                LastClassStudiedTextBox.Text = row["LastClass"].ToString().Trim();
                DOB.Text = row["DOB"].ToString().Trim();
                PlaceOfBirthTextBox.Text = row["PlaceOfBirth"].ToString().Trim();
                MonthlyFeesTextBox.Text = row["FeesAmount"].ToString().Trim();
                AnnualFeesTextBox.Text = row["AnnualFeesAmount"].ToString().Trim();
                //DateTime d = DateTime.ParseExact(row["Year"].ToString(), "yyyy", new CultureInfo("en-US"));
                //AnnualFeesYearPicker.Text = d.ToString().Trim();
                
                if (Convert.ToBoolean(row["IsExtraFees"]) == true)
                {
                    IsExtraFees.Checked = true;
                    ExtraFeesNameComboBox.SelectedValue = Convert.ToInt32(row["ExtraFeesName"]);
                    ExtraFeesAmountTextBox.Text = row["ExtraFeesAmount"].ToString().Trim();
                }
            }
        }

        private void saveRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValidate())
            {
                if (this.IsUpdate)
                {
                    UpdateRecord();
                    SMMessageBox.ShowSuccessMessage("Record has been updated successfully");
                }
                else
                {
                    SaveRecord();
                    SMMessageBox.ShowSuccessMessage("Record has been added successfully");
                }
            }

        }

        private bool IsFormValidate()
        {
            if (StudentNameTextBox.Text.Trim() == string.Empty)
            {   
                SMMessageBox.ShowErrorMessage("Student Name is required");
                StudentNameTextBox.Focus();
                return false;
            }

            if (FatherNameTextBox.Text.Trim() == string.Empty)
            {   
                SMMessageBox.ShowErrorMessage("Father Name is required");
                FatherNameTextBox.Focus();
                return false;
            }

            if (ClassComboBox.Text.Trim() == string.Empty)
            {  
                SMMessageBox.ShowErrorMessage("Class is required");
                ClassComboBox.Focus();
                return false;
            }

            if (AddressTextBox.Text.Trim() == string.Empty)
            {   
                SMMessageBox.ShowErrorMessage("Address is required");
                AddressTextBox.Focus();
                return false;
            }

            if (TelephoneTextBox.Text.Trim() == string.Empty)
            {   
                SMMessageBox.ShowErrorMessage("Telephone is required");
                TelephoneTextBox.Focus();
                return false;
            }

            if (GenderComboBox.Text.Trim() == string.Empty)
            {
                SMMessageBox.ShowErrorMessage("Gender is required");
                GenderComboBox.Focus();
                return false;
            }

            if (MonthlyFeesTextBox.Text.Trim() == string.Empty)
            {   
                SMMessageBox.ShowErrorMessage("Fees is required");
                MonthlyFeesTextBox.Focus();
                return false;
            }
            return true;
        }

        private void UpdateRecord()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_StudentsUpdateStudentDetails", GetObject());
        }

        private Students GetObject()
        {
            Students st = new Students();
            st.StudentId = (this.IsUpdate) ? this.StudentId : 0;
            st.StudentName = StudentNameTextBox.Text.Trim();
            st.FatherName = FatherNameTextBox.Text.Trim();
            st.ClassId = Convert.ToInt32(ClassComboBox.SelectedValue);
            st.StudentImage = (LogoPictureBox.Image == null)? null: ImageManipulations.SaveImage(LogoPictureBox);
            st.Address = AddressTextBox.Text.Trim();
            st.Telephone = TelephoneTextBox.Text.Trim();
            st.CreatedBy = LoggedInUsers.UserName;
            st.Cnic = CNICTextBox.Text.Trim();
            st.Occupation = OccupationTextBox.Text.Trim();
            st.Religion = ReligionTextBox.Text.Trim();
            st.GenderId = Convert.ToInt32(GenderComboBox.SelectedValue);
            st.MotherName = MotherNameTextBox.Text.Trim();
            st.LastSchool = LastSchoolTextBox.Text.Trim();
            st.LastClass = LastClassStudiedTextBox.Text.Trim();
            st.DOB = DOB.Text.Trim();
            st.PlaceOfBirth = PlaceOfBirthTextBox.Text.Trim();
            st.Fees = Convert.ToInt32(MonthlyFeesTextBox.Text.Trim());
            st.AnnualFees = Convert.ToInt32(AnnualFeesTextBox.Text.Trim());
            if(IsExtraFees.Checked == true)
            {
                st.IsExtraFees = Convert.ToBoolean(1);
                st.ExtraFeesName = Convert.ToInt32(ExtraFeesNameComboBox.SelectedValue);
                st.ExtraFeesAmount = Convert.ToInt32(ExtraFeesAmountTextBox.Text.Trim());
            }
            else
            {
                st.IsExtraFees = Convert.ToBoolean(0);
                st.ExtraFeesName = 0;
                st.ExtraFeesAmount = 0;
            }
            return st;
        }

        private void SaveRecord()
        {
            DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_StudentsAddNewStudent", GetObject());
        }

        private void IsExtraFees_CheckedChanged(object sender, EventArgs e)
        {
            if(IsExtraFees.Checked == true)
            {
                ExtraFeesNameLabel.Visible = true;
                ExtraFeesNameComboBox.Visible = true;
                ExtraFeesAmountLabel.Visible = true;
                ExtraFeesAmountTextBox.Visible = true;
            }
            else
            {
                ExtraFeesNameLabel.Visible = false;
                ExtraFeesNameComboBox.Visible = false;
                ExtraFeesAmountLabel.Visible = false;
                ExtraFeesAmountTextBox.Visible = false;
            }
        }
    }
}
