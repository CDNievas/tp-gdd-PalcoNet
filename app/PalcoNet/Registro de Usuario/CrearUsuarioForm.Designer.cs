namespace PalcoNet.Registro_de_Usuario
{
    partial class CrearUsuarioForm
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
            this.btnClienteLimpiar = new System.Windows.Forms.Button();
            this.btnClienteCrear = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregarInfo = new System.Windows.Forms.Button();
            this.btnDisponible = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // btnClienteLimpiar
            // 
            this.btnClienteLimpiar.Location = new System.Drawing.Point(29, 350);
            this.btnClienteLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnClienteLimpiar.TabIndex = 32;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = true;
            this.btnClienteLimpiar.Click += new System.EventHandler(this.btnClienteLimpiar_Click);
            // 
            // btnClienteCrear
            // 
            this.btnClienteCrear.Location = new System.Drawing.Point(371, 350);
            this.btnClienteCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteCrear.Name = "btnClienteCrear";
            this.btnClienteCrear.Size = new System.Drawing.Size(88, 30);
            this.btnClienteCrear.TabIndex = 31;
            this.btnClienteCrear.Text = "Crear";
            this.btnClienteCrear.UseVisualStyleBackColor = true;
            this.btnClienteCrear.Click += new System.EventHandler(this.btnClienteCrear_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 17);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 17);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Location = new System.Drawing.Point(27, 174);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(148, 17);
            this.lblConfPassword.TabIndex = 35;
            this.lblConfPassword.Text = "Confirmar contrasena:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(128, 59);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 22);
            this.txtUsuario.TabIndex = 36;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(128, 117);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(159, 22);
            this.password.TabIndex = 37;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(179, 171);
            this.txtConfirmarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.PasswordChar = '*';
            this.txtConfirmarContra.Size = new System.Drawing.Size(159, 22);
            this.txtConfirmarContra.TabIndex = 38;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(27, 225);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo:";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "empresa",
            "cliente"});
            this.comboTipo.Location = new System.Drawing.Point(128, 225);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(256, 24);
            this.comboTipo.TabIndex = 40;
            // 
            // btnAgregarInfo
            // 
            this.btnAgregarInfo.Location = new System.Drawing.Point(29, 278);
            this.btnAgregarInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarInfo.Name = "btnAgregarInfo";
            this.btnAgregarInfo.Size = new System.Drawing.Size(173, 23);
            this.btnAgregarInfo.TabIndex = 41;
            this.btnAgregarInfo.Text = "Agregar info especifica";
            this.btnAgregarInfo.UseVisualStyleBackColor = true;
            this.btnAgregarInfo.Click += new System.EventHandler(this.btnAgregarInfo_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.Location = new System.Drawing.Point(309, 59);
            this.btnDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(101, 23);
            this.btnDisponible.TabIndex = 42;
            this.btnDisponible.Text = "Disponible?";
            this.btnDisponible.UseVisualStyleBackColor = true;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(427, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(12, 17);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = " ";
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuario.Location = new System.Drawing.Point(24, 9);
            this.lblCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(196, 31);
            this.lblCrearUsuario.TabIndex = 44;
            this.lblCrearUsuario.Text = "Crear Usuario";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(594, 436);
            this.shapeContainer1.TabIndex = 45;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(13, 27);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(426, 301);
            // 
            // CrearUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 436);
            this.Controls.Add(this.lblCrearUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnDisponible);
            this.Controls.Add(this.btnAgregarInfo);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtConfirmarContra);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblConfPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnClienteLimpiar);
            this.Controls.Add(this.btnClienteCrear);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearUsuarioForm";
            this.Text = "crearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienteLimpiar;
        private System.Windows.Forms.Button btnClienteCrear;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button btnAgregarInfo;
        private System.Windows.Forms.Button btnDisponible;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCrearUsuario;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}