namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class bajaEmpresa
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
            this.btnEmpresaLimpiar = new System.Windows.Forms.Button();
            this.btnEmpresaBorrar = new System.Windows.Forms.Button();
            this.txtEmpresaCuit = new System.Windows.Forms.TextBox();
            this.txtEmpresaRS = new System.Windows.Forms.TextBox();
            this.lblEmpresaCUIT = new System.Windows.Forms.Label();
            this.lblEmpresaRS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresaID = new System.Windows.Forms.TextBox();
            this.lblEmpresaID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpresaLimpiar
            // 
            this.btnEmpresaLimpiar.Location = new System.Drawing.Point(308, 241);
            this.btnEmpresaLimpiar.Name = "btnEmpresaLimpiar";
            this.btnEmpresaLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnEmpresaLimpiar.TabIndex = 17;
            this.btnEmpresaLimpiar.Text = "Limpiar";
            this.btnEmpresaLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEmpresaBorrar
            // 
            this.btnEmpresaBorrar.Location = new System.Drawing.Point(420, 241);
            this.btnEmpresaBorrar.Name = "btnEmpresaBorrar";
            this.btnEmpresaBorrar.Size = new System.Drawing.Size(88, 30);
            this.btnEmpresaBorrar.TabIndex = 16;
            this.btnEmpresaBorrar.Text = "Borrar";
            this.btnEmpresaBorrar.UseVisualStyleBackColor = true;
            // 
            // txtEmpresaCuit
            // 
            this.txtEmpresaCuit.Location = new System.Drawing.Point(173, 137);
            this.txtEmpresaCuit.Name = "txtEmpresaCuit";
            this.txtEmpresaCuit.Size = new System.Drawing.Size(124, 22);
            this.txtEmpresaCuit.TabIndex = 21;
            // 
            // txtEmpresaRS
            // 
            this.txtEmpresaRS.Location = new System.Drawing.Point(173, 103);
            this.txtEmpresaRS.Name = "txtEmpresaRS";
            this.txtEmpresaRS.Size = new System.Drawing.Size(124, 22);
            this.txtEmpresaRS.TabIndex = 20;
            // 
            // lblEmpresaCUIT
            // 
            this.lblEmpresaCUIT.AutoSize = true;
            this.lblEmpresaCUIT.Location = new System.Drawing.Point(72, 137);
            this.lblEmpresaCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaCUIT.Name = "lblEmpresaCUIT";
            this.lblEmpresaCUIT.Size = new System.Drawing.Size(36, 17);
            this.lblEmpresaCUIT.TabIndex = 19;
            this.lblEmpresaCUIT.Text = "Cuit:";
            // 
            // lblEmpresaRS
            // 
            this.lblEmpresaRS.AutoSize = true;
            this.lblEmpresaRS.Location = new System.Drawing.Point(72, 103);
            this.lblEmpresaRS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaRS.Name = "lblEmpresaRS";
            this.lblEmpresaRS.Size = new System.Drawing.Size(97, 17);
            this.lblEmpresaRS.TabIndex = 18;
            this.lblEmpresaRS.Text = "Razón social: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Baja empresa";
            // 
            // txtEmpresaID
            // 
            this.txtEmpresaID.Location = new System.Drawing.Point(173, 72);
            this.txtEmpresaID.Name = "txtEmpresaID";
            this.txtEmpresaID.Size = new System.Drawing.Size(124, 22);
            this.txtEmpresaID.TabIndex = 24;
            // 
            // lblEmpresaID
            // 
            this.lblEmpresaID.AutoSize = true;
            this.lblEmpresaID.Location = new System.Drawing.Point(72, 72);
            this.lblEmpresaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresaID.Name = "lblEmpresaID";
            this.lblEmpresaID.Size = new System.Drawing.Size(89, 17);
            this.lblEmpresaID.TabIndex = 23;
            this.lblEmpresaID.Text = "Empresa ID: ";
            // 
            // bajaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 295);
            this.Controls.Add(this.txtEmpresaID);
            this.Controls.Add(this.lblEmpresaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpresaCuit);
            this.Controls.Add(this.txtEmpresaRS);
            this.Controls.Add(this.lblEmpresaCUIT);
            this.Controls.Add(this.lblEmpresaRS);
            this.Controls.Add(this.btnEmpresaLimpiar);
            this.Controls.Add(this.btnEmpresaBorrar);
            this.Name = "bajaEmpresa";
            this.Text = "Baja de Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpresaLimpiar;
        private System.Windows.Forms.Button btnEmpresaBorrar;
        private System.Windows.Forms.TextBox txtEmpresaCuit;
        private System.Windows.Forms.TextBox txtEmpresaRS;
        private System.Windows.Forms.Label lblEmpresaCUIT;
        private System.Windows.Forms.Label lblEmpresaRS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresaID;
        private System.Windows.Forms.Label lblEmpresaID;
    }
}