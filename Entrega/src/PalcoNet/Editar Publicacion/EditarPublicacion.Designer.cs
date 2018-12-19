namespace PalcoNet.Editar_Publicacion
{
    partial class EditarPublicacion
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
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboGrado = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.fechaEspectaculo = new System.Windows.Forms.DateTimePicker();
            this.numeradosDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noNumeradasDataGrid = new System.Windows.Forms.DataGridView();
            this.btnBorrarNumerado = new System.Windows.Forms.Button();
            this.btnNuevoNumerado = new System.Windows.Forms.Button();
            this.btnBorrarSinNumerar = new System.Windows.Forms.Button();
            this.btnNuevoSinNumerar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeradosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noNumeradasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(151, 389);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripción.Multiline = true;
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(218, 89);
            this.txtDescripción.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descripción: *";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(321, 314);
            this.txtNroCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(48, 20);
            this.txtNroCalle.TabIndex = 53;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(151, 353);
            this.txtCodPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(94, 20);
            this.txtCodPostal.TabIndex = 52;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(151, 276);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(121, 20);
            this.txtLocalidad.TabIndex = 51;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(151, 314);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(121, 20);
            this.txtCalle.TabIndex = 50;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(151, 235);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(121, 20);
            this.txtCiudad.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Codigo postal: *";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Localidad: *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Nro: *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Calle: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ciudad: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Fecha Espectaculo: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Modificar Publicación";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(895, 580);
            this.shapeContainer1.TabIndex = 59;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(19, 15);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(853, 545);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(69, 509);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 33);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(398, 509);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 33);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar borrador";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboGrado
            // 
            this.comboGrado.FormattingEnabled = true;
            this.comboGrado.Location = new System.Drawing.Point(151, 163);
            this.comboGrado.Name = "comboGrado";
            this.comboGrado.Size = new System.Drawing.Size(196, 21);
            this.comboGrado.TabIndex = 64;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(40, 166);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(43, 13);
            this.lblGrado.TabIndex = 65;
            this.lblGrado.Text = "Grado *";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(40, 203);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(43, 13);
            this.lblRubro.TabIndex = 66;
            this.lblRubro.Text = "Rubro *";
            // 
            // comboRubro
            // 
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(151, 200);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(121, 21);
            this.comboRubro.TabIndex = 67;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(725, 509);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPublicar.Size = new System.Drawing.Size(94, 33);
            this.btnPublicar.TabIndex = 68;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // fechaEspectaculo
            // 
            this.fechaEspectaculo.Location = new System.Drawing.Point(151, 129);
            this.fechaEspectaculo.Name = "fechaEspectaculo";
            this.fechaEspectaculo.Size = new System.Drawing.Size(200, 20);
            this.fechaEspectaculo.TabIndex = 71;
            // 
            // numeradosDataGrid
            // 
            this.numeradosDataGrid.AllowUserToAddRows = false;
            this.numeradosDataGrid.AllowUserToDeleteRows = false;
            this.numeradosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numeradosDataGrid.Location = new System.Drawing.Point(408, 91);
            this.numeradosDataGrid.Name = "numeradosDataGrid";
            this.numeradosDataGrid.ReadOnly = true;
            this.numeradosDataGrid.Size = new System.Drawing.Size(374, 150);
            this.numeradosDataGrid.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Sectores numerados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Sectores sin numerar";
            // 
            // noNumeradasDataGrid
            // 
            this.noNumeradasDataGrid.AllowUserToAddRows = false;
            this.noNumeradasDataGrid.AllowUserToDeleteRows = false;
            this.noNumeradasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noNumeradasDataGrid.Location = new System.Drawing.Point(408, 282);
            this.noNumeradasDataGrid.Name = "noNumeradasDataGrid";
            this.noNumeradasDataGrid.ReadOnly = true;
            this.noNumeradasDataGrid.Size = new System.Drawing.Size(374, 200);
            this.noNumeradasDataGrid.TabIndex = 75;
            // 
            // btnBorrarNumerado
            // 
            this.btnBorrarNumerado.Location = new System.Drawing.Point(788, 105);
            this.btnBorrarNumerado.Name = "btnBorrarNumerado";
            this.btnBorrarNumerado.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarNumerado.TabIndex = 76;
            this.btnBorrarNumerado.Text = "Borrar";
            this.btnBorrarNumerado.UseVisualStyleBackColor = true;
            this.btnBorrarNumerado.Click += new System.EventHandler(this.btnBorrarNumerado_Click);
            // 
            // btnNuevoNumerado
            // 
            this.btnNuevoNumerado.Location = new System.Drawing.Point(788, 146);
            this.btnNuevoNumerado.Name = "btnNuevoNumerado";
            this.btnNuevoNumerado.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoNumerado.TabIndex = 77;
            this.btnNuevoNumerado.Text = "Nuevo";
            this.btnNuevoNumerado.UseVisualStyleBackColor = true;
            this.btnNuevoNumerado.Click += new System.EventHandler(this.btnNuevoNumerado_Click);
            // 
            // btnBorrarSinNumerar
            // 
            this.btnBorrarSinNumerar.Location = new System.Drawing.Point(788, 312);
            this.btnBorrarSinNumerar.Name = "btnBorrarSinNumerar";
            this.btnBorrarSinNumerar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarSinNumerar.TabIndex = 78;
            this.btnBorrarSinNumerar.Text = "Borrar";
            this.btnBorrarSinNumerar.UseVisualStyleBackColor = true;
            this.btnBorrarSinNumerar.Click += new System.EventHandler(this.btnBorrarSinNumerar_Click);
            // 
            // btnNuevoSinNumerar
            // 
            this.btnNuevoSinNumerar.Location = new System.Drawing.Point(788, 356);
            this.btnNuevoSinNumerar.Name = "btnNuevoSinNumerar";
            this.btnNuevoSinNumerar.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoSinNumerar.TabIndex = 79;
            this.btnNuevoSinNumerar.Text = "Nuevo";
            this.btnNuevoSinNumerar.UseVisualStyleBackColor = true;
            this.btnNuevoSinNumerar.Click += new System.EventHandler(this.btnNuevoSinNumerar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "* Obligatorios para publicar";
            // 
            // EditarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNuevoSinNumerar);
            this.Controls.Add(this.btnBorrarSinNumerar);
            this.Controls.Add(this.btnNuevoNumerado);
            this.Controls.Add(this.btnBorrarNumerado);
            this.Controls.Add(this.noNumeradasDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeradosDataGrid);
            this.Controls.Add(this.fechaEspectaculo);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.comboRubro);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.comboGrado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditarPublicacion";
            this.Text = "editarPublicacion";
            this.Load += new System.EventHandler(this.EditarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeradosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noNumeradasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox comboGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.DateTimePicker fechaEspectaculo;
        private System.Windows.Forms.DataGridView numeradosDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView noNumeradasDataGrid;
        private System.Windows.Forms.Button btnBorrarNumerado;
        private System.Windows.Forms.Button btnNuevoNumerado;
        private System.Windows.Forms.Button btnBorrarSinNumerar;
        private System.Windows.Forms.Button btnNuevoSinNumerar;
        private System.Windows.Forms.Label label7;
    }
}