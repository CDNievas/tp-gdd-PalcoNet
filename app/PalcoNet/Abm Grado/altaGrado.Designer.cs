namespace PalcoNet.Abm_Grado
{
    partial class AltaGrado
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
            this.lblDescripcionGrado = new System.Windows.Forms.Label();
            this.txtDescripcionGrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComisionGrado = new System.Windows.Forms.Label();
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoGuardar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescripcionGrado
            // 
            this.lblDescripcionGrado.AutoSize = true;
            this.lblDescripcionGrado.Location = new System.Drawing.Point(16, 121);
            this.lblDescripcionGrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionGrado.Name = "lblDescripcionGrado";
            this.lblDescripcionGrado.Size = new System.Drawing.Size(96, 13);
            this.lblDescripcionGrado.TabIndex = 1;
            this.lblDescripcionGrado.Text = "Descripcion grado:";
            // 
            // txtDescripcionGrado
            // 
            this.txtDescripcionGrado.Location = new System.Drawing.Point(116, 121);
            this.txtDescripcionGrado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionGrado.Multiline = true;
            this.txtDescripcionGrado.Name = "txtDescripcionGrado";
            this.txtDescripcionGrado.Size = new System.Drawing.Size(178, 88);
            this.txtDescripcionGrado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crear Grado";
            // 
            // lblComisionGrado
            // 
            this.lblComisionGrado.AutoSize = true;
            this.lblComisionGrado.Location = new System.Drawing.Point(24, 70);
            this.lblComisionGrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComisionGrado.Name = "lblComisionGrado";
            this.lblComisionGrado.Size = new System.Drawing.Size(82, 13);
            this.lblComisionGrado.TabIndex = 5;
            this.lblComisionGrado.Text = "Comision grado:";
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(46, 240);
            this.btnGradoLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnGradoLimpiar.TabIndex = 17;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            this.btnGradoLimpiar.Click += new System.EventHandler(this.btnGradoLimpiar_Click);
            // 
            // btnGradoGuardar
            // 
            this.btnGradoGuardar.Location = new System.Drawing.Point(207, 240);
            this.btnGradoGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradoGuardar.Name = "btnGradoGuardar";
            this.btnGradoGuardar.Size = new System.Drawing.Size(66, 24);
            this.btnGradoGuardar.TabIndex = 16;
            this.btnGradoGuardar.Text = "Guardar";
            this.btnGradoGuardar.UseVisualStyleBackColor = true;
            this.btnGradoGuardar.Click += new System.EventHandler(this.btnGradoGuardar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(318, 286);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(17, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(390, 238);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(116, 70);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(100, 20);
            this.txtComision.TabIndex = 19;
            // 
            // AltaGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 286);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoGuardar);
            this.Controls.Add(this.lblComisionGrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionGrado);
            this.Controls.Add(this.lblDescripcionGrado);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaGrado";
            this.Text = "Crear Grado";
            this.Load += new System.EventHandler(this.AltaGrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionGrado;
        private System.Windows.Forms.TextBox txtDescripcionGrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComisionGrado;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoGuardar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox txtComision;
    }
}