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
        PersonController personController;
        NurseMainDashboard nurseMainDashboard;

        public LoginForm()
        {
            this.loginController = new LoginController();
            this.personController = new PersonController();
            this.userList = new List<User>();
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string enteredUser = this.UsernameTextBox.Text;
            string enteredPass = this.PasswordTextbox.Text;
            this.userList = this.loginController.GetUserByNameAndPassword(enteredUser, enteredPass);
            if (this.userList.Count == 1)
            {
                User newUser = this.userList[0];
                newUser = this.personController.GetUserFullName(newUser);
                Console.WriteLine(newUser.firstName + newUser.lastName);
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
            }else if (this.userList.Count > 1){
                MessageBox.Show("Duplicate users found. Please contact your system adminstrator ", "Login Failed");
            }else{
                MessageBox.Show("Username or Password is incorrect", "Login Failed");
            }


            
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
