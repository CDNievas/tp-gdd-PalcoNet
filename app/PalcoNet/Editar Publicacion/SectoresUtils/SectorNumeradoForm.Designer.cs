namespace PalcoNet.Editar_Publicacion.SectoresUtils
{
    partial class SectorNumeradoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFilaDesde = new System.Windows.Forms.TextBox();
            this.txtFilaHasta = new System.Windows.Forms.TextBox();
            this.asientoDesde = new System.Windows.Forms.NumericUpDown();
            this.asientoHasta = new System.Windows.Forms.NumericUpDown();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.comboTipoUbicacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.asientoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo de Ubicación";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(261, 248);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(65, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFilaDesde
            // 
            this.txtFilaDesde.Location = new System.Drawing.Point(132, 81);
            this.txtFilaDesde.Name = "txtFilaDesde";
            this.txtFilaDesde.Size = new System.Drawing.Size(58, 20);
            this.txtFilaDesde.TabIndex = 10;
            // 
            // txtFilaHasta
            // 
            this.txtFilaHasta.Location = new System.Drawing.Point(230, 81);
            this.txtFilaHasta.Name = "txtFilaHasta";
            this.txtFilaHasta.Size = new System.Drawing.Size(58, 20);
            this.txtFilaHasta.TabIndex = 10;
            // 
            // asientoDesde
            // 
            this.asientoDesde.Location = new System.Drawing.Point(132, 107);
            this.asientoDesde.Name = "asientoDesde";
            this.asientoDesde.Size = new System.Drawing.Size(58, 20);
            this.asientoDesde.TabIndex = 11;
            // 
            // asientoHasta
            // 
            this.asientoHasta.Location = new System.Drawing.Point(230, 107);
            this.asientoHasta.Name = "asientoHasta";
            this.asientoHasta.Size = new System.Drawing.Size(58, 20);
            this.asientoHasta.TabIndex = 11;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(154, 168);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 20);
            this.precio.TabIndex = 12;
            // 
            // comboTipoUbicacion
            // 
            this.comboTipoUbicacion.FormattingEnabled = true;
            this.comboTipoUbicacion.Location = new System.Drawing.Point(154, 206);
            this.comboTipoUbicacion.Name = "comboTipoUbicacion";
            this.comboTipoUbicacion.Size = new System.Drawing.Size(121, 21);
            this.comboTipoUbicacion.TabIndex = 13;
            // 
            // SectorNumeradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.Controls.Add(this.comboTipoUbicacion);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.asientoHasta);
            this.Controls.Add(this.asientoDesde);
            this.Controls.Add(this.txtFilaHasta);
            this.Controls.Add(this.txtFilaDesde);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SectorNumeradoForm";
            this.Text = "SectorNumeradoForm";
            ((System.ComponentModel.ISupportInitialize)(this.asientoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asientoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilaDesde;
        private System.Windows.Forms.TextBox txtFilaHasta;
        private System.Windows.Forms.NumericUpDown asientoDesde;
        private System.Windows.Forms.NumericUpDown asientoHasta;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.ComboBox comboTipoUbicacion;
    }
}