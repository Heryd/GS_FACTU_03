namespace Capa_Presentacion.Modulos._1._Factura
{
    partial class Frm_MModificar_Factura
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.divider = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Id_Factura = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.pcb_Line = new System.Windows.Forms.PictureBox();
            this.lbl_TOP = new System.Windows.Forms.Label();
            this.btn_Cancelar = new MaterialSkin.Controls.MaterialButton();
            this.btn_Confirm_Update = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.switch_Estado = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_servicio = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.lbl_Fecha_Creacion = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Fecha_Modificacion = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BackgroundImage = global::Capa_Presentacion.Properties.Resources.CENTER__1_;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.divider);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.pcb_Line);
            this.panelContainer.Controls.Add(this.lbl_TOP);
            this.panelContainer.Controls.Add(this.btn_Cancelar);
            this.panelContainer.Controls.Add(this.btn_Confirm_Update);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(677, 808);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divider.Depth = 0;
            this.divider.Location = new System.Drawing.Point(22, 105);
            this.divider.MouseState = MaterialSkin.MouseState.HOVER;
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(621, 10);
            this.divider.TabIndex = 1;
            this.divider.Text = "materialDivider1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(2, 0);
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialSwitch1);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.materialTextBox3);
            this.panel1.Controls.Add(this.materialTextBox2);
            this.panel1.Controls.Add(this.lbl_Fecha_Modificacion);
            this.panel1.Controls.Add(this.lbl_Fecha_Creacion);
            this.panel1.Controls.Add(this.txt_servicio);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.switch_Estado);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialMaskedTextBox1);
            this.panel1.Controls.Add(this.materialTextBox1);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.lbl_Id_Factura);
            this.panel1.Controls.Add(this.lbl_ID);
            this.panel1.Location = new System.Drawing.Point(23, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 564);
            this.panel1.TabIndex = 35;
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HelperText = "Día / Mes / Año";
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.Hint = "DD/MM/YYYY";
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = global::Capa_Presentacion.Properties.Resources.calendar_blue;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(190, 329);
            this.materialMaskedTextBox1.Mask = "00/00/0000";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.ShowAssistiveText = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(270, 52);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 6;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "  /  /";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.UseTallSize = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Nombre del encargado";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(190, 251);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(270, 36);
            this.materialTextBox1.TabIndex = 5;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(30, 317);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(108, 52);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Fecha de Facturación";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(29, 407);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 24);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Encargado:";
            // 
            // lbl_Id_Factura
            // 
            this.lbl_Id_Factura.Depth = 0;
            this.lbl_Id_Factura.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Id_Factura.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Id_Factura.HighEmphasis = true;
            this.lbl_Id_Factura.Location = new System.Drawing.Point(193, 26);
            this.lbl_Id_Factura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Id_Factura.Name = "lbl_Id_Factura";
            this.lbl_Id_Factura.Size = new System.Drawing.Size(270, 29);
            this.lbl_Id_Factura.TabIndex = 1;
            this.lbl_Id_Factura.Text = "000000001";
            this.lbl_Id_Factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_ID.Location = new System.Drawing.Point(30, 26);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 29);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // pcb_Line
            // 
            this.pcb_Line.Image = global::Capa_Presentacion.Properties.Resources.Line_21;
            this.pcb_Line.Location = new System.Drawing.Point(34, 46);
            this.pcb_Line.Name = "pcb_Line";
            this.pcb_Line.Size = new System.Drawing.Size(10, 45);
            this.pcb_Line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Line.TabIndex = 34;
            this.pcb_Line.TabStop = false;
            // 
            // lbl_TOP
            // 
            this.lbl_TOP.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TOP.Font = new System.Drawing.Font("Koodak", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_TOP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_TOP.Location = new System.Drawing.Point(22, 32);
            this.lbl_TOP.Name = "lbl_TOP";
            this.lbl_TOP.Padding = new System.Windows.Forms.Padding(35, 5, 0, 0);
            this.lbl_TOP.Size = new System.Drawing.Size(621, 83);
            this.lbl_TOP.TabIndex = 3;
            this.lbl_TOP.Text = "ACTUALIZAR FACTURA";
            this.lbl_TOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Cancelar.Depth = 0;
            this.btn_Cancelar.HighEmphasis = true;
            this.btn_Cancelar.Icon = null;
            this.btn_Cancelar.Location = new System.Drawing.Point(556, 723);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Cancelar.UseAccentColor = true;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirm_Update
            // 
            this.btn_Confirm_Update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Confirm_Update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Confirm_Update.Depth = 0;
            this.btn_Confirm_Update.HighEmphasis = true;
            this.btn_Confirm_Update.Icon = null;
            this.btn_Confirm_Update.Location = new System.Drawing.Point(434, 723);
            this.btn_Confirm_Update.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Confirm_Update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Confirm_Update.Name = "btn_Confirm_Update";
            this.btn_Confirm_Update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Confirm_Update.Size = new System.Drawing.Size(105, 36);
            this.btn_Confirm_Update.TabIndex = 1;
            this.btn_Confirm_Update.Text = "CONFIRMAR";
            this.btn_Confirm_Update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Confirm_Update.UseAccentColor = false;
            this.btn_Confirm_Update.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(30, 465);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(87, 24);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Producto:";
            // 
            // switch_Estado
            // 
            this.switch_Estado.AutoSize = true;
            this.switch_Estado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switch_Estado.Depth = 0;
            this.switch_Estado.Location = new System.Drawing.Point(247, 401);
            this.switch_Estado.Margin = new System.Windows.Forms.Padding(0);
            this.switch_Estado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_Estado.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_Estado.Name = "switch_Estado";
            this.switch_Estado.Ripple = true;
            this.switch_Estado.Size = new System.Drawing.Size(129, 37);
            this.switch_Estado.TabIndex = 9;
            this.switch_Estado.Text = "Eliminada";
            this.switch_Estado.UseCompatibleTextRendering = true;
            this.switch_Estado.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(188, 410);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Pagada";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(29, 405);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(67, 24);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Estado:";
            // 
            // txt_servicio
            // 
            this.txt_servicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_servicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_servicio.Depth = 0;
            this.txt_servicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_servicio.Hint = "Ingrese el detelle del servicio facturado";
            this.txt_servicio.Location = new System.Drawing.Point(193, 463);
            this.txt_servicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_servicio.Name = "txt_servicio";
            this.txt_servicio.Size = new System.Drawing.Size(270, 111);
            this.txt_servicio.TabIndex = 12;
            this.txt_servicio.Text = "";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "Producto";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // lbl_Fecha_Creacion
            // 
            this.lbl_Fecha_Creacion.Depth = 0;
            this.lbl_Fecha_Creacion.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Fecha_Creacion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Fecha_Creacion.Location = new System.Drawing.Point(31, 87);
            this.lbl_Fecha_Creacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Fecha_Creacion.Name = "lbl_Fecha_Creacion";
            this.lbl_Fecha_Creacion.Size = new System.Drawing.Size(117, 49);
            this.lbl_Fecha_Creacion.TabIndex = 13;
            this.lbl_Fecha_Creacion.Text = "Creada: ";
            this.lbl_Fecha_Creacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha_Modificacion
            // 
            this.lbl_Fecha_Modificacion.Depth = 0;
            this.lbl_Fecha_Modificacion.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Fecha_Modificacion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Fecha_Modificacion.Location = new System.Drawing.Point(30, 166);
            this.lbl_Fecha_Modificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Fecha_Modificacion.Name = "lbl_Fecha_Modificacion";
            this.lbl_Fecha_Modificacion.Size = new System.Drawing.Size(117, 49);
            this.lbl_Fecha_Modificacion.TabIndex = 14;
            this.lbl_Fecha_Modificacion.Text = "Ult. Modificación:";
            this.lbl_Fecha_Modificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Enabled = false;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Nunca";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(190, 172);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(270, 36);
            this.materialTextBox2.TabIndex = 15;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseTallSize = false;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Enabled = false;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(193, 93);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(270, 36);
            this.materialTextBox3.TabIndex = 16;
            this.materialTextBox3.Text = "12/02/2002";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.UseTallSize = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 61);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(572, 3);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(30, 602);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(86, 24);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Cantidad:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(29, 667);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 24);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Estado:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(188, 672);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(130, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Mantener IVA 12%";
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialSwitch1.Location = new System.Drawing.Point(318, 663);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(178, 37);
            this.materialSwitch1.TabIndex = 22;
            this.materialSwitch1.Text = "Eliminar IVA 12%";
            this.materialSwitch1.UseCompatibleTextRendering = true;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.numericUpDown1.Font = new System.Drawing.Font("IOS 15 Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(193, 597);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(270, 34);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_MModificar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(677, 789);
            this.Controls.Add(this.panelContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MModificar_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MModificar_Factura";
            this.Activated += new System.EventHandler(this.Frm_MModificar_Factura_Activated);
            this.ResizeEnd += new System.EventHandler(this.Frm_MModificar_Factura_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Frm_MModificar_Factura_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_MModificar_Factura_Paint);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private MaterialSkin.Controls.MaterialButton btn_Confirm_Update;
        private MaterialSkin.Controls.MaterialButton btn_Cancelar;
        private System.Windows.Forms.Label lbl_TOP;
        private System.Windows.Forms.PictureBox pcb_Line;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialDivider divider;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lbl_Id_Factura;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSwitch switch_Estado;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txt_servicio;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialLabel lbl_Fecha_Creacion;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel lbl_Fecha_Modificacion;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}