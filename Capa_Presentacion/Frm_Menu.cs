﻿using Capa_Presentacion.Modulos._1._Factura;
using Capa_Presentacion.Properties;
using Capa_Presentacion.User_Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Xamarin.Forms;
using Color = System.Drawing.Color;

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

        //Confirmaciones de los botones del CRUD
        private bool confirm_button_Create;
        private bool confirm_button_Read;
        private bool confirm_button_Update;
        private bool confirm_button_Delete;

        private RJButton current_Button;

        private Form active_Form = null;

        private List<Form> formulariosAbiertos = new List<Form>();

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
            public static Color smoke_gray = Color.FromArgb(64, 64, 64);
            public static Color mostaza = Color.FromArgb(247, 106, 10);
            public static Color gray_blue_sky = Color.FromArgb(81, 128, 179);
            public static Color blue_gray = Color.FromArgb(88, 114, 128);
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
            showPanelPago = false;
            showPanelReembolso = false;

            showPanelCliente = !showPanelCliente;
            DeslizarMenus();
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
                btn_MFactura.Image = Resources.btn_MFactura_Background_White;
                btn_MFactura.BackColor = Colores_RGB.gris;
                pnDown_Factura.Height = 125;
            }
            else
            {
                btn_MFactura.Image = Resources.btn_MFactura_Background;
                btn_MFactura.BackColor = Color.Transparent;
                pnDown_Factura.Height = 0;
            }
            if (showPanelPago)
            {
                btn_MPago.Image = Resources.Group_6;
                btn_MPago.BackColor = Colores_RGB.gris;
                pnDown_Pago.Height = 125;
            }
            else
            {
                btn_MPago.Image = Resources.Group_5;
                btn_MPago.BackColor = Color.Transparent;
                pnDown_Pago.Height = 0;
            }
            if (showPanelCliente)
            {
                btn_MCliente.Image = Resources.Group_12__1_;
                btn_MCliente.BackColor = Colores_RGB.gris;
                pnDown_Cliente.Height = 125;
            }
            else
            {
                btn_MCliente.Image = Resources.Group_10;
                btn_MCliente.BackColor = Color.Transparent;
                pnDown_Cliente.Height = 0;
            }
            if (showPanelReembolso)
            {
                btn_MReembolso.Image = Resources.Group_11__1_;
                btn_MReembolso.BackColor = Colores_RGB.gris;
                pnDown_Reembolso.Height = 125;
            }
            else
            {
                btn_MReembolso.Image = Resources.Group_11;
                btn_MReembolso.BackColor = Color.Transparent;
                pnDown_Reembolso.Height = 0;
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
            //AbrirFormularioHijo(new Frm_MFactura_Registro());
            Close_Active_Form();
            AbrirFormulario<Frm_MFactura_Registro>();

        }

        private void btn_Consulta_Factura_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Factura);
            //AbrirFormularioHijo(new Frm_MFactura_Facturas());
            Close_Active_Form();
            AbrirFormulario<Frm_MFactura_Facturas>();
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
                        current_Button.Image = Resources.btn_nuevo_registro_background;
                        current_Button.BackColor = Color.Transparent;
                        current_Button.ForeColor = Color.Black;
                        break;
                    case "btn_Consultar_Factura":
                    case "btn_Consultar_Pago":
                    case "btn_Consultar_Cliente":
                    case "btn_Consultar_Reembolso":
                        current_Button.Image = Resources.btn_lista_entidades_background;
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
                    button.Image = Resources.btn_nuevo_registro_background_white;
                    button.BackColor = Colores_RGB.blue_gray;
                    button.ForeColor = Color.White;
                    break;
                case "btn_Consultar_Factura":
                case "btn_Consultar_Pago":
                case "btn_Consultar_Cliente":
                case "btn_Consultar_Reembolso":
                    button.Image = Resources.btn_lista_entidades_background_white__1_;
                    button.BackColor = Colores_RGB.blue_gray;
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
        #endregion

        #region Atenua botones de CRUD para el Módulo Reembolso
        private void btn_Registrar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Create();
            Atenuar_Opc_Modulo(btn_Registrar_Reembolso);
        }
        private void btn_Consultar_Reembolso_Click(object sender, EventArgs e)
        {
            confirm_Read();
            Atenuar_Opc_Modulo(btn_Consultar_Reembolso);
        }
        #endregion

        #region Minimizar_Ventana
        private void btn_Minimizar_Ventana_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Llama a un formulario hijo, dentro del formulario actual (Padre)
        private void AbrirFormularioHijo(Form hijo)
        {
            //Cuando se lllama al método, si hay un formulario ejecutandose en ese momento, entonces lo cierra.
            if (active_Form != null)
            {
                active_Form.Close();
            }
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pn_Form_Hijo.Controls.Add(hijo);
            pn_Form_Hijo.Tag = hijo;
            hijo.Show();
        }
        #endregion

        //METOIX) PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm> () where MiForm : Form, new()
        {
            Form formulario = formulariosAbiertos.FirstOrDefault(f => f.GetType() == typeof(MiForm));

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.FormClosed += (s, args) => formulariosAbiertos.Remove(formulario);

                formulariosAbiertos.Add(formulario);
            }

            Close_Active_Form(); // Cierra el formulario actual si existe

            active_Form = formulario;

            formulario.TopLevel = false;
            pn_Form_Hijo.Controls.Add(formulario);
            pn_Form_Hijo.Tag = formulario;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            formulario.BringToFront();
        }

        #region Asignacion del Boton Home
        private void btn_HOME_Click(object sender, EventArgs e)
        {
            Cerrar_Forms();
            Restore_Paneles_Modulos();
            DeslizarMenus();
            Reset_Colors_Buttons();
            hidePanels();
        }
        #endregion
        private void Restore_Paneles_Modulos()
        {
            if (showPanelFactura)
            {
                showPanelFactura = !showPanelFactura;
            }else if (showPanelPago)
            {
                showPanelPago = !showPanelPago;
            }
            else if (showPanelCliente)
            {
                showPanelCliente = !showPanelCliente;
            }
            else if (showPanelReembolso)
            {
                showPanelReembolso = !showPanelReembolso;
            }
        }

        private void Cerrar_Forms()
        {
            Close_Active_Form(); // Cierra el formulario actual si existe
            foreach (Form formulario in formulariosAbiertos)
            {
                formulario.Close();
            }
            formulariosAbiertos.Clear();
        }

        private void Close_Active_Form()
        {
            active_Form?.Close();
        }
    }
}
