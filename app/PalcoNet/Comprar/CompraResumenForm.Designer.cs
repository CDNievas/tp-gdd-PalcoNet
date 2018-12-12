namespace PalcoNet.Comprar
{
    partial class CompraResumenForm
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
            this.ubicacionesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNombreEspectaculo = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblUbicacionEspectaculo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUltimosDigitosTarjeta = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resúmen de su compra";
            // 
            // ubicacionesDataGrid
            // 
            this.ubicacionesDataGrid.AllowUserToAddRows = false;
            this.ubicacionesDataGrid.AllowUserToDeleteRows = false;
            this.ubicacionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ubicacionesDataGrid.Location = new System.Drawing.Point(27, 164);
            this.ubicacionesDataGrid.Name = "ubicacionesDataGrid";
            this.ubicacionesDataGrid.ReadOnly = true;
            this.ubicacionesDataGrid.Size = new System.Drawing.Size(536, 163);
            this.ubicacionesDataGrid.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(422, 472);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(124, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Confirmar compra";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(39, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medio de Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(277, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 20);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "lblTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Espectáculo:";
            // 
            // lblNombreEspectaculo
            // 
            this.lblNombreEspectaculo.AutoSize = true;
            this.lblNombreEspectaculo.Location = new System.Drawing.Point(27, 75);
            this.lblNombreEspectaculo.Name = "lblNombreEspectaculo";
            this.lblNombreEspectaculo.Size = new System.Drawing.Size(54, 13);
            this.lblNombreEspectaculo.TabIndex = 16;
            this.lblNombreEspectaculo.Text = "NOMBRE";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(364, 75);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(86, 13);
            this.lblFechaHora.TabIndex = 17;
            this.lblFechaHora.Text = "FECHA Y HORA";
            // 
            // lblUbicacionEspectaculo
            // 
            this.lblUbicacionEspectaculo.AutoSize = true;
            this.lblUbicacionEspectaculo.Location = new System.Drawing.Point(27, 106);
            this.lblUbicacionEspectaculo.Name = "lblUbicacionEspectaculo";
            this.lblUbicacionEspectaculo.Size = new System.Drawing.Size(65, 13);
            this.lblUbicacionEspectaculo.TabIndex = 18;
            this.lblUbicacionEspectaculo.Text = "UBICACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tarjeta:";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(186, 378);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(83, 13);
            this.lblTipoTarjeta.TabIndex = 20;
            this.lblTipoTarjeta.Text = "TIPO TARJETA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Finaliza con:";
            // 
            // lblUltimosDigitosTarjeta
            // 
            this.lblUltimosDigitosTarjeta.AutoSize = true;
            this.lblUltimosDigitosTarjeta.Location = new System.Drawing.Point(189, 414);
            this.lblUltimosDigitosTarjeta.Name = "lblUltimosDigitosTarjeta";
            this.lblUltimosDigitosTarjeta.Size = new System.Drawing.Size(25, 13);
            this.lblUltimosDigitosTarjeta.TabIndex = 22;
            this.lblUltimosDigitosTarjeta.Text = "489";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPuntos.Location = new System.Drawing.Point(136, 477);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(267, 13);
            this.lblPuntos.TabIndex = 23;
            this.lblPuntos.Text = "Con esta compra usted sumaría 12332 puntos";
            // 
            // CompraResumenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 516);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblUltimosDigitosTarjeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUbicacionEspectaculo);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblNombreEspectaculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.ubicacionesDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "CompraResumenForm";
            this.Text = "CompraResumenForm";
            this.Load += new System.EventHandler(this.CompraResumenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ubicacionesDataGrid;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreEspectaculo;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblUbicacionEspectaculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUltimosDigitosTarjeta;
        private System.Windows.Forms.Label lblPuntos;
    }
}