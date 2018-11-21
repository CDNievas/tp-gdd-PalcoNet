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
            this.Descripcion = new System.Windows.Forms.Label();
            this.RangoFechas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.RangoFechas);
            this.Filtros.Controls.Add(this.Descripcion);
            this.Filtros.Location = new System.Drawing.Point(12, 80);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(701, 187);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(31, 85);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 0;
            this.Descripcion.Text = "Descripcion";
            // 
            // RangoFechas
            // 
            this.RangoFechas.AutoSize = true;
            this.RangoFechas.Location = new System.Drawing.Point(31, 131);
            this.RangoFechas.Name = "RangoFechas";
            this.RangoFechas.Size = new System.Drawing.Size(92, 13);
            this.RangoFechas.TabIndex = 1;
            this.RangoFechas.Text = "Rango de Fechas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria/s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 529);
            this.Controls.Add(this.Filtros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RangoFechas;
    }
}