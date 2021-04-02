using System;
using System.Collections.Generic;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.Controller;
using Group3_ClinicDB.View;
using System.Windows.Forms;

namespace Group3_ClinicDB
{
    public partial class LoginForm : Form
    {
        List<User> userList;
        LoginController loginController;
        NurseMainDashboard nurseMainDashboard;

        public LoginForm()
        {
            this.loginController = new LoginController();
            this.userList = new List<User>();
            this.userList = loginController.GetAllUsers();

         

            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string enteredUser = this.UsernameTextBox.Text;
            string enteredPass = this.PasswordTextbox.Text;
            if (this.userList.Exists(user => user.userName == enteredUser && user.password == enteredPass))
            {
                User newUser = this.userList.Find(user => user.userName == enteredUser);
                if (this.nurseMainDashboard == null)
                {
                    this.nurseMainDashboard = new NurseMainDashboard(newUser, this);
                    nurseMainDashboard.Show();
                    this.Hide();
                }
                else
                {
                    this.nurseMainDashboard.ChangeUser(newUser);
                    this.nurseMainDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Login Failed");
            }
            
        }
    }
}
