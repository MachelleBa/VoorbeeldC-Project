using System;
using System.Windows.Forms;
using Chapeau_Model;

namespace ProjectChapeau
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
          //  TableTop table = new TableTop();
            Application.Run(new LoginForm());
        }
    }
}
