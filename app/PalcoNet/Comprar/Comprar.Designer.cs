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
            this.checkFecha = new System.Windows.Forms.CheckBox();
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPagPrimera = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnElegirUbicaciones = new System.Windows.Forms.Button();
            this.Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.checkFecha);
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
            this.Filtros.Location = new System.Drawing.Point(12, 46);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(706, 119);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // checkFecha
            // 
            this.checkFecha.AutoSize = true;
            this.checkFecha.Location = new System.Drawing.Point(583, 33);
            this.checkFecha.Name = "checkFecha";
            this.checkFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkFecha.Size = new System.Drawing.Size(99, 17);
            this.checkFecha.TabIndex = 39;
            this.checkFecha.Text = "Filtrar por fecha";
            this.checkFecha.UseVisualStyleBackColor = true;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategorias.Location = new System.Drawing.Point(141, 84);
            this.lblCategorias.MaximumSize = new System.Drawing.Size(885, 23);
            this.lblCategorias.MinimumSize = new System.Drawing.Size(336, 23);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(336, 23);
            this.lblCategorias.TabIndex = 38;
            this.lblCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Categoria/s elegidas:";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(100, 54);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(214, 23);
            this.btnCategoria.TabIndex = 27;
            this.btnCategoria.Text = "Elegir categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHasta.Location = new System.Drawing.Point(582, 87);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(100, 20);
            this.dateHasta.TabIndex = 8;
            // 
            // txtPublicacion
            // 
            this.txtPublicacion.Location = new System.Drawing.Point(81, 29);
            this.txtPublicacion.Name = "txtPublicacion";
            this.txtPublicacion.Size = new System.Drawing.Size(234, 20);
            this.txtPublicacion.TabIndex = 4;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDesde.Location = new System.Drawing.Point(582, 56);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(100, 20);
            this.dateDesde.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria/s:";
            // 
            // RangoFechas
            // 
            this.RangoFechas.AutoSize = true;
            this.RangoFechas.Location = new System.Drawing.Point(482, 32);
            this.RangoFechas.Name = "RangoFechas";
            this.RangoFechas.Size = new System.Drawing.Size(95, 13);
            this.RangoFechas.TabIndex = 1;
            this.RangoFechas.Text = "Rango de Fechas:";
            // 
            // nombrePublicacion
            // 
            this.nombrePublicacion.AutoSize = true;
            this.nombrePublicacion.Location = new System.Drawing.Point(28, 32);
            this.nombrePublicacion.Name = "nombrePublicacion";
            this.nombrePublicacion.Size = new System.Drawing.Size(47, 13);
            this.nombrePublicacion.TabIndex = 0;
            this.nombrePublicacion.Text = "Nombre:";
            // 
            // btnElegirUbicacion
            // 
            this.btnElegirUbicacion.Location = new System.Drawing.Point(123, 169);
            this.btnElegirUbicacion.Name = "btnElegirUbicacion";
            this.btnElegirUbicacion.Size = new System.Drawing.Size(214, 19);
            this.btnElegirUbicacion.TabIndex = 37;
            this.btnElegirUbicacion.Text = "tipo de ubicación";
            this.btnElegirUbicacion.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de ubicación";
            // 
            // btnComprasLimpiar
            // 
            this.btnComprasLimpiar.Location = new System.Drawing.Point(724, 108);
            this.btnComprasLimpiar.Name = "btnComprasLimpiar";
            this.btnComprasLimpiar.Size = new System.Drawing.Size(89, 23);
            this.btnComprasLimpiar.TabIndex = 7;
            this.btnComprasLimpiar.Text = "Limpiar Filtros";
            this.btnComprasLimpiar.UseVisualStyleBackColor = true;
            this.btnComprasLimpiar.Click += new System.EventHandler(this.btnComprasLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(724, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprar Ubicaciones";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(466, 613);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Location = new System.Drawing.Point(360, 613);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnPaginaAnterior.TabIndex = 5;
            this.btnPaginaAnterior.Text = "Anterior";
            this.btnPaginaAnterior.UseVisualStyleBackColor = true;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // btnPagPrimera
            // 
            this.btnPagPrimera.Location = new System.Drawing.Point(30, 613);
            this.btnPagPrimera.Name = "btnPagPrimera";
            this.btnPagPrimera.Size = new System.Drawing.Size(75, 23);
            this.btnPagPrimera.TabIndex = 6;
            this.btnPagPrimera.Text = "Primera";
            this.btnPagPrimera.UseVisualStyleBackColor = true;
            this.btnPagPrimera.Click += new System.EventHandler(this.btnPagPrimera_Click);
            // 
            // btnPagUltima
            // 
            this.btnPagUltima.Location = new System.Drawing.Point(815, 613);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(75, 23);
            this.btnPagUltima.TabIndex = 7;
            this.btnPagUltima.Text = "Ultima";
            this.btnPagUltima.UseVisualStyleBackColor = true;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(864, 370);
            this.dataGridView1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = " ubicación";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 19);
            this.button2.TabIndex = 39;
            this.button2.Text = "Elegir ubicación";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnElegirUbicaciones
            // 
            this.btnElegirUbicaciones.Location = new System.Drawing.Point(880, 245);
            this.btnElegirUbicaciones.Name = "btnElegirUbicaciones";
            this.btnElegirUbicaciones.Size = new System.Drawing.Size(75, 53);
            this.btnElegirUbicaciones.TabIndex = 40;
            this.btnElegirUbicaciones.Text = "Elegir ubicaciones";
            this.btnElegirUbicaciones.UseVisualStyleBackColor = true;
            this.btnElegirUbicaciones.Click += new System.EventHandler(this.btnElegirUbicaciones_Click);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 648);
            this.Controls.Add(this.btnElegirUbicaciones);
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
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filtros);
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
        private System.Windows.Forms.Button btnSiguiente;
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
        private System.Windows.Forms.CheckBox checkFecha;
        private System.Windows.Forms.Button btnElegirUbicaciones;
    }
}