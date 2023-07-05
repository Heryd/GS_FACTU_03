using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Capa_Presentacion
{
    public partial class Frm_Menu : Form
    {
        private int shooter = -1;
        public Frm_Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            CRUD_Factura.Visible = false;
            CRUD_Pago.Visible= false;
            CRUD_Cliente.Visible= false;
        }

        private void hideCRUD()
        {
            if(CRUD_Factura.Visible)
                CRUD_Factura.Visible= false;
            if(CRUD_Pago.Visible)
                CRUD_Pago.Visible= false;
            if(!CRUD_Cliente.Visible)
                CRUD_Cliente.Visible= false;
        }

        private bool showCRUD(Panel CRUD)
        {
            if (!CRUD.Visible)
            {
                hideCRUD();
                CRUD.Visible = true;
                return true;
            }
            else
            {
                CRUD.Visible = false;
                return false;
            }
        }

        private void lbl_Acerca_De_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.Show();
            Hide();
        }

        private void btn_Modulo_Close_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.Show();
            Hide();
        }


        private void btn_create_MouseMove(object sender, MouseEventArgs e)
        {
            create_Selected.Visible = true;
            create_unSelect.Visible = false;

            arrow_Create_Selected.Visible = true;
            arrow_Create_unSelect.Visible = false;

            create_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_create.RightColor = Color.FromArgb(253, 198, 76);
            btn_create.LeftColor = Color.FromArgb(253, 198, 76);
            arrow_Create_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_create.ForeColor = Color.Black;
        }

        private void btn_create_MouseLeave(object sender, EventArgs e)
        {
            create_Selected.Visible = false;
            create_unSelect.Visible = true;
            btn_create.LeftColor = Color.White;
            btn_create.RightColor = Color.White;
            btn_create.ForeColor = Color.FromArgb(64, 64, 64);
            arrow_Create_Selected.Visible = false;
            arrow_Create_unSelect.Visible = true;
        }

        //Resaltar el boton del modelo Factura
        #region Color del Boton btn_Factura
        public void AtenuarColorFactura()
        {
            pcb_Factura_noSelect.Visible = false;
            arrow_Down_Factura_noSelected.Visible = false;

            pcb_Factura_Selected.BackColor = Color.FromArgb(191, 191, 191);
            arrow_Down_Factura_Selected.BackColor = Color.FromArgb(191, 191, 191);

            btn_Factura.LeftColor = Color.FromArgb(191, 191, 191);
            btn_Factura.RightColor = Color.FromArgb(191, 191, 191);
            btn_Factura.ForeColor = Color.Black;

            pcb_Factura_Selected.Visible = true;
            arrow_Down_Factura_Selected.Visible = true;
        }

        public void RetornarColorNormalFactura()
        {
            btn_Factura.LeftColor = Color.White;
            btn_Factura.RightColor = Color.White;
            btn_Factura.ForeColor = Color.FromArgb(64, 64, 64);

            pcb_Factura_Selected.Visible = false;
            pcb_Factura_noSelect.Visible = true;

            arrow_Down_Factura_Selected.Visible = false;
            arrow_Down_Factura_noSelected.Visible = true;
        }
        #endregion

        //Resaltar el boton del modulo Pago
        #region Color del Boton btn_Pago
        public void AtenuarColorPago()
        {
            pcb_Pago.Visible = false;
            arrow_Down_Pago.Visible = false;

            pcb_Pago_Selected.BackColor = Color.FromArgb(191, 191, 191);
            arrow_Down_Pago_Selected.BackColor = Color.FromArgb(191, 191, 191);

            btn_Modulo_Pago.LeftColor = Color.FromArgb(191, 191, 191);
            btn_Modulo_Pago.RightColor = Color.FromArgb(191, 191, 191);
            btn_Modulo_Pago.ForeColor = Color.Black;

            pcb_Pago_Selected.Visible = true;
            arrow_Down_Pago_Selected.Visible = true;
        }

        public void RetornarColorNormalPago()
        {
            btn_Modulo_Pago.LeftColor = Color.White;
            btn_Modulo_Pago.RightColor = Color.White;
            btn_Modulo_Pago.ForeColor = Color.FromArgb(64, 64, 64);

            pcb_Pago_Selected.Visible = false;
            pcb_Pago.Visible = true;

            arrow_Down_Pago_Selected.Visible = false;
            arrow_Down_Pago.Visible = true;
        }
        #endregion 

        private void btn_read_MouseMove(object sender, MouseEventArgs e)
        {
            read_Selected.Visible = true;
            read_unSelect.Visible = false;

            arrow_Read_Selected.Visible = true;
            arrow_Read_unSelect.Visible = false;

            read_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_read.RightColor = Color.FromArgb(253, 198, 76);
            btn_read.LeftColor = Color.FromArgb(253, 198, 76);
            arrow_Read_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_read.ForeColor = Color.Black;
        }

        private void btn_read_MouseLeave(object sender, EventArgs e)
        {
            read_Selected.Visible = false;
            read_unSelect.Visible = true;
            btn_read.LeftColor = Color.White;
            btn_read.RightColor = Color.White;
            btn_read.ForeColor = Color.FromArgb(64, 64, 64);
            arrow_Read_Selected.Visible = false;
            arrow_Read_unSelect.Visible = true;
        }

        private void btn_update_MouseMove(object sender, MouseEventArgs e)
        {
            update_Selected.Visible = true;
            update_unSelect.Visible = false;

            arrow_Update_Selected.Visible = true;
            arrow_Update_unSelected.Visible = false;

            update_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_update.RightColor = Color.FromArgb(253, 198, 76);
            btn_update.LeftColor = Color.FromArgb(253, 198, 76);
            arrow_Update_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_update.ForeColor = Color.Black;
        }

        private void btn_update_MouseLeave(object sender, EventArgs e)
        {
            update_Selected.Visible = false;
            update_unSelect.Visible = true;
            btn_update.LeftColor = Color.White;
            btn_update.RightColor = Color.White;
            btn_update.ForeColor = Color.FromArgb(64, 64, 64);
            arrow_Update_Selected.Visible = false;
            arrow_Update_unSelected.Visible = true;
        }

        private void btn_delete_MouseMove(object sender, MouseEventArgs e)
        {
            delete_Selected.Visible = true;
            delete_unSelected.Visible = false;

            arrow_delete_Selected.Visible = true;
            arrow_Delete_unSelected.Visible = false;

            delete_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_delete.RightColor = Color.FromArgb(253, 198, 76);
            btn_delete.LeftColor = Color.FromArgb(253, 198, 76);
            arrow_delete_Selected.BackColor = Color.FromArgb(253, 198, 76);
            btn_delete.ForeColor = Color.Black;
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            delete_Selected.Visible = false;
            delete_unSelected.Visible = true;
            btn_delete.LeftColor = Color.White;
            btn_delete.RightColor = Color.White;
            btn_delete.ForeColor = Color.FromArgb(64, 64, 64);
            arrow_delete_Selected.Visible = false;
            arrow_Delete_unSelected.Visible = true;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_create_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Factura_Click(object sender, EventArgs e)
        {
            if (showCRUD(CRUD_Factura))
            {
                AtenuarColorFactura();

                CRUD_Factura.Location = new Point(27, 343);

                //Acomodar Modulos a nueva Posicion
                //Pago
                btn_Modulo_Pago.Location = new Point(27, 555);
                pcb_Pago.Location = new Point(41, 558);
                arrow_Down_Pago.Location = new Point(250, 558);

                //Cliente
                btn_Modulo_Cliente.Location = new Point(27, 629);
                pcb_Cliente.Location = new Point(41, 632);
                arrow_Down_Cliente.Location = new Point(250, 632);

                //Reembolso
                btn_Modulo_Reembolso.Location = new Point(27, 708);
                pcb_Reembolso.Location = new Point(41, 711);
                arrow_Down_Reembolso.Location = new Point(250, 711);
            }
            else
            {
                RetornarColorNormalFactura();

                //Regresar Modulos a su antigua Posicion
                //Pago
                btn_Modulo_Pago.Location = new Point(27, 367);
                pcb_Pago.Location = new Point(41, 370);
                arrow_Down_Pago.Location = new Point(250, 370);

                //Cliente
                btn_Modulo_Cliente.Location = new Point(27, 446);
                pcb_Cliente.Location = new Point(41, 449);
                arrow_Down_Cliente.Location = new Point(250, 449);

                //Reembolso
                btn_Modulo_Reembolso.Location = new Point(27, 524);
                pcb_Reembolso.Location = new Point(41, 527);
                arrow_Down_Reembolso.Location = new Point(250, 527);
            }
        }

        private void btn_Modulo_Pago_Click(object sender, EventArgs e)
        {
            if (showCRUD(CRUD_Pago))
            {
                AtenuarColorPago();

                CRUD_Pago.Location = new Point(27, 421);

                //Acomodar Modulos a nueva Posicion

                //Cliente
                btn_Modulo_Cliente.Location = new Point(27, 643);
                pcb_Cliente.Location = new Point(41, 646);
                arrow_Down_Cliente.Location = new Point(250, 646);

                //Reembolso
                btn_Modulo_Reembolso.Location = new Point(27, 721);
                pcb_Reembolso.Location = new Point(41, 723);
                arrow_Down_Reembolso.Location = new Point(250, 723);
            }
            else
            {
                RetornarColorNormalPago();

                //Regresar Modulos a su antigua Posicion

                //Cliente
                btn_Modulo_Cliente.Location = new Point(27, 446);
                pcb_Cliente.Location = new Point(41, 449);
                arrow_Down_Cliente.Location = new Point(250, 449);

                //Reembolso
                btn_Modulo_Reembolso.Location = new Point(27, 524);
                pcb_Reembolso.Location = new Point(41, 527);
                arrow_Down_Reembolso.Location = new Point(250, 527);
            }
        }
    }
}
