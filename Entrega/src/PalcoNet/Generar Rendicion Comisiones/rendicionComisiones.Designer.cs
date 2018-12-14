namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class GenerarRendiciones
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
            this.groupBoxRendirComisiones = new System.Windows.Forms.GroupBox();
            this.dataGridViewRendirComisiones = new System.Windows.Forms.DataGridView();
            this.facturaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rendir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxRendirComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendirComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRendirComisiones
            // 
            this.groupBoxRendirComisiones.Controls.Add(this.dataGridViewRendirComisiones);
            this.groupBoxRendirComisiones.Location = new System.Drawing.Point(48, 27);
            this.groupBoxRendirComisiones.Name = "groupBoxRendirComisiones";
            this.groupBoxRendirComisiones.Size = new System.Drawing.Size(822, 512);
            this.groupBoxRendirComisiones.TabIndex = 0;
            this.groupBoxRendirComisiones.TabStop = false;
            this.groupBoxRendirComisiones.Text = "Rendicion de Comisiones";
            // 
            // dataGridViewRendirComisiones
            // 
            this.dataGridViewRendirComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendirComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaNumero,
            this.Localidades,
            this.FechaCompra,
            this.Total,
            this.Cliente,
            this.Comision,
            this.Rendir});
            this.dataGridViewRendirComisiones.Location = new System.Drawing.Point(29, 23);
            this.dataGridViewRendirComisiones.Name = "dataGridViewRendirComisiones";
            this.dataGridViewRendirComisiones.Size = new System.Drawing.Size(774, 483);
            this.dataGridViewRendirComisiones.TabIndex = 0;
            this.dataGridViewRendirComisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // facturaNumero
            // 
            this.facturaNumero.HeaderText = "Numero Factura";
            this.facturaNumero.Name = "facturaNumero";
            // 
            // Localidades
            // 
            this.Localidades.HeaderText = "Cantidad Localidades";
            this.Localidades.Name = "Localidades";
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "Fecha de Compra";
            this.FechaCompra.Name = "FechaCompra";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Comision
            // 
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // Rendir
            // 
            this.Rendir.HeaderText = "Rendir Comision";
            this.Rendir.Name = "Rendir";
            // 
            // rendicionComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 574);
            this.Controls.Add(this.groupBoxRendirComisiones);
            this.Name = "rendicionComisiones";
            this.Text = "Generar rendicion comisiones";
            this.Load += new System.EventHandler(this.GenerarRendiciones_Load);
            this.groupBoxRendirComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendirComisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRendirComisiones;
        private System.Windows.Forms.DataGridView dataGridViewRendirComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewButtonColumn Rendir;
    }
}