using System;
using System.Collections.Generic;
using Group3_ClinicDB.Model;
using Group3_ClinicDB.DAL;

namespace Group3_ClinicDB.Controller
{
    /// <summary>
    /// Login Controller that handles access to the DAL for Logins
    /// </summary>
    class LoginController
    {
        LoginDAL loginSource;

        /// <summary>
        /// Constructor for the controller
        /// </summary>
        public LoginController()
        {
            this.loginSource = new LoginDAL();
        }

        /// <summary>
        /// Returns the result of the LoginDALs GetAllUsers method
        /// </summary>
        /// <returns>a list of all Users</returns>
        public List<User> GetAllUsers()
        {
            return this.loginSource.GetAllUsers();
        }

    }
}
