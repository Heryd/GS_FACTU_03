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
            this.materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Fecha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pcb_Line = new System.Windows.Forms.PictureBox();
            this.btn_Clean = new MaterialSkin.Controls.MaterialButton();
            this.btn_Print = new MaterialSkin.Controls.MaterialButton();
            this.btn_Registrar = new MaterialSkin.Controls.MaterialButton();
            this.txt_Pago = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Nombre_Vendedor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.cmb_Metodo_Pago = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_Telefono_Cliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Nombre_Cliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Cedula_Encontrada = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCliente_Cedula = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgV_Factura = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Pago_Factura = new System.Windows.Forms.Label();
            this.lbl_Vuelto_Factura = new System.Windows.Forms.Label();
            this.lbl_Pago_Factura = new System.Windows.Forms.Label();
            this.lbl_Nombre_Encargado = new System.Windows.Forms.Label();
            this.lbl_Metodo_Pago = new System.Windows.Forms.Label();
            this.lbl_ID_Factura = new System.Windows.Forms.Label();
            this.lbl_Fecha_Factura = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_TOP = new System.Windows.Forms.Label();
            this.btn_Cerrar_Ventana = new Capa_Presentacion.User_Controls.RJButton();
            this.pn_Fondo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Factura)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Fondo
            // 
            this.pn_Fondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Fondo.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.pn_Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Fondo.Controls.Add(this.panel1);
            this.pn_Fondo.Location = new System.Drawing.Point(0, 0);
            this.pn_Fondo.Name = "pn_Fondo";
            this.pn_Fondo.Size = new System.Drawing.Size(1433, 789);
            this.pn_Fondo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.materialTextBox22);
            this.panel1.Controls.Add(this.materialTextBox21);
            this.panel1.Controls.Add(this.txt_Fecha);
            this.panel1.Controls.Add(this.pcb_Line);
            this.panel1.Controls.Add(this.btn_Cerrar_Ventana);
            this.panel1.Controls.Add(this.btn_Clean);
            this.panel1.Controls.Add(this.btn_Print);
            this.panel1.Controls.Add(this.btn_Registrar);
            this.panel1.Controls.Add(this.txt_Pago);
            this.panel1.Controls.Add(this.txt_Nombre_Vendedor);
            this.panel1.Controls.Add(this.materialTextBox1);
            this.panel1.Controls.Add(this.cmb_Metodo_Pago);
            this.panel1.Controls.Add(this.txt_Telefono_Cliente);
            this.panel1.Controls.Add(this.txt_Nombre_Cliente);
            this.panel1.Controls.Add(this.txt_Cedula_Encontrada);
            this.panel1.Controls.Add(this.txtCliente_Cedula);
            this.panel1.Controls.Add(this.dtgV_Factura);
            this.panel1.Controls.Add(this.lbl_Total_Pago_Factura);
            this.panel1.Controls.Add(this.lbl_Vuelto_Factura);
            this.panel1.Controls.Add(this.lbl_Pago_Factura);
            this.panel1.Controls.Add(this.lbl_Nombre_Encargado);
            this.panel1.Controls.Add(this.lbl_Metodo_Pago);
            this.panel1.Controls.Add(this.lbl_ID_Factura);
            this.panel1.Controls.Add(this.lbl_Fecha_Factura);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Controls.Add(this.lbl_Cedula);
            this.panel1.Controls.Add(this.lbl_Cliente);
            this.panel1.Controls.Add(this.lbl_TOP);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.MinimumSize = new System.Drawing.Size(1375, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 720);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialTextBox22
            // 
            this.materialTextBox22.AnimateReadOnly = false;
            this.materialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox22.Depth = 0;
            this.materialTextBox22.Enabled = false;
            this.materialTextBox22.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox22.HideSelection = true;
            this.materialTextBox22.LeadingIcon = global::Capa_Presentacion.Properties.Resources.dollar_green;
            this.materialTextBox22.Location = new System.Drawing.Point(1063, 212);
            this.materialTextBox22.MaxLength = 32767;
            this.materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox22.Name = "materialTextBox22";
            this.materialTextBox22.PasswordChar = '\0';
            this.materialTextBox22.PrefixSuffixText = null;
            this.materialTextBox22.ReadOnly = false;
            this.materialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox22.SelectedText = "";
            this.materialTextBox22.SelectionLength = 0;
            this.materialTextBox22.SelectionStart = 0;
            this.materialTextBox22.ShortcutsEnabled = true;
            this.materialTextBox22.Size = new System.Drawing.Size(268, 36);
            this.materialTextBox22.TabIndex = 36;
            this.materialTextBox22.TabStop = false;
            this.materialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox22.TrailingIcon = null;
            this.materialTextBox22.UseSystemPasswordChar = false;
            this.materialTextBox22.UseTallSize = false;
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Enabled = false;
            this.materialTextBox21.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = global::Capa_Presentacion.Properties.Resources.dollar_yellow__Custom_;
            this.materialTextBox21.Location = new System.Drawing.Point(1063, 153);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(268, 36);
            this.materialTextBox21.TabIndex = 35;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            this.materialTextBox21.UseTallSize = false;
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
            this.btn_Registrar.Icon = global::Capa_Presentacion.Properties.Resources.cash_out_svgrepo_com__Custom_;
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
            // txt_Pago
            // 
            this.txt_Pago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pago.AnimateReadOnly = false;
            this.txt_Pago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Pago.Depth = 0;
            this.txt_Pago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Pago.HideSelection = true;
            this.txt_Pago.Hint = "Ingrese la cantidad del Pago";
            this.txt_Pago.LeadingIcon = global::Capa_Presentacion.Properties.Resources.dollar_blue;
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
            // dtgV_Factura
            // 
            this.dtgV_Factura.AllowUserToAddRows = false;
            this.dtgV_Factura.AllowUserToDeleteRows = false;
            this.dtgV_Factura.AllowUserToResizeColumns = false;
            this.dtgV_Factura.AllowUserToResizeRows = false;
            this.dtgV_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgV_Factura.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgV_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgV_Factura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgV_Factura.Location = new System.Drawing.Point(55, 459);
            this.dtgV_Factura.MaximumSize = new System.Drawing.Size(1276, 237);
            this.dtgV_Factura.Name = "dtgV_Factura";
            this.dtgV_Factura.RowHeadersWidth = 62;
            this.dtgV_Factura.RowTemplate.Height = 28;
            this.dtgV_Factura.Size = new System.Drawing.Size(1276, 237);
            this.dtgV_Factura.TabIndex = 15;
            // 
            // lbl_Total_Pago_Factura
            // 
            this.lbl_Total_Pago_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total_Pago_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total_Pago_Factura.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Pago_Factura.Location = new System.Drawing.Point(921, 216);
            this.lbl_Total_Pago_Factura.Name = "lbl_Total_Pago_Factura";
            this.lbl_Total_Pago_Factura.Size = new System.Drawing.Size(136, 29);
            this.lbl_Total_Pago_Factura.TabIndex = 11;
            this.lbl_Total_Pago_Factura.Text = "Neto a Pagar:";
            this.lbl_Total_Pago_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Vuelto_Factura
            // 
            this.lbl_Vuelto_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Vuelto_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vuelto_Factura.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vuelto_Factura.Location = new System.Drawing.Point(921, 157);
            this.lbl_Vuelto_Factura.Name = "lbl_Vuelto_Factura";
            this.lbl_Vuelto_Factura.Size = new System.Drawing.Size(136, 29);
            this.lbl_Vuelto_Factura.TabIndex = 10;
            this.lbl_Vuelto_Factura.Text = "Devolver:";
            this.lbl_Vuelto_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Pago_Factura
            // 
            this.lbl_Pago_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pago_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pago_Factura.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pago_Factura.Location = new System.Drawing.Point(921, 98);
            this.lbl_Pago_Factura.Name = "lbl_Pago_Factura";
            this.lbl_Pago_Factura.Size = new System.Drawing.Size(136, 29);
            this.lbl_Pago_Factura.TabIndex = 9;
            this.lbl_Pago_Factura.Text = "Pagó con:";
            this.lbl_Pago_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Nombre_Encargado
            // 
            this.lbl_Nombre_Encargado.AutoSize = true;
            this.lbl_Nombre_Encargado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre_Encargado.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Encargado.Location = new System.Drawing.Point(405, 278);
            this.lbl_Nombre_Encargado.Name = "lbl_Nombre_Encargado";
            this.lbl_Nombre_Encargado.Size = new System.Drawing.Size(196, 22);
            this.lbl_Nombre_Encargado.TabIndex = 8;
            this.lbl_Nombre_Encargado.Text = "Nombre del Encargado:";
            this.lbl_Nombre_Encargado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Metodo_Pago
            // 
            this.lbl_Metodo_Pago.AutoSize = true;
            this.lbl_Metodo_Pago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Metodo_Pago.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Metodo_Pago.Location = new System.Drawing.Point(405, 219);
            this.lbl_Metodo_Pago.Name = "lbl_Metodo_Pago";
            this.lbl_Metodo_Pago.Size = new System.Drawing.Size(143, 22);
            this.lbl_Metodo_Pago.TabIndex = 7;
            this.lbl_Metodo_Pago.Text = "Método de Pago:";
            this.lbl_Metodo_Pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ID_Factura
            // 
            this.lbl_ID_Factura.AutoSize = true;
            this.lbl_ID_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID_Factura.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Factura.Location = new System.Drawing.Point(405, 101);
            this.lbl_ID_Factura.Name = "lbl_ID_Factura";
            this.lbl_ID_Factura.Size = new System.Drawing.Size(205, 22);
            this.lbl_ID_Factura.TabIndex = 6;
            this.lbl_ID_Factura.Text = "Identificador de Factura:";
            this.lbl_ID_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha_Factura
            // 
            this.lbl_Fecha_Factura.AutoSize = true;
            this.lbl_Fecha_Factura.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha_Factura.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_Factura.Location = new System.Drawing.Point(405, 160);
            this.lbl_Fecha_Factura.Name = "lbl_Fecha_Factura";
            this.lbl_Fecha_Factura.Size = new System.Drawing.Size(188, 22);
            this.lbl_Fecha_Factura.TabIndex = 5;
            this.lbl_Fecha_Factura.Text = "Fecha de Facturación:";
            this.lbl_Fecha_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Telefono.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(51, 278);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(82, 22);
            this.lbl_Telefono.TabIndex = 4;
            this.lbl_Telefono.Text = "Teléfono:";
            this.lbl_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nombre.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(51, 219);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(78, 22);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre:";
            this.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cedula.Font = new System.Drawing.Font("IOS 15 SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(51, 160);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(71, 22);
            this.lbl_Cedula.TabIndex = 2;
            this.lbl_Cedula.Text = "Cédula:";
            this.lbl_Cedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgV_Factura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Fondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TOP;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_Vuelto_Factura;
        private System.Windows.Forms.Label lbl_Pago_Factura;
        private System.Windows.Forms.Label lbl_Nombre_Encargado;
        private System.Windows.Forms.Label lbl_Metodo_Pago;
        private System.Windows.Forms.Label lbl_ID_Factura;
        private System.Windows.Forms.Label lbl_Fecha_Factura;
        private System.Windows.Forms.Label lbl_Total_Pago_Factura;
        private System.Windows.Forms.DataGridView dtgV_Factura;
        private MaterialSkin.Controls.MaterialTextBox txt_Telefono_Cliente;
        private MaterialSkin.Controls.MaterialTextBox txt_Nombre_Cliente;
        private MaterialSkin.Controls.MaterialTextBox txt_Cedula_Encontrada;
        private MaterialSkin.Controls.MaterialTextBox txt_Nombre_Vendedor;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox cmb_Metodo_Pago;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Pago;
        private MaterialSkin.Controls.MaterialTextBox txtCliente_Cedula;
        private MaterialSkin.Controls.MaterialButton btn_Clean;
        private MaterialSkin.Controls.MaterialButton btn_Print;
        private MaterialSkin.Controls.MaterialButton btn_Registrar;
        private User_Controls.RJButton btn_Cerrar_Ventana;
        private System.Windows.Forms.PictureBox pcb_Line;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_Fecha;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
    }
}