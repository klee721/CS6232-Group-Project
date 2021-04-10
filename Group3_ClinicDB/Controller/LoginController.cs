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

        public List<User> GetUserByNameAndPassword(string name, string password)
        {
            return this.loginSource.GetUserByNameAndPassword(name, password);
        }

        public bool IsNurseAUser(int id)
        {
            return this.loginSource.IsNurseAUser(id);
        }

        public bool IsAdminAUser(int id)
        {
            return this.loginSource.IsAdminAUser(id);
        }


    }
}
