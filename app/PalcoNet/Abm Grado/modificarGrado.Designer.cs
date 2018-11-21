namespace PalcoNet.Abm_Grado
{
    partial class actualizarGrado
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
            this.components = new System.ComponentModel.Container();
            this.lblGradoComision = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.nGradoComision = new System.Windows.Forms.NumericUpDown();
            this.lblGradoID = new System.Windows.Forms.Label();
            this.txtGradoID = new System.Windows.Forms.TextBox();
            this.btnGradoModificar = new System.Windows.Forms.Button();
            this.lblGradoDescripcion = new System.Windows.Forms.Label();
            this.txtGradoDescripcion = new System.Windows.Forms.TextBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.nGradoComision)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGradoComision
            // 
            this.lblGradoComision.AutoSize = true;
            this.lblGradoComision.Location = new System.Drawing.Point(35, 114);
            this.lblGradoComision.Name = "lblGradoComision";
            this.lblGradoComision.Size = new System.Drawing.Size(69, 17);
            this.lblGradoComision.TabIndex = 0;
            this.lblGradoComision.Text = "Comision:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(38, 281);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 21;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // nGradoComision
            // 
            this.nGradoComision.Location = new System.Drawing.Point(126, 114);
            this.nGradoComision.Name = "nGradoComision";
            this.nGradoComision.Size = new System.Drawing.Size(120, 22);
            this.nGradoComision.TabIndex = 22;
            // 
            // lblGradoID
            // 
            this.lblGradoID.AutoSize = true;
            this.lblGradoID.Location = new System.Drawing.Point(35, 52);
            this.lblGradoID.Name = "lblGradoID";
            this.lblGradoID.Size = new System.Drawing.Size(25, 17);
            this.lblGradoID.TabIndex = 23;
            this.lblGradoID.Text = "ID:";
            // 
            // txtGradoID
            // 
            this.txtGradoID.Location = new System.Drawing.Point(126, 52);
            this.txtGradoID.Name = "txtGradoID";
            this.txtGradoID.Size = new System.Drawing.Size(100, 22);
            this.txtGradoID.TabIndex = 24;
            // 
            // btnGradoModificar
            // 
            this.btnGradoModificar.Location = new System.Drawing.Point(257, 281);
            this.btnGradoModificar.Name = "btnGradoModificar";
            this.btnGradoModificar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoModificar.TabIndex = 25;
            this.btnGradoModificar.Text = "modificar";
            this.btnGradoModificar.UseVisualStyleBackColor = true;
            // 
            // lblGradoDescripcion
            // 
            this.lblGradoDescripcion.AutoSize = true;
            this.lblGradoDescripcion.Location = new System.Drawing.Point(35, 176);
            this.lblGradoDescripcion.Name = "lblGradoDescripcion";
            this.lblGradoDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblGradoDescripcion.TabIndex = 26;
            this.lblGradoDescripcion.Text = "Descripcion:";
            // 
            // txtGradoDescripcion
            // 
            this.txtGradoDescripcion.Location = new System.Drawing.Point(126, 171);
            this.txtGradoDescripcion.Multiline = true;
            this.txtGradoDescripcion.Name = "txtGradoDescripcion";
            this.txtGradoDescripcion.Size = new System.Drawing.Size(202, 91);
            this.txtGradoDescripcion.TabIndex = 27;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(27, 36);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(333, 236);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(387, 346);
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // actualizarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 346);
            this.Controls.Add(this.txtGradoDescripcion);
            this.Controls.Add(this.lblGradoDescripcion);
            this.Controls.Add(this.btnGradoModificar);
            this.Controls.Add(this.txtGradoID);
            this.Controls.Add(this.lblGradoID);
            this.Controls.Add(this.nGradoComision);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.lblGradoComision);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "actualizarGrado";
            this.Text = "ActualizarGrado";
            ((System.ComponentModel.ISupportInitialize)(this.nGradoComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradoComision;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.NumericUpDown nGradoComision;
        private System.Windows.Forms.Label lblGradoID;
        private System.Windows.Forms.TextBox txtGradoID;
        private System.Windows.Forms.Button btnGradoModificar;
        private System.Windows.Forms.Label lblGradoDescripcion;
        private System.Windows.Forms.TextBox txtGradoDescripcion;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}