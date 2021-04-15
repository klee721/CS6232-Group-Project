using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Group3_ClinicDB.Model;
using System.Windows.Forms;

namespace Group3_ClinicDB.View
{

    public partial class AdminMainDashboard : Form
    {

        public User user;
        public Patient patient;
        private LoginForm loginform;

        public AdminMainDashboard(User user, LoginForm loginform)
        {
            InitializeComponent();
            this.UserNameLabel.Text = user.userName;
            this.UserFullNameLabel.Text = user.firstName + " " + user.lastName;
            this.loginform = loginform;
            
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.loginform.Show();
            this.patient = null;
            this.addUserUserControl1.ClearModule();
            this.editNurseUserControl1.ClearModule();
        }

        public void ChangeUser(User newUser)
        {
            this.user = newUser;
            this.UserNameLabel.Text = user.userName;
            this.UserFullNameLabel.Text = user.firstName + " " + user.lastName;
        }
    }

















}
