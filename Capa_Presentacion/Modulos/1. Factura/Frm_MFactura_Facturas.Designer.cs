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
            this.btn_Cerrar_Ventana = new Capa_Presentacion.User_Controls.RJButton();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.rjButton1 = new Capa_Presentacion.User_Controls.RJButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_Eliminar = new MaterialSkin.Controls.MaterialButton();
            this.btn_Editar = new MaterialSkin.Controls.MaterialButton();
            this.dtgv_Factura = new System.Windows.Forms.DataGridView();
            this.pcb_Line = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new System.Windows.Forms.Label();
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
            this.pn_container.Controls.Add(this.btn_Cerrar_Ventana);
            this.pn_container.Controls.Add(this.materialFloatingActionButton1);
            this.pn_container.Controls.Add(this.materialComboBox3);
            this.pn_container.Controls.Add(this.materialComboBox2);
            this.pn_container.Controls.Add(this.materialComboBox1);
            this.pn_container.Controls.Add(this.rjButton1);
            this.pn_container.Controls.Add(this.materialTextBox1);
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
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.AnimateShowHideButton = true;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::Capa_Presentacion.Properties.Resources.Refresh;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(447, 97);
            this.materialFloatingActionButton1.Mini = true;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton1.TabIndex = 44;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 118;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "Pago (All)";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 29;
            this.materialComboBox3.Location = new System.Drawing.Point(800, 100);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(140, 35);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 43;
            this.materialComboBox3.UseTallSize = false;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 118;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Hint = "Cliente (All)";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 29;
            this.materialComboBox2.Location = new System.Drawing.Point(649, 100);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(140, 35);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 42;
            this.materialComboBox2.UseTallSize = false;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 118;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Factura (All)";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 29;
            this.materialComboBox1.Location = new System.Drawing.Point(498, 100);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(140, 35);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 41;
            this.materialComboBox1.UseTallSize = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(450, 100);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(35, 35);
            this.rjButton1.TabIndex = 40;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Buscar...";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(22, 99);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(422, 36);
            this.materialTextBox1.TabIndex = 39;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = global::Capa_Presentacion.Properties.Resources.search_square_svgrepo_com__Custom_;
            this.materialTextBox1.UseTallSize = false;
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
            this.lbl_TOP.Image = global::Capa_Presentacion.Properties.Resources.Line_1;
            this.lbl_TOP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_TOP.Location = new System.Drawing.Point(0, 0);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.Padding = new System.Windows.Forms.Padding(35, 5, 0, 0);
            this.lbl_TOP.Size = new System.Drawing.Size(1375, 83);
            this.lbl_TOP.TabIndex = 1;
            this.lbl_TOP.Text = "FACTURAS";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private User_Controls.RJButton rjButton1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private User_Controls.RJButton btn_Cerrar_Ventana;
    }
}