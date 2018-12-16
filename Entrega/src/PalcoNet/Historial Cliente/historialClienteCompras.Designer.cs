namespace PalcoNet.Historial_Cliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.btnUbicaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Historial Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.Location = new System.Drawing.Point(35, 414);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(107, 23);
            this.btnPagAnterior.TabIndex = 4;
            this.btnPagAnterior.Text = "Página Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = true;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Location = new System.Drawing.Point(454, 414);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(102, 23);
            this.btnPagSiguiente.TabIndex = 5;
            this.btnPagSiguiente.Text = "Página Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = true;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.Location = new System.Drawing.Point(214, 414);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(162, 23);
            this.btnUbicaciones.TabIndex = 28;
            this.btnUbicaciones.Text = "Ver ubicaciones compradas";
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // historialClienteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 449);
            this.Controls.Add(this.btnUbicaciones);
            this.Controls.Add(this.btnPagSiguiente);
            this.Controls.Add(this.btnPagAnterior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "historialClienteCompras";
            this.Text = "historial cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Button btnUbicaciones;
    }
}