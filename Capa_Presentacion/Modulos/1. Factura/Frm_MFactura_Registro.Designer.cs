namespace Capa_Presentacion.Modulos._1._Factura
{
    partial class Frm_MFactura_Registro
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
            this.pn_Fondo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Fecha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pcb_Line = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar_Ventana = new Capa_Presentacion.User_Controls.RJButton();
            this.btn_Clean = new MaterialSkin.Controls.MaterialButton();
            this.btn_Print = new MaterialSkin.Controls.MaterialButton();
            this.btn_Registrar = new MaterialSkin.Controls.MaterialButton();
            this.lbl_Total_a_Pagar = new Capa_Presentacion.Gradient_Label_Bounds();
            this.lbl_Vuelto = new Capa_Presentacion.Gradient_Label_Bounds();
            this.txt_Pago = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Nombre_Vendedor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_Metodo_Pago = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_Telefono_Cliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Nombre_Cliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Cedula_Encontrada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCliente_Cedula = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_TOP = new System.Windows.Forms.Label();
            this.pn_Fondo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Fondo
            // 
            this.pn_Fondo.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Fondo.Controls.Add(this.panel1);
            this.pn_Fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pn_Fondo.Name = "pn_Fondo";
            this.pn_Fondo.Size = new System.Drawing.Size(1433, 789);
            this.pn_Fondo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txt_Fecha);
            this.panel1.Controls.Add(this.pcb_Line);
            this.panel1.Controls.Add(this.btn_Cerrar_Ventana);
            this.panel1.Controls.Add(this.btn_Clean);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.lbl_Total_a_Pagar);
            this.panel1.Controls.Add(this.lbl_Vuelto);
            this.panel1.Controls.Add(this.txt_Pago);
            this.panel1.Controls.Add(this.txt_Nombre_Vendedor);
            this.panel1.Controls.Add(this.materialTextBox1);
            this.panel1.Controls.Add(this.cmb_Metodo_Pago);
            this.panel1.Controls.Add(this.txt_Telefono_Cliente);
            this.panel1.Controls.Add(this.txt_Nombre_Cliente);
            this.panel1.Controls.Add(this.txt_Cedula_Encontrada);
            this.panel1.Controls.Add(this.txtCliente_Cedula);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_Cliente);
            this.panel1.Controls.Add(this.lbl_TOP);
            this.panel1.Location = new System.Drawing.Point(21, 21);
            this.panel1.MinimumSize = new System.Drawing.Size(1375, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 720);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.AllowPromptAsInput = true;
            this.txt_Fecha.AnimateReadOnly = false;
            this.txt_Fecha.AsciiOnly = false;
            this.txt_Fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Fecha.BeepOnError = false;
            this.txt_Fecha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_Fecha.Depth = 0;
            this.txt_Fecha.ErrorMessage = "No se permiten letras, solo números";
            this.txt_Fecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Fecha.HelperText = "Día / Mes / Año";
            this.txt_Fecha.HidePromptOnLeave = false;
            this.txt_Fecha.HideSelection = true;
            this.txt_Fecha.Hint = "DD/MM/YYYY";
            this.txt_Fecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_Fecha.LeadingIcon = null;
            this.txt_Fecha.Location = new System.Drawing.Point(635, 153);
            this.txt_Fecha.Mask = "00/00/0000";
            this.txt_Fecha.MaxLength = 32767;
            this.txt_Fecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.PasswordChar = '\0';
            this.txt_Fecha.PrefixSuffixText = null;
            this.txt_Fecha.PromptChar = '_';
            this.txt_Fecha.ReadOnly = false;
            this.txt_Fecha.RejectInputOnFirstFailure = false;
            this.txt_Fecha.ResetOnPrompt = true;
            this.txt_Fecha.ResetOnSpace = true;
            this.txt_Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Fecha.SelectedText = "";
            this.txt_Fecha.SelectionLength = 0;
            this.txt_Fecha.SelectionStart = 0;
            this.txt_Fecha.ShortcutsEnabled = true;
            this.txt_Fecha.ShowAssistiveText = true;
            this.txt_Fecha.Size = new System.Drawing.Size(261, 52);
            this.txt_Fecha.SkipLiterals = true;
            this.txt_Fecha.TabIndex = 34;
            this.txt_Fecha.TabStop = false;
            this.txt_Fecha.Text = "  /  /";
            this.txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Fecha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_Fecha.TrailingIcon = null;
            this.txt_Fecha.UseSystemPasswordChar = false;
            this.txt_Fecha.UseTallSize = false;
            this.txt_Fecha.ValidatingType = null;
            // 
            // pcb_Line
            // 
            this.pcb_Line.Image = global::Capa_Presentacion.Properties.Resources.Line_21;
            this.pcb_Line.Location = new System.Drawing.Point(25, 15);
            this.pcb_Line.Name = "pcb_Line";
            this.pcb_Line.Size = new System.Drawing.Size(10, 45);
            this.pcb_Line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Line.TabIndex = 33;
            this.pcb_Line.TabStop = false;
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
            this.btn_Cerrar_Ventana.Location = new System.Drawing.Point(1315, 11);
            this.btn_Cerrar_Ventana.Name = "btn_Cerrar_Ventana";
            this.btn_Cerrar_Ventana.Size = new System.Drawing.Size(57, 60);
            this.btn_Cerrar_Ventana.TabIndex = 32;
            this.btn_Cerrar_Ventana.UseVisualStyleBackColor = false;
            this.btn_Cerrar_Ventana.Click += new System.EventHandler(this.btn_Cerrar_Ventana_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.AutoSize = false;
            this.btn_Clean.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Clean.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Clean.Depth = 0;
            this.btn_Clean.Font = new System.Drawing.Font("Iosevka Extrabold Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.HighEmphasis = true;
            this.btn_Clean.Icon = global::Capa_Presentacion.Properties.Resources.broom_line;
            this.btn_Clean.Location = new System.Drawing.Point(409, 398);
            this.btn_Clean.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Clean.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Clean.Size = new System.Drawing.Size(166, 40);
            this.btn_Clean.TabIndex = 29;
            this.btn_Clean.Text = "LIMPIAR";
            this.btn_Clean.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Clean.UseAccentColor = false;
            this.btn_Clean.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = false;
            this.btn_Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Print.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Print.Depth = 0;
            this.btn_Print.Font = new System.Drawing.Font("Iosevka Extrabold Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.HighEmphasis = true;
            this.btn_Print.Icon = global::Capa_Presentacion.Properties.Resources.print;
            this.btn_Print.Location = new System.Drawing.Point(232, 398);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Print.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Print.Size = new System.Drawing.Size(166, 40);
            this.btn_Print.TabIndex = 28;
            this.btn_Print.Text = "IMPRIMIR";
            this.btn_Print.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Print.UseAccentColor = false;
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.AutoSize = false;
            this.btn_Registrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Registrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Registrar.Depth = 0;
            this.btn_Registrar.Font = new System.Drawing.Font("DM Mono Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.HighEmphasis = true;
            this.btn_Registrar.Icon = global::Capa_Presentacion.Properties.Resources.Register_ButtonIcon;
            this.btn_Registrar.Location = new System.Drawing.Point(55, 398);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Registrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Registrar.Size = new System.Drawing.Size(166, 40);
            this.btn_Registrar.TabIndex = 27;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Registrar.UseAccentColor = true;
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // lbl_Total_a_Pagar
            // 
            this.lbl_Total_a_Pagar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_a_Pagar.BorderRadius = 5;
            this.lbl_Total_a_Pagar.BorderSize = 0;
            this.lbl_Total_a_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total_a_Pagar.Font = new System.Drawing.Font("IBM Plex Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_a_Pagar.ForeColor = System.Drawing.Color.White;
            this.lbl_Total_a_Pagar.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(215)))), ((int)(((byte)(169)))));
            this.lbl_Total_a_Pagar.Location = new System.Drawing.Point(1063, 212);
            this.lbl_Total_a_Pagar.Name = "lbl_Total_a_Pagar";
            this.lbl_Total_a_Pagar.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(215)))), ((int)(((byte)(169)))));
            this.lbl_Total_a_Pagar.Size = new System.Drawing.Size(268, 36);
            this.lbl_Total_a_Pagar.TabIndex = 26;
            this.lbl_Total_a_Pagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Vuelto
            // 
            this.lbl_Vuelto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Vuelto.BorderRadius = 5;
            this.lbl_Vuelto.BorderSize = 0;
            this.lbl_Vuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Vuelto.Font = new System.Drawing.Font("IBM Plex Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vuelto.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Vuelto.LeftColor = System.Drawing.Color.Transparent;
            this.lbl_Vuelto.Location = new System.Drawing.Point(1063, 153);
            this.lbl_Vuelto.Name = "lbl_Vuelto";
            this.lbl_Vuelto.RightColor = System.Drawing.Color.Transparent;
            this.lbl_Vuelto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Vuelto.Size = new System.Drawing.Size(268, 36);
            this.lbl_Vuelto.TabIndex = 25;
            this.lbl_Vuelto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Pago
            // 
            this.txt_Pago.AnimateReadOnly = false;
            this.txt_Pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Pago.Depth = 0;
            this.txt_Pago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Pago.HideSelection = true;
            this.txt_Pago.Hint = "Ingrese la cantidad del Pago";
            this.txt_Pago.LeadingIcon = null;
            this.txt_Pago.Location = new System.Drawing.Point(1063, 94);
            this.txt_Pago.MaxLength = 32767;
            this.txt_Pago.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.PasswordChar = '\0';
            this.txt_Pago.PrefixSuffixText = null;
            this.txt_Pago.ReadOnly = false;
            this.txt_Pago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Pago.SelectedText = "";
            this.txt_Pago.SelectionLength = 0;
            this.txt_Pago.SelectionStart = 0;
            this.txt_Pago.ShortcutsEnabled = true;
            this.txt_Pago.Size = new System.Drawing.Size(268, 36);
            this.txt_Pago.TabIndex = 24;
            this.txt_Pago.TabStop = false;
            this.txt_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Pago.TrailingIcon = null;
            this.txt_Pago.UseSystemPasswordChar = false;
            this.txt_Pago.UseTallSize = false;
            // 
            // txt_Nombre_Vendedor
            // 
            this.txt_Nombre_Vendedor.AnimateReadOnly = false;
            this.txt_Nombre_Vendedor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Nombre_Vendedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre_Vendedor.Depth = 0;
            this.txt_Nombre_Vendedor.Enabled = false;
            this.txt_Nombre_Vendedor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Nombre_Vendedor.LeadingIcon = null;
            this.txt_Nombre_Vendedor.Location = new System.Drawing.Point(635, 271);
            this.txt_Nombre_Vendedor.MaxLength = 50;
            this.txt_Nombre_Vendedor.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Nombre_Vendedor.Multiline = false;
            this.txt_Nombre_Vendedor.Name = "txt_Nombre_Vendedor";
            this.txt_Nombre_Vendedor.ReadOnly = true;
            this.txt_Nombre_Vendedor.Size = new System.Drawing.Size(261, 36);
            this.txt_Nombre_Vendedor.TabIndex = 23;
            this.txt_Nombre_Vendedor.Text = "";
            this.txt_Nombre_Vendedor.TrailingIcon = null;
            this.txt_Nombre_Vendedor.UseTallSize = false;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Enabled = false;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "-";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(635, 94);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(261, 36);
            this.materialTextBox1.TabIndex = 22;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // cmb_Metodo_Pago
            // 
            this.cmb_Metodo_Pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Metodo_Pago.AutoResize = false;
            this.cmb_Metodo_Pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Metodo_Pago.Depth = 0;
            this.cmb_Metodo_Pago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Metodo_Pago.DropDownHeight = 118;
            this.cmb_Metodo_Pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Metodo_Pago.DropDownWidth = 121;
            this.cmb_Metodo_Pago.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Metodo_Pago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Metodo_Pago.FormattingEnabled = true;
            this.cmb_Metodo_Pago.Hint = "Seleccione el método a pagar";
            this.cmb_Metodo_Pago.IntegralHeight = false;
            this.cmb_Metodo_Pago.ItemHeight = 29;
            this.cmb_Metodo_Pago.Items.AddRange(new object[] {
            "DÉBITO",
            "CRÉDITO",
            "EFECTIVO"});
            this.cmb_Metodo_Pago.Location = new System.Drawing.Point(635, 213);
            this.cmb_Metodo_Pago.MaxDropDownItems = 4;
            this.cmb_Metodo_Pago.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Metodo_Pago.Name = "cmb_Metodo_Pago";
            this.cmb_Metodo_Pago.Size = new System.Drawing.Size(261, 35);
            this.cmb_Metodo_Pago.StartIndex = 0;
            this.cmb_Metodo_Pago.TabIndex = 21;
            this.cmb_Metodo_Pago.UseTallSize = false;
            // 
            // txt_Telefono_Cliente
            // 
            this.txt_Telefono_Cliente.AnimateReadOnly = false;
            this.txt_Telefono_Cliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Telefono_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefono_Cliente.Depth = 0;
            this.txt_Telefono_Cliente.Enabled = false;
            this.txt_Telefono_Cliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Telefono_Cliente.Hint = "+ ";
            this.txt_Telefono_Cliente.LeadingIcon = null;
            this.txt_Telefono_Cliente.Location = new System.Drawing.Point(141, 271);
            this.txt_Telefono_Cliente.MaxLength = 50;
            this.txt_Telefono_Cliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Telefono_Cliente.Multiline = false;
            this.txt_Telefono_Cliente.Name = "txt_Telefono_Cliente";
            this.txt_Telefono_Cliente.Size = new System.Drawing.Size(242, 36);
            this.txt_Telefono_Cliente.TabIndex = 20;
            this.txt_Telefono_Cliente.Text = "";
            this.txt_Telefono_Cliente.TrailingIcon = null;
            this.txt_Telefono_Cliente.UseTallSize = false;
            // 
            // txt_Nombre_Cliente
            // 
            this.txt_Nombre_Cliente.AnimateReadOnly = false;
            this.txt_Nombre_Cliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Nombre_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre_Cliente.Depth = 0;
            this.txt_Nombre_Cliente.Enabled = false;
            this.txt_Nombre_Cliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Nombre_Cliente.Hint = "-";
            this.txt_Nombre_Cliente.LeadingIcon = null;
            this.txt_Nombre_Cliente.Location = new System.Drawing.Point(141, 212);
            this.txt_Nombre_Cliente.MaxLength = 50;
            this.txt_Nombre_Cliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Nombre_Cliente.Multiline = false;
            this.txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            this.txt_Nombre_Cliente.Size = new System.Drawing.Size(242, 36);
            this.txt_Nombre_Cliente.TabIndex = 19;
            this.txt_Nombre_Cliente.Text = "";
            this.txt_Nombre_Cliente.TrailingIcon = null;
            this.txt_Nombre_Cliente.UseTallSize = false;
            // 
            // txt_Cedula_Encontrada
            // 
            this.txt_Cedula_Encontrada.AnimateReadOnly = false;
            this.txt_Cedula_Encontrada.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Cedula_Encontrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Cedula_Encontrada.Depth = 0;
            this.txt_Cedula_Encontrada.Enabled = false;
            this.txt_Cedula_Encontrada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Cedula_Encontrada.Hint = "00000XXXXX";
            this.txt_Cedula_Encontrada.LeadingIcon = null;
            this.txt_Cedula_Encontrada.Location = new System.Drawing.Point(141, 153);
            this.txt_Cedula_Encontrada.MaxLength = 50;
            this.txt_Cedula_Encontrada.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Cedula_Encontrada.Multiline = false;
            this.txt_Cedula_Encontrada.Name = "txt_Cedula_Encontrada";
            this.txt_Cedula_Encontrada.Size = new System.Drawing.Size(242, 36);
            this.txt_Cedula_Encontrada.TabIndex = 18;
            this.txt_Cedula_Encontrada.Text = "";
            this.txt_Cedula_Encontrada.TrailingIcon = null;
            this.txt_Cedula_Encontrada.UseTallSize = false;
            // 
            // txtCliente_Cedula
            // 
            this.txtCliente_Cedula.AnimateReadOnly = false;
            this.txtCliente_Cedula.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCliente_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente_Cedula.Depth = 0;
            this.txtCliente_Cedula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente_Cedula.Hint = "Ingrese la Cédula del Cliente";
            this.txtCliente_Cedula.LeadingIcon = null;
            this.txtCliente_Cedula.Location = new System.Drawing.Point(141, 94);
            this.txtCliente_Cedula.MaxLength = 50;
            this.txtCliente_Cedula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente_Cedula.Multiline = false;
            this.txtCliente_Cedula.Name = "txtCliente_Cedula";
            this.txtCliente_Cedula.Size = new System.Drawing.Size(242, 36);
            this.txtCliente_Cedula.TabIndex = 17;
            this.txtCliente_Cedula.Text = "";
            this.txtCliente_Cedula.TrailingIcon = null;
            this.txtCliente_Cedula.UseTallSize = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(55, 459);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1276, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 237);
            this.dataGridView1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(921, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "Neto a Pagar:  $";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(921, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Devolver:          $";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(921, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Pagó con:         $";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(405, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre del Encargado:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Método de Pago:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Identificador de Factura:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Facturación:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cliente.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(51, 101);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(71, 22);
            this.lbl_Cliente.TabIndex = 1;
            this.lbl_Cliente.Text = "Cliente:";
            this.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_TOP.TabIndex = 0;
            this.lbl_TOP.Text = "NUEVA FACTURA";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frm_MFactura_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1433, 789);
            this.Controls.Add(this.pn_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1433, 789);
            this.MinimumSize = new System.Drawing.Size(1433, 789);
            this.Name = "Frm_MFactura_Registro";
            this.Text = "Frm_MFactura";
            this.pn_Fondo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Fondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox txt_Telefono_Cliente;
        private MaterialSkin.Controls.MaterialTextBox txt_Nombre_Cliente;
        private MaterialSkin.Controls.MaterialTextBox txt_Cedula_Encontrada;
        private MaterialSkin.Controls.MaterialTextBox txt_Nombre_Vendedor;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox cmb_Metodo_Pago;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Pago;
        private MaterialSkin.Controls.MaterialTextBox txtCliente_Cedula;
        private Gradient_Label_Bounds lbl_Total_a_Pagar;
        private Gradient_Label_Bounds lbl_Vuelto;
        private MaterialSkin.Controls.MaterialButton btn_Clean;
        private MaterialSkin.Controls.MaterialButton btn_Print;
        private MaterialSkin.Controls.MaterialButton btn_Registrar;
        private User_Controls.RJButton btn_Cerrar_Ventana;
        private System.Windows.Forms.PictureBox pcb_Line;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_Fecha;
    }
}