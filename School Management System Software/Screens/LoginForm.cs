using School_Management_System_Software.Models.Users;
using School_Management_System_Software.Screens.Templates;
using School_Management_System_Software.Utilities;
using SMDBFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System_Software.Screens
{
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DBSQLServer db = new DBSQLServer(AppSetting.ConnectionString());
                bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UserSP",GetParameters()));
                if (isLoginDetailsCorrect)
                {
                    GetLoggedInUsers();
                    this.Hide();

                    DashboardForm DashboardObj = new DashboardForm();
                    DashboardObj.Show();
                }
                else
                {
                    MessageBox.Show("User Name/Password is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetLoggedInUsers()
        {
            LoggedInUsers.UserName = UserNameTextBox.Text.Trim();
        }

        private DBParameter[] GetParameters()
        {
            List<DBParameter> parameters = new List<DBParameter>();

            DBParameter dbParam1 = new DBParameter();
            dbParam1.Parameter = "@UserName";
            dbParam1.Value = UserNameTextBox.Text.Trim();
            parameters.Add(dbParam1);

            DBParameter dbParam2 = new DBParameter();
            dbParam2.Parameter = "@Password";
            dbParam2.Value = PasswordTextBox.Text.Trim();
            parameters.Add(dbParam2);
            
            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
