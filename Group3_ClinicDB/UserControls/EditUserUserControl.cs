using System;
using System.Collections.Generic;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.Controller;
using System.Windows.Forms;

namespace Group3_ClinicDB.UserControls
{
    public partial class EditUserUserControl : UserControl
    {
        PersonController personController;
        NurseController nurseController;
        LoginController loginController;
        Nurse storedNurse;
        string storedUserName;

        public EditUserUserControl()
        {
            
            this.nurseController = new NurseController();
            this.personController = new PersonController();
            this.loginController = new LoginController();
            InitializeComponent();
            this.LockEditUser();
        }


        private void LockEditUser()
        {
            this.EditUserButton.Enabled = false;
            this.PasswordTextBox.Text = "";
            this.PasswordTextBox.Enabled = false;
            this.UserNameTextBox.Text = "";
            this.UserNameTextBox.Enabled = false;
            this.ConfirmPassTextbox.Text = "";
            this.ConfirmPassTextbox.Enabled = false;
            this.ActiveRadio.Enabled = false;
            this.DeactivateRadio.Enabled = false;
            this.SetStatusButton.Enabled = false;
        }

        private void OpenEditUser()
        {
            this.EditUserButton.Enabled = true;
            this.PasswordTextBox.Enabled = true;
            this.UserNameTextBox.Enabled = true;
            this.ConfirmPassTextbox.Enabled = true;
            this.ActiveRadio.Enabled = true;
            this.DeactivateRadio.Enabled = true;
            this.SetStatusButton.Enabled = true;
            this.UserFullNameLabel.Text = this.storedNurse.FirstName + " " + this.storedNurse.LastName;
        }

        private void FillOutNurseData()
        {
            if (storedNurse.Status == "A")
            {
                this.ActiveRadio.Checked = true;
            }
            else
            {
                this.DeactivateRadio.Checked = true;
            }

            this.UserNameTextBox.Text = this.storedUserName;


        }


        public void ClearModule()
        {
            this.storedNurse = null;
            this.UserFullNameLabel.Text = "";
            this.NurseIDTextBox.Text = "";
            this.LockEditUser();
        }

        private void SearchNurseButton_Click(object sender, EventArgs e)
        {

            if (NurseIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter a Nurse ID number.");
                return;
            }

            this.PasswordTextBox.Text = "";
            this.ConfirmPassTextbox.Text = "";

            int result;
            Nurse newNurse = new Nurse();

            if (Int32.TryParse(NurseIDTextBox.Text, out result))
            {
                int checkEmployee = this.nurseController.GetNurseByID(result);
                if (checkEmployee != 0)
                {
                    newNurse.NurseID = result;
                    this.personController.GetNurseFullName(newNurse);
                    this.nurseController.GetNurseStatus(newNurse);
                    if (this.loginController.IsNurseAUser(newNurse.NurseID))
                    {
                        this.storedNurse = newNurse;
                        this.storedUserName = this.loginController.GetUsernameByNurseID(this.storedNurse.NurseID);
                        this.OpenEditUser();
                        this.FillOutNurseData();
                        
                    }
                    else
                    {
                        MessageBox.Show("Nurse " + newNurse.FirstName + " " + newNurse.LastName + " is not a registered user.");
                    }
                }
                else
                {
                    MessageBox.Show("No Nurses found.");
                }




                }
            else
            {
                MessageBox.Show("Please enter a valid Nurse ID number.");
            }
          

        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            if (PasswordTextBox.Text != ConfirmPassTextbox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (this.storedUserName!= UserNameTextBox.Text)  
            {
                if (!this.loginController.IsUsernameUnique(UserNameTextBox.Text)) 
                {
                    MessageBox.Show("That username is unavailable.");
                    return;
                }
            }

            User updatedUser = new User();
            updatedUser.userName = UserNameTextBox.Text;
            updatedUser.nurseID = this.storedNurse.NurseID;
            if (this.loginController.UpdateUser(updatedUser, this.PasswordTextBox.Text))
            {
                MessageBox.Show("Nurse successfully update");
                this.PasswordTextBox.Text = "";
                this.ConfirmPassTextbox.Text = "";
            }
        }


        private void SetStatusButton_Click(object sender, EventArgs e)
        {
            if (this.DeactivateRadio.Checked == true)
            {
                if (this.storedNurse.Status != "I")
                {
                    DialogResult dialogresult = MessageBox.Show("You are deactivating Nurse " + this.storedNurse.LastName + ". Would you like to proceed?", "Deactivating Nurse", MessageBoxButtons.OKCancel);

                    if (dialogresult == DialogResult.OK)
                    {
                        if(this.nurseController.UpdateNurseStatus(storedNurse, "I"))
                        {
                            MessageBox.Show("Nurse status successfully updated");
                            this.storedNurse.Status = "I";
                        }

                       

                       
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The Nurse is already inactive.");
                }

            }
            else if (this.ActiveRadio.Checked == true)
            {

                if (this.storedNurse.Status != "A")
                {
                    DialogResult dialogresult = MessageBox.Show("You are activating Nurse " + this.storedNurse.LastName + ". Would you like to proceed?", "Activating Nurse", MessageBoxButtons.OKCancel);

                    if (dialogresult == DialogResult.OK)
                    {
                        if(this.nurseController.UpdateNurseStatus(storedNurse, "A"))
                        {
                            MessageBox.Show("Nurse status successfully updated");
                            this.storedNurse.Status = "A";
                        }

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The Nurse is already active.");
                }
            }
        }
    }


}
