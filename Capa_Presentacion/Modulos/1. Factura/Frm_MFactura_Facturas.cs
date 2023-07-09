using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_MFactura_Facturas : Form
    {
        public Frm_MFactura_Facturas()
        {
            InitializeComponent();
            Paint_Button_Options();
        }

        private void Paint_Button_Options()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.LightBlue100, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);
        }

        private void btn_Cerrar_Ventana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_MModificar_Factura frm = new Frm_MModificar_Factura();
            frm.Show();
        }
    }
}
