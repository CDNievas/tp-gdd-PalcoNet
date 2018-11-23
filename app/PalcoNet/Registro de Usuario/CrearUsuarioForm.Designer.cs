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
            this.btnClienteLimpiar.Location = new System.Drawing.Point(22, 284);
            this.btnClienteLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnClienteLimpiar.TabIndex = 32;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = true;
            this.btnClienteLimpiar.Click += new System.EventHandler(this.btnClienteLimpiar_Click);
            // 
            // btnClienteCrear
            // 
            this.btnClienteCrear.Location = new System.Drawing.Point(278, 284);
            this.btnClienteCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteCrear.Name = "btnClienteCrear";
            this.btnClienteCrear.Size = new System.Drawing.Size(66, 24);
            this.btnClienteCrear.TabIndex = 31;
            this.btnClienteCrear.Text = "Crear";
            this.btnClienteCrear.UseVisualStyleBackColor = true;
            this.btnClienteCrear.Click += new System.EventHandler(this.btnClienteCrear_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 13);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 95);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblConfPassword
            // 
            this.lblConfPassword.AutoSize = true;
            this.lblConfPassword.Location = new System.Drawing.Point(20, 141);
            this.lblConfPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfPassword.Name = "lblConfPassword";
            this.lblConfPassword.Size = new System.Drawing.Size(110, 13);
            this.lblConfPassword.TabIndex = 35;
            this.lblConfPassword.Text = "Confirmar contrasena:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 48);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 20);
            this.txtUsuario.TabIndex = 36;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(96, 95);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(120, 20);
            this.password.TabIndex = 37;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(134, 139);
            this.txtConfirmarContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.PasswordChar = '*';
            this.txtConfirmarContra.Size = new System.Drawing.Size(120, 20);
            this.txtConfirmarContra.TabIndex = 38;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 183);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo:";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "empresa",
            "cliente"});
            this.comboTipo.Location = new System.Drawing.Point(96, 183);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(193, 21);
            this.comboTipo.TabIndex = 40;
            // 
            // btnAgregarInfo
            // 
            this.btnAgregarInfo.Location = new System.Drawing.Point(22, 226);
            this.btnAgregarInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarInfo.Name = "btnAgregarInfo";
            this.btnAgregarInfo.Size = new System.Drawing.Size(130, 19);
            this.btnAgregarInfo.TabIndex = 41;
            this.btnAgregarInfo.Text = "Agregar info especifica";
            this.btnAgregarInfo.UseVisualStyleBackColor = true;
            this.btnAgregarInfo.Click += new System.EventHandler(this.btnAgregarInfo_Click);
            // 
            // btnDisponible
            // 
            this.btnDisponible.Location = new System.Drawing.Point(232, 48);
            this.btnDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisponible.Name = "btnDisponible";
            this.btnDisponible.Size = new System.Drawing.Size(76, 19);
            this.btnDisponible.TabIndex = 42;
            this.btnDisponible.Text = "Disponible";
            this.btnDisponible.UseVisualStyleBackColor = true;
            this.btnDisponible.Click += new System.EventHandler(this.btnDisponible_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(320, 52);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(38, 13);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "SI/NO";
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuario.Location = new System.Drawing.Point(18, 7);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(158, 25);
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
            this.shapeContainer1.Size = new System.Drawing.Size(366, 327);
            this.shapeContainer1.TabIndex = 45;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(13, 27);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(459, 301);
            // 
            // CrearUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 327);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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