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
            this.btnPagPrimera = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.txtUltimaPag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPagActual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnPagAnterior.Location = new System.Drawing.Point(101, 414);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(107, 23);
            this.btnPagAnterior.TabIndex = 4;
            this.btnPagAnterior.Text = "Página Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = true;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Location = new System.Drawing.Point(385, 414);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(102, 23);
            this.btnPagSiguiente.TabIndex = 5;
            this.btnPagSiguiente.Text = "Página Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = true;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.Location = new System.Drawing.Point(214, 407);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(156, 37);
            this.btnUbicaciones.TabIndex = 28;
            this.btnUbicaciones.Text = "Ver ubicaciones compradas";
            this.btnUbicaciones.UseVisualStyleBackColor = true;
            this.btnUbicaciones.Click += new System.EventHandler(this.btnUbicaciones_Click);
            // 
            // btnPagPrimera
            // 
            this.btnPagPrimera.Location = new System.Drawing.Point(12, 414);
            this.btnPagPrimera.Name = "btnPagPrimera";
            this.btnPagPrimera.Size = new System.Drawing.Size(75, 23);
            this.btnPagPrimera.TabIndex = 29;
            this.btnPagPrimera.Text = "Primera";
            this.btnPagPrimera.UseVisualStyleBackColor = true;
            this.btnPagPrimera.Click += new System.EventHandler(this.btnPagPrimera_Click);
            // 
            // btnPagUltima
            // 
            this.btnPagUltima.Location = new System.Drawing.Point(493, 414);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(75, 23);
            this.btnPagUltima.TabIndex = 30;
            this.btnPagUltima.Text = "Ultima";
            this.btnPagUltima.UseVisualStyleBackColor = true;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // txtUltimaPag
            // 
            this.txtUltimaPag.AutoSize = true;
            this.txtUltimaPag.Location = new System.Drawing.Point(322, 455);
            this.txtUltimaPag.Name = "txtUltimaPag";
            this.txtUltimaPag.Size = new System.Drawing.Size(17, 13);
            this.txtUltimaPag.TabIndex = 48;
            this.txtUltimaPag.Text = "yy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "de";
            // 
            // txtPagActual
            // 
            this.txtPagActual.AutoSize = true;
            this.txtPagActual.Location = new System.Drawing.Point(272, 455);
            this.txtPagActual.Name = "txtPagActual";
            this.txtPagActual.Size = new System.Drawing.Size(17, 13);
            this.txtPagActual.TabIndex = 46;
            this.txtPagActual.Text = "xx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Página";
            // 
            // historialClienteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 483);
            this.Controls.Add(this.txtUltimaPag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPagActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPagUltima);
            this.Controls.Add(this.btnPagPrimera);
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
        private System.Windows.Forms.Button btnPagPrimera;
        private System.Windows.Forms.Button btnPagUltima;
        private System.Windows.Forms.Label txtUltimaPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtPagActual;
        private System.Windows.Forms.Label label5;
    }
}