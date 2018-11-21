namespace PalcoNet.Abm_Cliente
{
    partial class canjearPuntos
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
            this.lblCanjearPuntos = new System.Windows.Forms.Label();
            this.lblPuntosCliente = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gD2C2018DataSet1 = new PalcoNet.GD2C2018DataSet();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoBuscar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCanjearPuntos
            // 
            this.lblCanjearPuntos.AutoSize = true;
            this.lblCanjearPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanjearPuntos.Location = new System.Drawing.Point(27, 41);
            this.lblCanjearPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanjearPuntos.Name = "lblCanjearPuntos";
            this.lblCanjearPuntos.Size = new System.Drawing.Size(215, 31);
            this.lblCanjearPuntos.TabIndex = 5;
            this.lblCanjearPuntos.Text = "Canjear Puntos";
            // 
            // lblPuntosCliente
            // 
            this.lblPuntosCliente.AutoSize = true;
            this.lblPuntosCliente.Location = new System.Drawing.Point(146, 116);
            this.lblPuntosCliente.Name = "lblPuntosCliente";
            this.lblPuntosCliente.Size = new System.Drawing.Size(131, 17);
            this.lblPuntosCliente.TabIndex = 11;
            this.lblPuntosCliente.Text = "PUNTOS_CLIENTE";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(295, 116);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(51, 17);
            this.puntos.TabIndex = 10;
            this.puntos.Text = "puntos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Se dispone de ";
            // 
            // gD2C2018DataSet1
            // 
            this.gD2C2018DataSet1.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "prod1",
            "prod2",
            "prod3",
            "prod4",
            "prod5",
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(33, 160);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(336, 225);
            this.checkedListBox1.TabIndex = 13;
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(33, 418);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 21;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGradoBuscar
            // 
            this.btnGradoBuscar.Location = new System.Drawing.Point(281, 418);
            this.btnGradoBuscar.Name = "btnGradoBuscar";
            this.btnGradoBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoBuscar.TabIndex = 20;
            this.btnGradoBuscar.Text = "Canjear";
            this.btnGradoBuscar.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(451, 477);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(17, 58);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(372, 348);
            // 
            // canjearPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 477);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoBuscar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntosCliente);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.lblCanjearPuntos);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "canjearPuntos";
            this.Text = "canjearPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCanjearPuntos;
        private System.Windows.Forms.Label lblPuntosCliente;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Label label1;
        private GD2C2018DataSet gD2C2018DataSet1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}