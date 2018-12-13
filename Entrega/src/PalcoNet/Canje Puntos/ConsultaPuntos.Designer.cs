namespace PalcoNet.Canje_Puntos
{
    partial class ConsultaPuntos
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
            this.lblConsultaPuntos = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.puntos = new System.Windows.Forms.Label();
            this.lblPuntosCliente = new System.Windows.Forms.Label();
            this.btnPremios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConsultaPuntos
            // 
            this.lblConsultaPuntos.AutoSize = true;
            this.lblConsultaPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPuntos.Location = new System.Drawing.Point(18, 28);
            this.lblConsultaPuntos.Name = "lblConsultaPuntos";
            this.lblConsultaPuntos.Size = new System.Drawing.Size(185, 25);
            this.lblConsultaPuntos.TabIndex = 4;
            this.lblConsultaPuntos.Text = "Consulta Puntos";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(23, 67);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(113, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Se dispone a la fecha:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(348, 251);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(26, 95);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(294, 68);
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.ForeColor = System.Drawing.Color.Red;
            this.puntos.Location = new System.Drawing.Point(171, 116);
            this.puntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(122, 37);
            this.puntos.TabIndex = 8;
            this.puntos.Text = "20.000";
            // 
            // lblPuntosCliente
            // 
            this.lblPuntosCliente.AutoSize = true;
            this.lblPuntosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosCliente.Location = new System.Drawing.Point(44, 116);
            this.lblPuntosCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntosCliente.Name = "lblPuntosCliente";
            this.lblPuntosCliente.Size = new System.Drawing.Size(92, 25);
            this.lblPuntosCliente.TabIndex = 9;
            this.lblPuntosCliente.Text = "Puntos:";
            // 
            // btnPremios
            // 
            this.btnPremios.Location = new System.Drawing.Point(128, 193);
            this.btnPremios.Name = "btnPremios";
            this.btnPremios.Size = new System.Drawing.Size(75, 23);
            this.btnPremios.TabIndex = 10;
            this.btnPremios.Text = "Ver premios";
            this.btnPremios.UseVisualStyleBackColor = true;
            this.btnPremios.Click += new System.EventHandler(this.btnPremios_Click);
            // 
            // ConsultaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 251);
            this.Controls.Add(this.btnPremios);
            this.Controls.Add(this.lblPuntosCliente);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblConsultaPuntos);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultaPuntos";
            this.Text = "ConsultaPuntos";
            this.Load += new System.EventHandler(this.ConsultaPuntos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaPuntos;
        private System.Windows.Forms.Label lbl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Label lblPuntosCliente;
        private System.Windows.Forms.Button btnPremios;
    }
}