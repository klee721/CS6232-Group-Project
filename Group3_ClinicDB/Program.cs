using System;
using Group3_ClinicDB.Model;
using System.Windows.Forms;

namespace Group3_ClinicDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            
            User testUser = new User();
            testUser.userName = "Mr.TestUser";
.
            //Application.Run(new NurseMainDashboard(testUser));  
            Application.Run(new LoginForm());
        }
    }
}
