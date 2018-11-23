namespace PalcoNet
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btnIngresarLogIn = new System.Windows.Forms.Button();
            this.btnLimpiarLogIn = new System.Windows.Forms.Button();
            this.crearUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(44, 70);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(111, 20);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(44, 154);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(111, 20);
            this.password.TabIndex = 3;
            // 
            // btnIngresarLogIn
            // 
            this.btnIngresarLogIn.Location = new System.Drawing.Point(116, 197);
            this.btnIngresarLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresarLogIn.Name = "btnIngresarLogIn";
            this.btnIngresarLogIn.Size = new System.Drawing.Size(78, 19);
            this.btnIngresarLogIn.TabIndex = 4;
            this.btnIngresarLogIn.Text = "INGRESAR";
            this.btnIngresarLogIn.UseVisualStyleBackColor = true;
            this.btnIngresarLogIn.Click += new System.EventHandler(this.btnIngresarLogIn_Click);
            // 
            // btnLimpiarLogIn
            // 
            this.btnLimpiarLogIn.Location = new System.Drawing.Point(16, 197);
            this.btnLimpiarLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarLogIn.Name = "btnLimpiarLogIn";
            this.btnLimpiarLogIn.Size = new System.Drawing.Size(78, 19);
            this.btnLimpiarLogIn.TabIndex = 5;
            this.btnLimpiarLogIn.Text = "LIMPIAR";
            this.btnLimpiarLogIn.UseVisualStyleBackColor = true;
            this.btnLimpiarLogIn.Click += new System.EventHandler(this.btnLimpiarLogIn_Click);
            // 
            // crearUsuario
            // 
            this.crearUsuario.Location = new System.Drawing.Point(175, 20);
            this.crearUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.crearUsuario.Name = "crearUsuario";
            this.crearUsuario.Size = new System.Drawing.Size(78, 25);
            this.crearUsuario.TabIndex = 6;
            this.crearUsuario.Text = "Crear Usuario";
            this.crearUsuario.UseVisualStyleBackColor = true;
            this.crearUsuario.Click += new System.EventHandler(this.crearUsuario_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 241);
            this.Controls.Add(this.crearUsuario);
            this.Controls.Add(this.btnLimpiarLogIn);
            this.Controls.Add(this.btnIngresarLogIn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.logIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnIngresarLogIn;
        private System.Windows.Forms.Button btnLimpiarLogIn;
        private System.Windows.Forms.Button crearUsuario;
    }
}

