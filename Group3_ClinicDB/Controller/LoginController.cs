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

        public bool IsUsernameUnique(string username)
        {
           return this.loginSource.IsUsernameUnique(username);
        }

        public bool CreateNewUser(User user, string username, string password)
        {
            return this.loginSource.CreateNewUser(user, username, password);
        }

        public string GetUsernameByNurseID(int nurseID)
        {
            return this.loginSource.GetUsernameByNurseID(nurseID);
        }

        public bool UpdateUser(User user, string password)
        {
           return this.loginSource.UpdateUser(user, password);
  
        }

    }
}
