namespace PalcoNet
{
    partial class SelectorFuncionalidadForm
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
            this.boxFuncionalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.linkCambioPass = new System.Windows.Forms.LinkLabel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxFuncionalidad
            // 
            this.boxFuncionalidad.FormattingEnabled = true;
            this.boxFuncionalidad.Location = new System.Drawing.Point(39, 129);
            this.boxFuncionalidad.Name = "boxFuncionalidad";
            this.boxFuncionalidad.Size = new System.Drawing.Size(204, 21);
            this.boxFuncionalidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la funcionalidad a utilizar";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(168, 190);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // linkCambioPass
            // 
            this.linkCambioPass.AutoSize = true;
            this.linkCambioPass.Location = new System.Drawing.Point(152, 21);
            this.linkCambioPass.Name = "linkCambioPass";
            this.linkCambioPass.Size = new System.Drawing.Size(120, 13);
            this.linkCambioPass.TabIndex = 3;
            this.linkCambioPass.TabStop = true;
            this.linkCambioPass.Text = "Quiero cambiar mi clave";
            this.linkCambioPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCambioPass_LinkClicked);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(24, 21);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "label2";
            // 
            // SelectorFuncionalidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.linkCambioPass);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxFuncionalidad);
            this.Name = "SelectorFuncionalidadForm";
            this.Text = "SelectorFuncionalidadForm";
            this.Load += new System.EventHandler(this.SelectorFuncionalidadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxFuncionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.LinkLabel linkCambioPass;
        private System.Windows.Forms.Label lblNombreUsuario;
    }
}