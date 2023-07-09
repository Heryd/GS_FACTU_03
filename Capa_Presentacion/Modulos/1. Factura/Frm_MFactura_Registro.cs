using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_MFactura_Registro : Form
    {
        public Frm_MFactura_Registro()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.LightBlue100, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Asignar Colores a variables estaticas
        private struct Colores_RGB
        {
            public static Color oro = Color.FromArgb(253, 173, 21);
            public static Color gris = Color.FromArgb(191, 191, 191);
            public static Color smoke_gray = Color.FromArgb(64, 64, 64);
            public static Color mostaza = Color.FromArgb(158, 121, 51);
        }
        #endregion

        private void pintarBotones()
        {
        }

        private void btn_Cerrar_Ventana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
