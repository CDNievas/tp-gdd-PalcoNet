﻿namespace PalcoNet.Historial_Cliente
{
    partial class historialClienteCompras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espectaculoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCompra,
            this.FechaDeCompra,
            this.CantidadAdquirida,
            this.espectaculoDescripcion,
            this.TarjetaId});
            this.dataGridView1.Location = new System.Drawing.Point(27, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // NroCompra
            // 
            this.NroCompra.HeaderText = "NroCompra";
            this.NroCompra.Name = "NroCompra";
            // 
            // FechaDeCompra
            // 
            this.FechaDeCompra.HeaderText = "FechaDeCompra";
            this.FechaDeCompra.Name = "FechaDeCompra";
            this.FechaDeCompra.Width = 130;
            // 
            // CantidadAdquirida
            // 
            this.CantidadAdquirida.HeaderText = "CantidadAdquirida";
            this.CantidadAdquirida.Name = "CantidadAdquirida";
            this.CantidadAdquirida.Width = 130;
            // 
            // espectaculoDescripcion
            // 
            this.espectaculoDescripcion.HeaderText = "EspectaculoDescripcion";
            this.espectaculoDescripcion.Name = "espectaculoDescripcion";
            this.espectaculoDescripcion.Width = 180;
            // 
            // TarjetaId
            // 
            this.TarjetaId.HeaderText = "TarjetaId";
            this.TarjetaId.Name = "TarjetaId";
            this.TarjetaId.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Historial Cliente";
            // 
            // historialClienteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "historialClienteCompras";
            this.Text = "historial cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn espectaculoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaId;
        private System.Windows.Forms.Label label2;
    }
}