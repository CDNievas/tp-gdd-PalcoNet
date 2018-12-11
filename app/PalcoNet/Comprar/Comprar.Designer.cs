namespace PalcoNet.Comprar
{
    partial class Comprar
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
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.txtPublicacion = new System.Windows.Forms.TextBox();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RangoFechas = new System.Windows.Forms.Label();
            this.nombrePublicacion = new System.Windows.Forms.Label();
            this.btnElegirUbicacion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComprasLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPagPrimera = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.lblCategorias);
            this.Filtros.Controls.Add(this.label6);
            this.Filtros.Controls.Add(this.btnCategoria);
            this.Filtros.Controls.Add(this.label4);
            this.Filtros.Controls.Add(this.label3);
            this.Filtros.Controls.Add(this.dateHasta);
            this.Filtros.Controls.Add(this.txtPublicacion);
            this.Filtros.Controls.Add(this.dateDesde);
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.RangoFechas);
            this.Filtros.Controls.Add(this.nombrePublicacion);
            this.Filtros.Location = new System.Drawing.Point(16, 57);
            this.Filtros.Margin = new System.Windows.Forms.Padding(4);
            this.Filtros.Name = "Filtros";
            this.Filtros.Padding = new System.Windows.Forms.Padding(4);
            this.Filtros.Size = new System.Drawing.Size(763, 147);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategorias.Location = new System.Drawing.Point(180, 104);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.MaximumSize = new System.Drawing.Size(1180, 28);
            this.lblCategorias.MinimumSize = new System.Drawing.Size(448, 28);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(448, 28);
            this.lblCategorias.TabIndex = 38;
            this.lblCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Categoria/s elegidas:";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(133, 67);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(286, 28);
            this.btnCategoria.TabIndex = 27;
            this.btnCategoria.Text = "Elegir categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHasta.Location = new System.Drawing.Point(610, 73);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(132, 22);
            this.dateHasta.TabIndex = 8;
            // 
            // txtPublicacion
            // 
            this.txtPublicacion.Location = new System.Drawing.Point(108, 36);
            this.txtPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublicacion.Name = "txtPublicacion";
            this.txtPublicacion.Size = new System.Drawing.Size(311, 22);
            this.txtPublicacion.TabIndex = 4;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDesde.Location = new System.Drawing.Point(610, 36);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(132, 22);
            this.dateDesde.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria/s:";
            // 
            // RangoFechas
            // 
            this.RangoFechas.AutoSize = true;
            this.RangoFechas.Location = new System.Drawing.Point(551, 13);
            this.RangoFechas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RangoFechas.Name = "RangoFechas";
            this.RangoFechas.Size = new System.Drawing.Size(124, 17);
            this.RangoFechas.TabIndex = 1;
            this.RangoFechas.Text = "Rango de Fechas:";
            // 
            // nombrePublicacion
            // 
            this.nombrePublicacion.AutoSize = true;
            this.nombrePublicacion.Location = new System.Drawing.Point(38, 39);
            this.nombrePublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrePublicacion.Name = "nombrePublicacion";
            this.nombrePublicacion.Size = new System.Drawing.Size(62, 17);
            this.nombrePublicacion.TabIndex = 0;
            this.nombrePublicacion.Text = "Nombre:";
            // 
            // btnElegirUbicacion
            // 
            this.btnElegirUbicacion.Location = new System.Drawing.Point(164, 208);
            this.btnElegirUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnElegirUbicacion.Name = "btnElegirUbicacion";
            this.btnElegirUbicacion.Size = new System.Drawing.Size(286, 23);
            this.btnElegirUbicacion.TabIndex = 37;
            this.btnElegirUbicacion.Text = "tipo de ubicación";
            this.btnElegirUbicacion.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de ubicación";
            // 
            // btnComprasLimpiar
            // 
            this.btnComprasLimpiar.Location = new System.Drawing.Point(525, 191);
            this.btnComprasLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprasLimpiar.Name = "btnComprasLimpiar";
            this.btnComprasLimpiar.Size = new System.Drawing.Size(119, 28);
            this.btnComprasLimpiar.TabIndex = 7;
            this.btnComprasLimpiar.Text = "Limpiar Filtros";
            this.btnComprasLimpiar.UseVisualStyleBackColor = true;
            this.btnComprasLimpiar.Click += new System.EventHandler(this.btnComprasLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(652, 191);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprar Ubicaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 528);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Location = new System.Drawing.Point(13, 528);
            this.btnPaginaAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnPaginaAnterior.TabIndex = 5;
            this.btnPaginaAnterior.Text = "Anterior";
            this.btnPaginaAnterior.UseVisualStyleBackColor = true;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // btnPagPrimera
            // 
            this.btnPagPrimera.Location = new System.Drawing.Point(556, 537);
            this.btnPagPrimera.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagPrimera.Name = "btnPagPrimera";
            this.btnPagPrimera.Size = new System.Drawing.Size(100, 28);
            this.btnPagPrimera.TabIndex = 6;
            this.btnPagPrimera.Text = "Primera";
            this.btnPagPrimera.UseVisualStyleBackColor = true;
            this.btnPagPrimera.Click += new System.EventHandler(this.btnPagPrimera_Click);
            // 
            // btnPagUltima
            // 
            this.btnPagUltima.Location = new System.Drawing.Point(676, 537);
            this.btnPagUltima.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(100, 28);
            this.btnPagUltima.TabIndex = 7;
            this.btnPagUltima.Text = "Ultima";
            this.btnPagUltima.UseVisualStyleBackColor = true;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 275);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 245);
            this.dataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = " ubicación";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Elegir ubicación";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 596);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnComprasLimpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnElegirUbicacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPagUltima);
            this.Controls.Add(this.btnPagPrimera);
            this.Controls.Add(this.btnPaginaAnterior);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.Label nombrePublicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RangoFechas;
        private System.Windows.Forms.DateTimePicker dateDesde;        // ADAPTAR ESTO A LAS CATEGORIAS POSIBLES
        private System.Windows.Forms.TextBox txtPublicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComprasLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPagPrimera;
        private System.Windows.Forms.Button btnPagUltima;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnElegirUbicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label label6;
    }
}