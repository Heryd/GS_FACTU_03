using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Capa_Presentacion
{
    public partial class Frm_Modulo_Factura : Form
    {
        public Frm_Modulo_Factura()
        {
            InitializeComponent();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cr_parmams = base.CreateParams;
                cr_parmams.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cr_parmams;
            }
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.Show();
            Hide();
        }
    }
}
