namespace PalcoNet.Abm_Cliente
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
            this.SuspendLayout();
            // 
            // lblConsultaPuntos
            // 
            this.lblConsultaPuntos.AutoSize = true;
            this.lblConsultaPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPuntos.Location = new System.Drawing.Point(24, 34);
            this.lblConsultaPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultaPuntos.Name = "lblConsultaPuntos";
            this.lblConsultaPuntos.Size = new System.Drawing.Size(229, 31);
            this.lblConsultaPuntos.TabIndex = 4;
            this.lblConsultaPuntos.Text = "Consulta Puntos";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(149, 17);
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
            this.shapeContainer1.Size = new System.Drawing.Size(396, 300);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(26, 113);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(294, 97);
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(215, 154);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(51, 17);
            this.puntos.TabIndex = 8;
            this.puntos.Text = "puntos";
            // 
            // lblPuntosCliente
            // 
            this.lblPuntosCliente.AutoSize = true;
            this.lblPuntosCliente.Location = new System.Drawing.Point(67, 154);
            this.lblPuntosCliente.Name = "lblPuntosCliente";
            this.lblPuntosCliente.Size = new System.Drawing.Size(131, 17);
            this.lblPuntosCliente.TabIndex = 9;
            this.lblPuntosCliente.Text = "PUNTOS_CLIENTE";
            // 
            // ConsultaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 300);
            this.Controls.Add(this.lblPuntosCliente);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblConsultaPuntos);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ConsultaPuntos";
            this.Text = "ConsultaPuntos";
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
    }
}