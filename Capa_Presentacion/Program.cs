using System;
using Capa_Presentacion.User_Controls;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Login frm = new Frm_Login();
            //Frm_Modulo_Factura frm = new Frm_Modulo_Factura();
            frm.Show();

            Application.Run();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
