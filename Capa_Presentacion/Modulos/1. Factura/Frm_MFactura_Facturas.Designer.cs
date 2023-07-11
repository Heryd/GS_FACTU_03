namespace Capa_Presentacion.Modulos._1._Factura
{
    partial class Frm_MFactura_Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_container_Extern = new System.Windows.Forms.Panel();
            this.pn_container = new System.Windows.Forms.Panel();
            this.btn_refresh = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btn_Cerrar_Ventana = new Capa_Presentacion.User_Controls.RJButton();
            this.btn_search = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.cmb_Filtro_Pago = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_Filtro_Cliente = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_filtro_Factura = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_busqueda = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_Eliminar = new MaterialSkin.Controls.MaterialButton();
            this.btn_Editar = new MaterialSkin.Controls.MaterialButton();
            this.dtgv_Factura = new System.Windows.Forms.DataGridView();
            this.pcb_Line = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new System.Windows.Forms.Label();
            this.divider = new MaterialSkin.Controls.MaterialDivider();
            this.pn_container_Extern.SuspendLayout();
            this.pn_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_container_Extern
            // 
            this.pn_container_Extern.BackColor = System.Drawing.Color.White;
            this.pn_container_Extern.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_container_Extern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_container_Extern.Controls.Add(this.pn_container);
            this.pn_container_Extern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container_Extern.Location = new System.Drawing.Point(0, 0);
            this.pn_container_Extern.Name = "pn_container_Extern";
            this.pn_container_Extern.Size = new System.Drawing.Size(1433, 789);
            this.pn_container_Extern.TabIndex = 0;
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Controls.Add(this.divider);
            this.pn_container.Controls.Add(this.btn_refresh);
            this.pn_container.Controls.Add(this.btn_Cerrar_Ventana);
            this.pn_container.Controls.Add(this.btn_search);
            this.pn_container.Controls.Add(this.cmb_Filtro_Pago);
            this.pn_container.Controls.Add(this.cmb_Filtro_Cliente);
            this.pn_container.Controls.Add(this.cmb_filtro_Factura);
            this.pn_container.Controls.Add(this.txt_busqueda);
            this.pn_container.Controls.Add(this.btn_Eliminar);
            this.pn_container.Controls.Add(this.btn_Editar);
            this.pn_container.Controls.Add(this.dtgv_Factura);
            this.pn_container.Controls.Add(this.pcb_Line);
            this.pn_container.Controls.Add(this.lbl_TOP);
            this.pn_container.Location = new System.Drawing.Point(25, 25);
            this.pn_container.MinimumSize = new System.Drawing.Size(1375, 720);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1375, 720);
            this.pn_container.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.AnimateShowHideButton = true;
            this.btn_refresh.Depth = 0;
            this.btn_refresh.Icon = global::Capa_Presentacion.Properties.Resources.Refresh;
            this.btn_refresh.Location = new System.Drawing.Point(443, 97);
            this.btn_refresh.Mini = true;
            this.btn_refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 46;
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_Cerrar_Ventana
            // 
            this.btn_Cerrar_Ventana.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar_Ventana.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Cerrar_Ventana.BorderRadius = 10;
            this.btn_Cerrar_Ventana.BorderSize = 0;
            this.btn_Cerrar_Ventana.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar_Ventana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar_Ventana.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar_Ventana.Image = global::Capa_Presentacion.Properties.Resources.close_circle_fill;
            this.btn_Cerrar_Ventana.Location = new System.Drawing.Point(1291, 3);
            this.btn_Cerrar_Ventana.Name = "btn_Cerrar_Ventana";
            this.btn_Cerrar_Ventana.Size = new System.Drawing.Size(57, 60);
            this.btn_Cerrar_Ventana.TabIndex = 45;
            this.btn_Cerrar_Ventana.UseVisualStyleBackColor = false;
            this.btn_Cerrar_Ventana.Click += new System.EventHandler(this.btn_Cerrar_Ventana_Click);
            // 
            // btn_search
            // 
            this.btn_search.AnimateShowHideButton = true;
            this.btn_search.Depth = 0;
            this.btn_search.Icon = global::Capa_Presentacion.Properties.Resources._9_a_Read_Selected;
            this.btn_search.Location = new System.Drawing.Point(391, 97);
            this.btn_search.Mini = true;
            this.btn_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 40);
            this.btn_search.TabIndex = 44;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // cmb_Filtro_Pago
            // 
            this.cmb_Filtro_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Pago.AutoResize = false;
            this.cmb_Filtro_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Filtro_Pago.Depth = 0;
            this.cmb_Filtro_Pago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Filtro_Pago.DropDownHeight = 118;
            this.cmb_Filtro_Pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filtro_Pago.DropDownWidth = 121;
            this.cmb_Filtro_Pago.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Filtro_Pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Filtro_Pago.FormattingEnabled = true;
            this.cmb_Filtro_Pago.Hint = "Pago (All)";
            this.cmb_Filtro_Pago.IntegralHeight = false;
            this.cmb_Filtro_Pago.ItemHeight = 29;
            this.cmb_Filtro_Pago.Items.AddRange(new object[] {
            "Total a Pagar",
            "Ninguno"});
            this.cmb_Filtro_Pago.Location = new System.Drawing.Point(799, 100);
            this.cmb_Filtro_Pago.MaxDropDownItems = 4;
            this.cmb_Filtro_Pago.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Filtro_Pago.Name = "cmb_Filtro_Pago";
            this.cmb_Filtro_Pago.Size = new System.Drawing.Size(156, 35);
            this.cmb_Filtro_Pago.StartIndex = 1;
            this.cmb_Filtro_Pago.TabIndex = 43;
            this.cmb_Filtro_Pago.UseTallSize = false;
            // 
            // cmb_Filtro_Cliente
            // 
            this.cmb_Filtro_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Filtro_Cliente.AutoResize = false;
            this.cmb_Filtro_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Filtro_Cliente.Depth = 0;
            this.cmb_Filtro_Cliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Filtro_Cliente.DropDownHeight = 118;
            this.cmb_Filtro_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filtro_Cliente.DropDownWidth = 121;
            this.cmb_Filtro_Cliente.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Filtro_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Filtro_Cliente.FormattingEnabled = true;
            this.cmb_Filtro_Cliente.Hint = "Cliente (All)";
            this.cmb_Filtro_Cliente.IntegralHeight = false;
            this.cmb_Filtro_Cliente.ItemHeight = 29;
            this.cmb_Filtro_Cliente.Items.AddRange(new object[] {
            "Cédula",
            "Género",
            "Ninguno"});
            this.cmb_Filtro_Cliente.Location = new System.Drawing.Point(647, 100);
            this.cmb_Filtro_Cliente.MaxDropDownItems = 4;
            this.cmb_Filtro_Cliente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Filtro_Cliente.Name = "cmb_Filtro_Cliente";
            this.cmb_Filtro_Cliente.Size = new System.Drawing.Size(140, 35);
            this.cmb_Filtro_Cliente.StartIndex = 1;
            this.cmb_Filtro_Cliente.TabIndex = 42;
            this.cmb_Filtro_Cliente.UseTallSize = false;
            // 
            // cmb_filtro_Factura
            // 
            this.cmb_filtro_Factura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_filtro_Factura.AutoResize = false;
            this.cmb_filtro_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_filtro_Factura.Depth = 0;
            this.cmb_filtro_Factura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_filtro_Factura.DropDownHeight = 118;
            this.cmb_filtro_Factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filtro_Factura.DropDownWidth = 121;
            this.cmb_filtro_Factura.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_filtro_Factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_filtro_Factura.FormattingEnabled = true;
            this.cmb_filtro_Factura.Hint = "Factura (All)";
            this.cmb_filtro_Factura.IntegralHeight = false;
            this.cmb_filtro_Factura.ItemHeight = 29;
            this.cmb_filtro_Factura.Items.AddRange(new object[] {
            "Factura (all)",
            "Identificador",
            "Fecha"});
            this.cmb_filtro_Factura.Location = new System.Drawing.Point(495, 100);
            this.cmb_filtro_Factura.MaxDropDownItems = 4;
            this.cmb_filtro_Factura.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_filtro_Factura.Name = "cmb_filtro_Factura";
            this.cmb_filtro_Factura.Size = new System.Drawing.Size(140, 35);
            this.cmb_filtro_Factura.StartIndex = 1;
            this.cmb_filtro_Factura.TabIndex = 41;
            this.cmb_filtro_Factura.UseTallSize = false;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.AnimateReadOnly = false;
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_busqueda.Depth = 0;
            this.txt_busqueda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_busqueda.Hint = "Buscar...";
            this.txt_busqueda.LeadingIcon = null;
            this.txt_busqueda.Location = new System.Drawing.Point(22, 99);
            this.txt_busqueda.MaxLength = 50;
            this.txt_busqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_busqueda.Multiline = false;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(357, 36);
            this.txt_busqueda.TabIndex = 39;
            this.txt_busqueda.Text = "";
            this.txt_busqueda.TrailingIcon = null;
            this.txt_busqueda.UseTallSize = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.AutoSize = false;
            this.btn_Eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Eliminar.Depth = 0;
            this.btn_Eliminar.HighEmphasis = true;
            this.btn_Eliminar.Icon = null;
            this.btn_Eliminar.Location = new System.Drawing.Point(1188, 100);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Eliminar.Size = new System.Drawing.Size(160, 35);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Eliminar.UseAccentColor = true;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.AutoSize = false;
            this.btn_Editar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Editar.Depth = 0;
            this.btn_Editar.HighEmphasis = true;
            this.btn_Editar.Icon = null;
            this.btn_Editar.Location = new System.Drawing.Point(1020, 100);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Editar.Size = new System.Drawing.Size(160, 35);
            this.btn_Editar.TabIndex = 36;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Editar.UseAccentColor = false;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // dtgv_Factura
            // 
            this.dtgv_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Factura.Location = new System.Drawing.Point(22, 167);
            this.dtgv_Factura.Name = "dtgv_Factura";
            this.dtgv_Factura.RowHeadersWidth = 62;
            this.dtgv_Factura.RowTemplate.Height = 28;
            this.dtgv_Factura.Size = new System.Drawing.Size(1326, 533);
            this.dtgv_Factura.TabIndex = 35;
            // 
            // pcb_Line
            // 
            this.pcb_Line.Image = global::Capa_Presentacion.Properties.Resources.Line_21;
            this.pcb_Line.Location = new System.Drawing.Point(22, 14);
            this.pcb_Line.Name = "pcb_Line";
            this.pcb_Line.Size = new System.Drawing.Size(10, 45);
            this.pcb_Line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Line.TabIndex = 34;
            this.pcb_Line.TabStop = false;
            // 
            // lbl_TOP
            // 
            this.lbl_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TOP.Font = new System.Drawing.Font("Koodak", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_TOP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_TOP.Location = new System.Drawing.Point(0, 0);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.Padding = new System.Windows.Forms.Padding(35, 5, 0, 0);
            this.lbl_TOP.Size = new System.Drawing.Size(1375, 83);
            this.lbl_TOP.TabIndex = 1;
            this.lbl_TOP.Text = "FACTURAS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divider.Depth = 0;
            this.divider.Location = new System.Drawing.Point(12, 69);
            this.divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1348, 5);
            this.divider.TabIndex = 53;
            this.divider.Text = "materialDivider1";
            // 
            // Frm_MFactura_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1433, 789);
            this.Controls.Add(this.pn_container_Extern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1433, 789);
            this.MinimumSize = new System.Drawing.Size(1433, 789);
            this.Name = "Frm_MFactura_Facturas";
            this.Text = "Frm_MFactura_Facturas";
            this.pn_container_Extern.ResumeLayout(false);
            this.pn_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_container_Extern;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Label lbl_TOP;
        private System.Windows.Forms.PictureBox pcb_Line;
        private System.Windows.Forms.DataGridView dtgv_Factura;
        private MaterialSkin.Controls.MaterialButton btn_Editar;
        private MaterialSkin.Controls.MaterialButton btn_Eliminar;
        private MaterialSkin.Controls.MaterialTextBox txt_busqueda;
        private MaterialSkin.Controls.MaterialComboBox cmb_Filtro_Pago;
        private MaterialSkin.Controls.MaterialComboBox cmb_Filtro_Cliente;
        private MaterialSkin.Controls.MaterialComboBox cmb_filtro_Factura;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_search;
        private User_Controls.RJButton btn_Cerrar_Ventana;
        private MaterialSkin.Controls.MaterialFloatingActionButton btn_refresh;
        private MaterialSkin.Controls.MaterialDivider divider;
    }
}