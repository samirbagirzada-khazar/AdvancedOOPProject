using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedOOPProject
{

   public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MainWindow MWindow;
        [STAThread]
     
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MWindow = new MainWindow();
            Application.Run(MWindow);

        }
    }
}
