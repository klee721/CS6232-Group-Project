using System;
using System.Collections.Generic;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.Controller;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    /// <summary>
    /// Usercontrol for the purpose of adding new program users to the database
    /// </summary>
    public partial class AddUserUserControl : UserControl
    {
        PersonController personController;
        NurseController nurseController;
        LoginController loginController;
        AdminController adminController;
        User storedUser;

        public AddUserUserControl()
        {
            InitializeComponent();
            this.LockCreateUser();
            this.nurseController = new NurseController();
            this.personController = new PersonController();
            this.loginController = new LoginController();
            this.adminController = new AdminController();
        }


        private void OpenCreateUser()
        {
            this.CreateUserButton.Enabled = true;
            this.PasswordTextBox.Enabled = true;
            this.UserNameTextBox.Enabled = true;
            this.ConfirmPassTextbox.Enabled = true;
            this.UserFullNameLabel.Text = this.storedUser.firstName + " " + this.storedUser.lastName;
        }

        private void LockCreateUser()
        {
            this.CreateUserButton.Enabled = false;
            this.PasswordTextBox.Text = "";
            this.PasswordTextBox.Enabled = false;
            this.UserNameTextBox.Text = "";
            this.UserNameTextBox.Enabled = false;
            this.ConfirmPassTextbox.Text = "";
            this.ConfirmPassTextbox.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
          
            int result;
            User newUser = new User();

            if (int.TryParse(this.EmployeeIDTextBox.Text, out result))
            {
                if (this.AdminRadio.Checked)
                {
                    int checkEmployee = this.adminController.GetAdminByID(result);
                    if (checkEmployee != 0)
                    {
                        newUser.adminID = result;
                        this.personController.GetUserFullName(newUser);
                        if (!this.loginController.IsAdminAUser(newUser.adminID))
                        {
                            this.storedUser = newUser;
                            this.OpenCreateUser();
                        }
                        else
                        {
                            MessageBox.Show("Employee " + newUser.firstName + " " + newUser.lastName + " is already a registered user");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No active Administrators found.");
                    }
                }

                if (this.NurseRadio.Checked)
                {
                    int checkEmployee = this.nurseController.GetNurseByID(result);
                    if (checkEmployee != 0)
                    {
                        newUser.nurseID = result;
                        this.personController.GetUserFullName(newUser);
                        if (!this.loginController.IsNurseAUser(newUser.nurseID))
                        {
                            this.storedUser = newUser;
                            this.OpenCreateUser();
                        }
                        else
                        {
                            MessageBox.Show("Employee " + newUser.firstName + " " + newUser.lastName + " is already a registered user");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No active Nurses found.");
                    }
                }


            }
            else
            {
                MessageBox.Show("Please enter a valid Employee ID number");

            }
        }

        public void ClearModule()
        {
            this.storedUser = null;
            this.UserFullNameLabel.Text = "";
            this.LockCreateUser();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            this.UserNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPassLabel.ForeColor = System.Drawing.Color.Black;

            if (this.UserNameTextBox.Text == "" || this.PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }

            if(this.PasswordTextBox.Text != this.ConfirmPassTextbox.Text)
            {
                MessageBox.Show("Password entries must match!");
                this.PasswordLabel.ForeColor = System.Drawing.Color.Red;
                this.ConfirmPassLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (!this.loginController.IsUsernameUnique(this.UserNameTextBox.Text))
            {
                MessageBox.Show("That username is already in use");
                this.UserNameLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (this.loginController.CreateNewUser(storedUser, this.UserNameTextBox.Text, this.PasswordTextBox.Text))
            {
                MessageBox.Show("New user successfully created!");
                this.ClearModule();
            }
            else
            {
                MessageBox.Show("Error! User was not created. Please check your information and contact your system Administrator.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }
    }
}
