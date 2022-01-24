using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
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

            Login login_form = new Login();
            Application.Run(login_form);

            if (login_form.UserSuccessfullyAuthenticated)
            {
                if (login_form.LoginUser.access == "Administrator")
                {
                    Application.Run(new AdministratorMenu(login_form.LoginUser));
                }
                else if (login_form.LoginUser.access == "Seller")
                {
                    Application.Run(new SellerMenu(login_form.LoginUser));
                }
                else
                {
                    Application.Run(new CustomerMenu(login_form.LoginUser));
                }
            }
            Console.WriteLine("\n\nbye\n\n");
        }
    }
}
