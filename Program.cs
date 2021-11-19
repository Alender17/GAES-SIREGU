using GAES_SIREGU.vista;
using System;
using System.Windows.Forms;

namespace GAES_SIREGU
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmprincipalmenu());
        }
     }
}
