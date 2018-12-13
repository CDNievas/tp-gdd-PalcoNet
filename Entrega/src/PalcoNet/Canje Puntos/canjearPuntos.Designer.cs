namespace PalcoNet.Canje_Puntos
{
    partial class CanjearPuntos
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
            this.btnCanjear = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.premiosDataGrid = new System.Windows.Forms.DataGridView();
            this.checkSoloDisponibles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCanjearPuntos
            // 
            this.lblCanjearPuntos.AutoSize = true;
            this.lblCanjearPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanjearPuntos.Location = new System.Drawing.Point(20, 9);
            this.lblCanjearPuntos.Name = "lblCanjearPuntos";
            this.lblCanjearPuntos.Size = new System.Drawing.Size(174, 25);
            this.lblCanjearPuntos.TabIndex = 5;
            this.lblCanjearPuntos.Text = "Canjear Puntos";
            // 
            // lblPuntosCliente
            // 
            this.lblPuntosCliente.AutoSize = true;
            this.lblPuntosCliente.Location = new System.Drawing.Point(104, 49);
            this.lblPuntosCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntosCliente.Name = "lblPuntosCliente";
            this.lblPuntosCliente.Size = new System.Drawing.Size(103, 13);
            this.lblPuntosCliente.TabIndex = 11;
            this.lblPuntosCliente.Text = "PUNTOS_CLIENTE";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Location = new System.Drawing.Point(221, 49);
            this.puntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(39, 13);
            this.puntos.TabIndex = 10;
            this.puntos.Text = "puntos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Se dispone de ";
            // 
            // gD2C2018DataSet1
            // 
            this.gD2C2018DataSet1.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(224, 333);
            this.btnCanjear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(66, 24);
            this.btnCanjear.TabIndex = 20;
            this.btnCanjear.Text = "Canjear";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(338, 388);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(17, 35);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(301, 340);
            // 
            // premiosDataGrid
            // 
            this.premiosDataGrid.AllowUserToAddRows = false;
            this.premiosDataGrid.AllowUserToDeleteRows = false;
            this.premiosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.premiosDataGrid.Location = new System.Drawing.Point(25, 123);
            this.premiosDataGrid.Name = "premiosDataGrid";
            this.premiosDataGrid.ReadOnly = true;
            this.premiosDataGrid.Size = new System.Drawing.Size(277, 184);
            this.premiosDataGrid.TabIndex = 23;
            // 
            // checkSoloDisponibles
            // 
            this.checkSoloDisponibles.AutoSize = true;
            this.checkSoloDisponibles.Location = new System.Drawing.Point(34, 85);
            this.checkSoloDisponibles.Name = "checkSoloDisponibles";
            this.checkSoloDisponibles.Size = new System.Drawing.Size(138, 17);
            this.checkSoloDisponibles.TabIndex = 24;
            this.checkSoloDisponibles.Text = "Mostrar sólo disponibles";
            this.checkSoloDisponibles.UseVisualStyleBackColor = true;
            this.checkSoloDisponibles.CheckedChanged += new System.EventHandler(this.checkSoloDisponibles_CheckedChanged);
            // 
            // CanjearPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 388);
            this.Controls.Add(this.checkSoloDisponibles);
            this.Controls.Add(this.premiosDataGrid);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntosCliente);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.lblCanjearPuntos);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CanjearPuntos";
            this.Text = "canjearPuntos";
            this.Load += new System.EventHandler(this.canjearPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCanjearPuntos;
        private System.Windows.Forms.Label lblPuntosCliente;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Label label1;
        private GD2C2018DataSet gD2C2018DataSet1;
        private System.Windows.Forms.Button btnCanjear;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DataGridView premiosDataGrid;
        private System.Windows.Forms.CheckBox checkSoloDisponibles;
    }
}