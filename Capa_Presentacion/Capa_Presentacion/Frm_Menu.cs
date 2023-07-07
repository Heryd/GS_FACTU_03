using Capa_Presentacion.Properties;
using Capa_Presentacion.User_Controls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Menu : Form
    {
        #region Fields
        //Paneles contenedores de las opciones CRUD
        private bool showPanelFactura;
        private bool showPanelPago;
        private bool showPanelCliente;
        private bool showPanelReembolso;

        private bool confirm_button_Create;
        private bool confirm_button_Read;
        private bool confirm_button_Update;
        private bool confirm_button_Delete;

        private RJButton current_Button;

        #endregion

        public Frm_Menu()
        {
            InitializeComponent();
            hidePanels();
        }

        private void hidePanels()
        {
            pnDown_Factura.Height = 0;
            pnDown_Pago.Height = 0;
            pnDown_Cliente.Height = 0;
            pnDown_Reembolso.Height = 0;    
        }

        #region Confirms de CRUD
        private void confirm_Create()
        {
            confirm_button_Read = false;
            confirm_button_Update = false;
            confirm_button_Delete = false;
            confirm_button_Create = !confirm_button_Create;
        }
        private void confirm_Read()
        {
            confirm_button_Create = false;
            confirm_button_Update = false;
            confirm_button_Delete = false;
            confirm_button_Read = !confirm_button_Read;
        }
        private void confirm_Update()
        {
            confirm_button_Create = false;
            confirm_button_Read = false;
            confirm_button_Delete = false;
            confirm_button_Update = !confirm_button_Update;
        }
        private void confirm_Delete()
        {
            confirm_button_Create = false;
            confirm_button_Read = false;
            confirm_button_Update = false;
            confirm_button_Delete = !confirm_button_Delete;
        }

        #endregion

        #region Asignar Colores a variables estaticas
        private struct Colores_RGB
        {
            public static Color oro = Color.FromArgb(253, 173, 21);
            public static Color gris = Color.FromArgb(191, 191, 191);
            public static Color smoke_gray = Color.FromArgb(64,64,64);
            public static Color mostaza = Color.FromArgb(158, 121, 51);
        }
        #endregion

        #region Metodos Click de los botones de Modulo
        private void btn_MFactura_Click(object sender, EventArgs e)
        {
            showPanelPago = false;
            showPanelCliente = false;
            showPanelReembolso = false;

            showPanelFactura = !showPanelFactura;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }

        private void btn_MPago_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelCliente = false;
            showPanelReembolso = false;

            showPanelPago = !showPanelPago;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }

        private void btn_MCliente_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelPago= false;
            showPanelReembolso = false;

            showPanelCliente = !showPanelCliente;
            DeslizarMenus() ;
            Reset_Colors_Buttons();
        }

        private void btn_MReembolso_Click(object sender, EventArgs e)
        {
            showPanelFactura = false;
            showPanelPago = false;
            showPanelCliente = false;

            showPanelReembolso = !showPanelReembolso;
            DeslizarMenus();
            Reset_Colors_Buttons();
        }
        #endregion

        #region Metodo para desplazarnos entre los crud
        private void DeslizarMenus()
        {
            if (showPanelFactura)
            {
                btn_MFactura.Image = Resources.Group_2;
                btn_MFactura.BackColor = Colores_RGB.gris;
                pnDown_Factura.Height = 240;
            }
            else
            {
                btn_MFactura.Image = Resources.Group_1;
                btn_MFactura.BackColor = Color.Transparent;
                pnDown_Factura.Height=0;
            }
            if (showPanelPago)
            {
                btn_MPago.Image = Resources.Group_6;
                btn_MPago.BackColor = Colores_RGB.gris;
                pnDown_Pago.Height = 240;
            }
            else
            {
                btn_MPago.Image = Resources.Group_5;
                btn_MPago.BackColor = Color.Transparent;
                pnDown_Pago.Height=0;
            }
            if (showPanelCliente)
            {
                btn_MCliente.Image = Resources.Group_12__1_;
                btn_MCliente.BackColor = Colores_RGB.gris;
                pnDown_Cliente.Height = 240;
            }
            else
            {
                btn_MCliente.Image = Resources.Group_10;
                btn_MCliente.BackColor = Color.Transparent;
                pnDown_Cliente.Height=0;
            }
            if(showPanelReembolso)
            {
                btn_MReembolso.Image = Resources.Group_11__1_;
                btn_MReembolso.BackColor = Colores_RGB.gris;
                pnDown_Reembolso.Height = 240;
            }
            else
            {
                btn_MReembolso.Image= Resources.Group_11;
                btn_MReembolso.BackColor = Color.Transparent;
                pnDown_Reembolso.Height=0;
            }
        }
        #endregion

        #region Cambia el color e icono a botones de CRUD
        private void Atenuar_Opc_Modulo(RJButton button)
        {
            Reset_Colors_Buttons();
            Paint_Colors_Buttons(button);
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            Frm_Login frm = new Frm_Login();
            frm.Show();
        }

        #region Atenua botones de CRUD para el Módulo Factura
        private void btn_Registro_Factura_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registro_Factura);
        }

        private void btn_Consulta_Factura_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Factura);
        }

        private void btn_Actualizar_Factura_Click(object sender, EventArgs e)
        {
            confirm_Update();
            Atenuar_Opc_Modulo(btn_Actualizar_Factura);
        }

        private void btn_Eliminar_Factura_Click(object sender, EventArgs e)
        {
            confirm_Delete();
            Atenuar_Opc_Modulo(btn_Eliminar_Factura);
        }
        #endregion
        
        #region Restaura el color e icono a su estado pasivo
        private void Reset_Colors_Buttons()
        {
            if (current_Button != null)
            {
                switch (current_Button.Name)
                {
                    case "btn_Registro_Factura":
                    case "btn_Registro_Pago":
                    case "btn_Registrar_Cliente":
                    case "btn_Registrar_Reembolso":
                        current_Button.Image = Resources.Group_14__1_;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                    case "btn_Consultar_Factura":
                    case "btn_Consultar_Pago":
                    case "btn_Consultar_Cliente":
                    case "btn_Consultar_Reembolso":
                        current_Button.Image = Resources.Group_16;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                    case "btn_Actualizar_Factura":
                    case "btn_Actualizar_Pago":
                    case "btn_Actualizar_Cliente":
                    case "btn_Actualizar_Reembolso":
                        current_Button.Image = Resources.Group_21;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                    case "btn_Eliminar_Factura":
                    case "btn_Eliminar_Cliente":
                    case "btn_Eliminar_Pago":
                    case "btn_Eliminar_Reembolso":
                        current_Button.Image = Resources.Group_25;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                }
            }
        }
        #endregion

        #region Se encarga de pintar el boton del CRUD
        private void Paint_Colors_Buttons(object sender)
        {
            var button = (RJButton)sender;
            switch (button.Name)
            {
                case "btn_Registro_Factura":
                case "btn_Registro_Pago":
                case "btn_Registrar_Cliente":
                case "btn_Registrar_Reembolso":
                    button.Image = Resources.Group_17;
                    button.BackColor = Colores_RGB.mostaza;
                    button.ForeColor = Color.White;
                    break;
                case "btn_Consultar_Factura":
                case "btn_Consultar_Pago":
                case "btn_Consultar_Cliente":
                case "btn_Consultar_Reembolso":
                    button.Image = Resources.Group_18;
                    button.BackColor = Colores_RGB.mostaza;
                    button.ForeColor = Color.White;
                    break;
                case "btn_Actualizar_Factura":
                case "btn_Actualizar_Pago":
                case "btn_Actualizar_Cliente":
                case "btn_Actualizar_Reembolso":
                    button.Image = Resources.Group_23;
                    button.BackColor = Colores_RGB.mostaza;
                    button.ForeColor = Color.White;
                    break;
                case "btn_Eliminar_Factura":
                case "btn_Eliminar_Cliente":
                case "btn_Eliminar_Pago":
                case "btn_Eliminar_Reembolso":
                    button.Image = Resources.Group_26;
                    button.BackColor = Colores_RGB.mostaza;
                    button.ForeColor = Color.White;
                    break;
            }
            current_Button = button;
        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Pago
        private void btn_Registro_Pago_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registro_Pago);
        }
        private void btn_Consulta_Pago_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Pago);
        }
        private void btn_Actualizar_Pago_Click(object sender, EventArgs e)
        {
            confirm_Update();
            Atenuar_Opc_Modulo(btn_Actualizar_Pago);
        }
        private void btn_Eliminar_Pago_Click(object sender, EventArgs e)
        {
            confirm_Delete();
            Atenuar_Opc_Modulo(btn_Eliminar_Pago);
        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Cliente
        private void btn_Registrar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registrar_Cliente);
        }

        private void btn_Consultar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Cliente);
        }

        private void btn_Actualizar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Update();
            Atenuar_Opc_Modulo(btn_Actualizar_Cliente);
        }

        private void btn_Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            confirm_Delete();
            Atenuar_Opc_Modulo(btn_Eliminar_Cliente);
        }
        #endregion

        #region Atenua botones de CRUD para el Módulo Reembolso
        private void btn_Registrar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registrar_Reembolso);
        }
        private void btn_Consultar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Read() ;
            Atenuar_Opc_Modulo(btn_Consultar_Reembolso);
        }
        private void btn_Actualizar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Update();
            Atenuar_Opc_Modulo(btn_Actualizar_Reembolso);
        }
        private void btn_Eliminar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Delete();
            Atenuar_Opc_Modulo(btn_Eliminar_Reembolso);
        }
        #endregion

        private void btn_Minimizar_Ventana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
