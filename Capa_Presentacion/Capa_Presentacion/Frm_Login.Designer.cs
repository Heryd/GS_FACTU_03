namespace Capa_Presentacion
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_Login = new Capa_Presentacion.User_Controls.RJButton();
            this.pcb_eye_close = new System.Windows.Forms.PictureBox();
            this.pcb_eye_open = new System.Windows.Forms.PictureBox();
            this.txt_password = new Capa_Presentacion.User_Controls.TextBox_Control();
            this.txt_user = new Capa_Presentacion.User_Controls.TextBox_Control();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Subtitle_Login = new System.Windows.Forms.Label();
            this.lbl_Titulo_Login = new System.Windows.Forms.Label();
            this.TOP = new System.Windows.Forms.Panel();
            this.lbl_Min_Form = new System.Windows.Forms.Label();
            this.lbl_Close_Form = new System.Windows.Forms.Label();
            this.txt_Encabezado_Proyecto = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eye_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eye_open)).BeginInit();
            this.TOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.btn_Login);
            this.panelContainer.Controls.Add(this.pcb_eye_close);
            this.panelContainer.Controls.Add(this.pcb_eye_open);
            this.panelContainer.Controls.Add(this.txt_password);
            this.panelContainer.Controls.Add(this.txt_user);
            this.panelContainer.Controls.Add(this.lbl_Password);
            this.panelContainer.Controls.Add(this.lbl_User);
            this.panelContainer.Controls.Add(this.lbl_Subtitle_Login);
            this.panelContainer.Controls.Add(this.lbl_Titulo_Login);
            this.panelContainer.Controls.Add(this.TOP);
            this.panelContainer.Controls.Add(this.txt_Encabezado_Proyecto);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(640, 685);
            this.panelContainer.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(11)))));
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 6;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(34, 542);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(573, 58);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "INICIAR SESION";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pcb_eye_close
            // 
            this.pcb_eye_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_eye_close.Image = ((System.Drawing.Image)(resources.GetObject("pcb_eye_close.Image")));
            this.pcb_eye_close.Location = new System.Drawing.Point(146, 418);
            this.pcb_eye_close.Name = "pcb_eye_close";
            this.pcb_eye_close.Size = new System.Drawing.Size(30, 30);
            this.pcb_eye_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_eye_close.TabIndex = 10;
            this.pcb_eye_close.TabStop = false;
            this.pcb_eye_close.Click += new System.EventHandler(this.pcb_eye_close_Click);
            // 
            // pcb_eye_open
            // 
            this.pcb_eye_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_eye_open.Image = ((System.Drawing.Image)(resources.GetObject("pcb_eye_open.Image")));
            this.pcb_eye_open.Location = new System.Drawing.Point(146, 418);
            this.pcb_eye_open.Name = "pcb_eye_open";
            this.pcb_eye_open.Size = new System.Drawing.Size(30, 30);
            this.pcb_eye_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_eye_open.TabIndex = 9;
            this.pcb_eye_open.TabStop = false;
            this.pcb_eye_open.Click += new System.EventHandler(this.pcb_eye_open_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_password.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(11)))));
            this.txt_password.BorderRadius = 5;
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_password.Location = new System.Drawing.Point(34, 457);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = true;
            this.txt_password.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_password.PlaceholderText = "Ingresa tu contraseña";
            this.txt_password.Size = new System.Drawing.Size(573, 39);
            this.txt_password.TabIndex = 7;
            this.txt_password.TabStop = false;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = false;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.White;
            this.txt_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txt_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_user.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(181)))), ((int)(((byte)(11)))));
            this.txt_user.BorderRadius = 5;
            this.txt_user.BorderSize = 2;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_user.Location = new System.Drawing.Point(34, 340);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            this.txt_user.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_user.PasswordChar = false;
            this.txt_user.PlaceholderColor = System.Drawing.Color.Silver;
            this.txt_user.PlaceholderText = "Ingresa tu usuario";
            this.txt_user.Size = new System.Drawing.Size(573, 39);
            this.txt_user.TabIndex = 6;
            this.txt_user.TabStop = false;
            this.txt_user.Texts = "";
            this.txt_user.UnderlinedStyle = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lbl_Password.Location = new System.Drawing.Point(30, 422);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(113, 22);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Contraseña";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lbl_User.Location = new System.Drawing.Point(30, 304);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(146, 22);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "Usuario / Email";
            // 
            // lbl_Subtitle_Login
            // 
            this.lbl_Subtitle_Login.AutoSize = true;
            this.lbl_Subtitle_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lbl_Subtitle_Login.Location = new System.Drawing.Point(144, 236);
            this.lbl_Subtitle_Login.Name = "lbl_Subtitle_Login";
            this.lbl_Subtitle_Login.Size = new System.Drawing.Size(352, 20);
            this.lbl_Subtitle_Login.TabIndex = 3;
            this.lbl_Subtitle_Login.Text = "Ingrese las credenciales para acceder al sistema";
            // 
            // lbl_Titulo_Login
            // 
            this.lbl_Titulo_Login.AutoSize = true;
            this.lbl_Titulo_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo_Login.Location = new System.Drawing.Point(281, 198);
            this.lbl_Titulo_Login.Name = "lbl_Titulo_Login";
            this.lbl_Titulo_Login.Size = new System.Drawing.Size(78, 25);
            this.lbl_Titulo_Login.TabIndex = 2;
            this.lbl_Titulo_Login.Text = "LOGIN";
            // 
            // TOP
            // 
            this.TOP.Controls.Add(this.lbl_Min_Form);
            this.TOP.Controls.Add(this.lbl_Close_Form);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.Location = new System.Drawing.Point(0, 0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(640, 46);
            this.TOP.TabIndex = 1;
            // 
            // lbl_Min_Form
            // 
            this.lbl_Min_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Min_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Min_Form.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Min_Form.Location = new System.Drawing.Point(531, 0);
            this.lbl_Min_Form.Name = "lbl_Min_Form";
            this.lbl_Min_Form.Size = new System.Drawing.Size(51, 46);
            this.lbl_Min_Form.TabIndex = 3;
            this.lbl_Min_Form.Text = "---";
            this.lbl_Min_Form.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_Min_Form.Click += new System.EventHandler(this.lbl_Min_Form_Click);
            // 
            // lbl_Close_Form
            // 
            this.lbl_Close_Form.BackColor = System.Drawing.Color.White;
            this.lbl_Close_Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Close_Form.Font = new System.Drawing.Font("IOS 15 Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close_Form.Location = new System.Drawing.Point(589, 0);
            this.lbl_Close_Form.Name = "lbl_Close_Form";
            this.lbl_Close_Form.Size = new System.Drawing.Size(51, 46);
            this.lbl_Close_Form.TabIndex = 2;
            this.lbl_Close_Form.Text = "X";
            this.lbl_Close_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Close_Form.Click += new System.EventHandler(this.lbl_Close_Form_Click);
            this.lbl_Close_Form.MouseLeave += new System.EventHandler(this.lbl_Close_Form_MouseLeave);
            this.lbl_Close_Form.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Close_Form_MouseMove);
            // 
            // txt_Encabezado_Proyecto
            // 
            this.txt_Encabezado_Proyecto.BackColor = System.Drawing.Color.White;
            this.txt_Encabezado_Proyecto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Encabezado_Proyecto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Encabezado_Proyecto.Font = new System.Drawing.Font("Lilita One", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Encabezado_Proyecto.Location = new System.Drawing.Point(66, 104);
            this.txt_Encabezado_Proyecto.Name = "txt_Encabezado_Proyecto";
            this.txt_Encabezado_Proyecto.ReadOnly = true;
            this.txt_Encabezado_Proyecto.Size = new System.Drawing.Size(508, 46);
            this.txt_Encabezado_Proyecto.TabIndex = 0;
            this.txt_Encabezado_Proyecto.TabStop = false;
            this.txt_Encabezado_Proyecto.Text = "SISTEMA DE FACTURACION";
            this.txt_Encabezado_Proyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Encabezado_Proyecto.WordWrap = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 685);
            this.Controls.Add(this.panelContainer);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Frm_Login_Activated);
            this.ResizeEnd += new System.EventHandler(this.Frm_Login_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Frm_Login_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_Login_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Login_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eye_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eye_open)).EndInit();
            this.TOP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox txt_Encabezado_Proyecto;
        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.Label lbl_Close_Form;
        private System.Windows.Forms.Label lbl_Min_Form;
        private System.Windows.Forms.Label lbl_Subtitle_Login;
        private System.Windows.Forms.Label lbl_Titulo_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
        private User_Controls.TextBox_Control txt_password;
        private User_Controls.TextBox_Control txt_user;
        private System.Windows.Forms.PictureBox pcb_eye_open;
        private System.Windows.Forms.PictureBox pcb_eye_close;
        private User_Controls.RJButton btn_Login;
    }
}

