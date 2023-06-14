using RegistrationForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_warung_kos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new RegForm());
=======
            Application.Run(new daftarMenu());
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
        }
    }
}
