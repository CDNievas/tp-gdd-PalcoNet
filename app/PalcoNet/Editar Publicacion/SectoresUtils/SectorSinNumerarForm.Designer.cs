namespace PalcoNet.Editar_Publicacion.SectoresUtils
{
    partial class SectorSinNumerarForm
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboTipoUbicacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(47, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboTipoUbicacion
            // 
            this.comboTipoUbicacion.FormattingEnabled = true;
            this.comboTipoUbicacion.Location = new System.Drawing.Point(128, 78);
            this.comboTipoUbicacion.Name = "comboTipoUbicacion";
            this.comboTipoUbicacion.Size = new System.Drawing.Size(121, 21);
            this.comboTipoUbicacion.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Ubicación";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(128, 119);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 20);
            this.precio.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Precio";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(129, 164);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 20);
            this.cantidad.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad";
            // 
            // SectorSinNumerarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipoUbicacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "SectorSinNumerarForm";
            this.Text = "SectorSinNumerarForm";
            this.Load += new System.EventHandler(this.SectorSinNumerarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboTipoUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label label1;
    }
}