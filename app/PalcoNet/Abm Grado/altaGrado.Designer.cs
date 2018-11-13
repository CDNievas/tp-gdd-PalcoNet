namespace PalcoNet.Abm_Grado
{
    partial class altaGrado
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
            this.lblDescripcionGrado = new System.Windows.Forms.Label();
            this.txtDescripcionGrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numComisionGrado = new System.Windows.Forms.NumericUpDown();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numComisionGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcionGrado
            // 
            this.lblDescripcionGrado.AutoSize = true;
            this.lblDescripcionGrado.Location = new System.Drawing.Point(21, 149);
            this.lblDescripcionGrado.Name = "lblDescripcionGrado";
            this.lblDescripcionGrado.Size = new System.Drawing.Size(127, 17);
            this.lblDescripcionGrado.TabIndex = 1;
            this.lblDescripcionGrado.Text = "Descripcion grado:";
            // 
            // txtDescripcionGrado
            // 
            this.txtDescripcionGrado.Location = new System.Drawing.Point(154, 149);
            this.txtDescripcionGrado.Multiline = true;
            this.txtDescripcionGrado.Name = "txtDescripcionGrado";
            this.txtDescripcionGrado.Size = new System.Drawing.Size(236, 107);
            this.txtDescripcionGrado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crear Grado";
            // 
            // numComisionGrado
            // 
            this.numComisionGrado.Location = new System.Drawing.Point(154, 86);
            this.numComisionGrado.Name = "numComisionGrado";
            this.numComisionGrado.Size = new System.Drawing.Size(120, 22);
            this.numComisionGrado.TabIndex = 4;
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(21, 86);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(108, 17);
            this.lblComisionGrado.TabIndex = 5;
            this.lblComisionGrado.Text = "comision grado:";
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(334, 304);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 17;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGradoGuardar
            // 
            this.btnGradoGuardar.Location = new System.Drawing.Point(446, 304);
            this.btnGradoGuardar.Name = "btnGradoGuardar";
            this.btnGradoGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoGuardar.TabIndex = 16;
            this.btnGradoGuardar.Text = "Guardar";
            this.btnGradoGuardar.UseVisualStyleBackColor = true;
            // 
            // altaGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 362);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoGuardar);
            this.Controls.Add(this.lblComisionGrado);
            this.Controls.Add(this.numComisionGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionGrado);
            this.Controls.Add(this.lblDescripcionGrado);
            this.Name = "altaGrado";
            this.Text = "Crear Grado";
            ((System.ComponentModel.ISupportInitialize)(this.numComisionGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionGrado;
        private System.Windows.Forms.TextBox txtDescripcionGrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numComisionGrado;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoGuardar;
    }
}