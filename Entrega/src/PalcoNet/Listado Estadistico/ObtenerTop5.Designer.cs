namespace PalcoNet.Listado_Estadistico
{
    partial class ObtenerTop5
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
            this.lbltop5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.resultadosDataGrid = new System.Windows.Forms.DataGridView();
            this.tipoListadoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trimestreInput = new System.Windows.Forms.NumericUpDown();
            this.anioInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnSeleccionEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltop5
            // 
            this.lbltop5.AutoSize = true;
            this.lbltop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop5.Location = new System.Drawing.Point(26, 20);
            this.lbltop5.Name = "lbltop5";
            this.lbltop5.Size = new System.Drawing.Size(163, 25);
            this.lbltop5.TabIndex = 1;
            this.lbltop5.Text = "Obtener Top 5";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(812, 495);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(34, 48);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(493, 151);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 164);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 24);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // resultadosDataGrid
            // 
            this.resultadosDataGrid.AllowUserToAddRows = false;
            this.resultadosDataGrid.AllowUserToDeleteRows = false;
            this.resultadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadosDataGrid.Location = new System.Drawing.Point(31, 235);
            this.resultadosDataGrid.Name = "resultadosDataGrid";
            this.resultadosDataGrid.ReadOnly = true;
            this.resultadosDataGrid.Size = new System.Drawing.Size(750, 239);
            this.resultadosDataGrid.TabIndex = 20;
            // 
            // tipoListadoComboBox
            // 
            this.tipoListadoComboBox.FormattingEnabled = true;
            this.tipoListadoComboBox.Location = new System.Drawing.Point(231, 129);
            this.tipoListadoComboBox.Name = "tipoListadoComboBox";
            this.tipoListadoComboBox.Size = new System.Drawing.Size(289, 21);
            this.tipoListadoComboBox.TabIndex = 21;
            this.tipoListadoComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoListadoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "TipoListado";
            // 
            // trimestreInput
            // 
            this.trimestreInput.Location = new System.Drawing.Point(231, 94);
            this.trimestreInput.Name = "trimestreInput";
            this.trimestreInput.Size = new System.Drawing.Size(120, 20);
            this.trimestreInput.TabIndex = 23;
            this.trimestreInput.ValueChanged += new System.EventHandler(this.trimestreInput_ValueChanged);
            // 
            // anioInput
            // 
            this.anioInput.Location = new System.Drawing.Point(231, 62);
            this.anioInput.Name = "anioInput";
            this.anioInput.Size = new System.Drawing.Size(120, 20);
            this.anioInput.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Trimestre:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(549, 62);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 27;
            this.lblGrado.Text = "Grado:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(549, 94);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 28;
            this.lblMes.Text = "Mes:";
            // 
            // comboGrado
            // 
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(594, 59);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(121, 21);
            this.comboGrado.TabIndex = 29;
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(594, 91);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(121, 21);
            this.comboMes.TabIndex = 30;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(549, 132);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(117, 13);
            this.lblEmpresa.TabIndex = 31;
            this.lblEmpresa.Text = "Empresa seleccionada:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(672, 129);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(128, 20);
            this.txtEmpresa.TabIndex = 32;
            // 
            // btnSeleccionEmpresa
            // 
            this.btnSeleccionEmpresa.Location = new System.Drawing.Point(578, 164);
            this.btnSeleccionEmpresa.Name = "btnSeleccionEmpresa";
            this.btnSeleccionEmpresa.Size = new System.Drawing.Size(168, 23);
            this.btnSeleccionEmpresa.TabIndex = 33;
            this.btnSeleccionEmpresa.Text = "Seleccionar Empresa";
            this.btnSeleccionEmpresa.UseVisualStyleBackColor = true;
            this.btnSeleccionEmpresa.Click += new System.EventHandler(this.btnSeleccionEmpresa_Click);
            // 
            // ObtenerTop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 495);
            this.Controls.Add(this.btnSeleccionEmpresa);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboGrado);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anioInput);
            this.Controls.Add(this.trimestreInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoListadoComboBox);
            this.Controls.Add(this.resultadosDataGrid);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbltop5);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ObtenerTop5";
            this.Text = "top5";
            this.Load += new System.EventHandler(this.obtenerTop5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trimestreInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltop5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView resultadosDataGrid;
        private System.Windows.Forms.ComboBox tipoListadoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown trimestreInput;
        private System.Windows.Forms.NumericUpDown anioInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnSeleccionEmpresa;

    }
}