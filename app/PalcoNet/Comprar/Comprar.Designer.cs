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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.btnComprasLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkListCategoria = new System.Windows.Forms.CheckedListBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RangoFechas = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPagPrimera = new System.Windows.Forms.Button();
            this.btnPagUltima = new System.Windows.Forms.Button();
            this.comprasDataGrid = new System.Windows.Forms.DataGridView();
            this.Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.label4);
            this.Filtros.Controls.Add(this.label3);
            this.Filtros.Controls.Add(this.dateHasta);
            this.Filtros.Controls.Add(this.btnComprasLimpiar);
            this.Filtros.Controls.Add(this.button2);
            this.Filtros.Controls.Add(this.checkListCategoria);
            this.Filtros.Controls.Add(this.txtDescripcion);
            this.Filtros.Controls.Add(this.dateDesde);
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.RangoFechas);
            this.Filtros.Controls.Add(this.Descripcion);
            this.Filtros.Location = new System.Drawing.Point(16, 57);
            this.Filtros.Margin = new System.Windows.Forms.Padding(4);
            this.Filtros.Name = "Filtros";
            this.Filtros.Padding = new System.Windows.Forms.Padding(4);
            this.Filtros.Size = new System.Drawing.Size(763, 207);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // dateHasta
            // 
            this.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHasta.Location = new System.Drawing.Point(567, 75);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(132, 22);
            this.dateHasta.TabIndex = 8;
            // 
            // btnComprasLimpiar
            // 
            this.btnComprasLimpiar.Location = new System.Drawing.Point(193, 171);
            this.btnComprasLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprasLimpiar.Name = "btnComprasLimpiar";
            this.btnComprasLimpiar.Size = new System.Drawing.Size(119, 28);
            this.btnComprasLimpiar.TabIndex = 7;
            this.btnComprasLimpiar.Text = "Limpiar Filtros";
            this.btnComprasLimpiar.UseVisualStyleBackColor = true;
            this.btnComprasLimpiar.Click += new System.EventHandler(this.btnComprasLimpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 171);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkListCategoria
            // 
            this.checkListCategoria.FormattingEnabled = true;
            this.checkListCategoria.Location = new System.Drawing.Point(193, 23);
            this.checkListCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.checkListCategoria.Name = "checkListCategoria";
            this.checkListCategoria.Size = new System.Drawing.Size(283, 55);
            this.checkListCategoria.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(193, 105);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(539, 22);
            this.txtDescripcion.TabIndex = 4;
            // 
            // dateDesde
            // 
            this.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDesde.Location = new System.Drawing.Point(567, 34);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(132, 22);
            this.dateDesde.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
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
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(41, 105);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(86, 17);
            this.Descripcion.TabIndex = 0;
            this.Descripcion.Text = "Descripcion:";
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
            this.button1.Location = new System.Drawing.Point(671, 610);
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
            this.btnPaginaAnterior.Location = new System.Drawing.Point(16, 610);
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
            this.btnPagPrimera.Location = new System.Drawing.Point(149, 610);
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
            this.btnPagUltima.Location = new System.Drawing.Point(545, 610);
            this.btnPagUltima.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagUltima.Name = "btnPagUltima";
            this.btnPagUltima.Size = new System.Drawing.Size(100, 28);
            this.btnPagUltima.TabIndex = 7;
            this.btnPagUltima.Text = "Ultima";
            this.btnPagUltima.UseVisualStyleBackColor = true;
            this.btnPagUltima.Click += new System.EventHandler(this.btnPagUltima_Click);
            // 
            // comprasDataGrid
            // 
            this.comprasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasDataGrid.Location = new System.Drawing.Point(16, 281);
            this.comprasDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.comprasDataGrid.Name = "comprasDataGrid";
            this.comprasDataGrid.Size = new System.Drawing.Size(763, 297);
            this.comprasDataGrid.TabIndex = 20;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 651);
            this.Controls.Add(this.comprasDataGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RangoFechas;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.CheckedListBox checkListCategoria;        // ADAPTAR ESTO A LAS CATEGORIAS POSIBLES
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnComprasLimpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPagPrimera;
        private System.Windows.Forms.Button btnPagUltima;
        private System.Windows.Forms.DataGridView comprasDataGrid;
    }
}