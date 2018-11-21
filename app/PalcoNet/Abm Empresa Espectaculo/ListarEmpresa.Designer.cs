namespace PalcoNet.Abm_Empresa_Espectaculo
{
    partial class ListarEmpresa
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEmpresaCuit = new System.Windows.Forms.Label();
            this.lblEmpresaId = new System.Windows.Forms.Label();
            this.btnEmpresaBaja = new System.Windows.Forms.Button();
            this.btnEmpresaMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(34, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(145, 90);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 22);
            this.txtCuit.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(145, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 18;
            // 
            // lblEmpresaCuit
            // 
            this.lblEmpresaCuit.AutoSize = true;
            this.lblEmpresaCuit.Location = new System.Drawing.Point(64, 90);
            this.lblEmpresaCuit.Name = "lblEmpresaCuit";
            this.lblEmpresaCuit.Size = new System.Drawing.Size(36, 17);
            this.lblEmpresaCuit.TabIndex = 17;
            this.lblEmpresaCuit.Text = "Cuit:";
            // 
            // lblEmpresaId
            // 
            this.lblEmpresaId.AutoSize = true;
            this.lblEmpresaId.Location = new System.Drawing.Point(64, 62);
            this.lblEmpresaId.Name = "lblEmpresaId";
            this.lblEmpresaId.Size = new System.Drawing.Size(23, 17);
            this.lblEmpresaId.TabIndex = 16;
            this.lblEmpresaId.Text = "id:";
            // 
            // btnEmpresaBaja
            // 
            this.btnEmpresaBaja.Location = new System.Drawing.Point(472, 268);
            this.btnEmpresaBaja.Name = "btnEmpresaBaja";
            this.btnEmpresaBaja.Size = new System.Drawing.Size(100, 46);
            this.btnEmpresaBaja.TabIndex = 15;
            this.btnEmpresaBaja.Text = "Baja";
            this.btnEmpresaBaja.UseVisualStyleBackColor = true;
            // 
            // btnEmpresaMod
            // 
            this.btnEmpresaMod.Location = new System.Drawing.Point(472, 206);
            this.btnEmpresaMod.Name = "btnEmpresaMod";
            this.btnEmpresaMod.Size = new System.Drawing.Size(100, 40);
            this.btnEmpresaMod.TabIndex = 14;
            this.btnEmpresaMod.Text = "modificar";
            this.btnEmpresaMod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrar Empresa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit,
            this.e_mail,
            this.telefono,
            this.Ciudad,
            this.localidad,
            this.calle,
            this.nro,
            this.piso,
            this.dpto,
            this.codPostal,
            this.razSocial,
            this.seleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(33, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 285);
            this.dataGridView1.TabIndex = 12;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(642, 503);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(35, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(357, 96);
            // 
            // cuit
            // 
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            // 
            // e_mail
            // 
            this.e_mail.HeaderText = "e_mail";
            this.e_mail.Name = "e_mail";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // localidad
            // 
            this.localidad.HeaderText = "localidad";
            this.localidad.Name = "localidad";
            // 
            // calle
            // 
            this.calle.HeaderText = "calle";
            this.calle.Name = "calle";
            // 
            // nro
            // 
            this.nro.HeaderText = "nro";
            this.nro.Name = "nro";
            // 
            // piso
            // 
            this.piso.HeaderText = "piso";
            this.piso.Name = "piso";
            // 
            // dpto
            // 
            this.dpto.HeaderText = "dpto";
            this.dpto.Name = "dpto";
            // 
            // codPostal
            // 
            this.codPostal.HeaderText = "codPostal";
            this.codPostal.Name = "codPostal";
            // 
            // razSocial
            // 
            this.razSocial.HeaderText = "Razon Social";
            this.razSocial.Name = "razSocial";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ListarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 503);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEmpresaCuit);
            this.Controls.Add(this.lblEmpresaId);
            this.Controls.Add(this.btnEmpresaBaja);
            this.Controls.Add(this.btnEmpresaMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ListarEmpresa";
            this.Text = "ListarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmpresaCuit;
        private System.Windows.Forms.Label lblEmpresaId;
        private System.Windows.Forms.Button btnEmpresaBaja;
        private System.Windows.Forms.Button btnEmpresaMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn razSocial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
    }
}