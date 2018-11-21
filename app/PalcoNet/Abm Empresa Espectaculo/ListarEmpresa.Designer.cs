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
            this.components = new System.ComponentModel.Container();
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
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.EmpresaTableAdapter();
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
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrocalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolusuarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.idempresaDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.razonsocialDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.domcalleDataGridViewTextBoxColumn,
            this.nrocalleDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.deptoDataGridViewTextBoxColumn,
            this.codpostalDataGridViewTextBoxColumn,
            this.fechacreacionDataGridViewTextBoxColumn,
            this.rolusuarioidDataGridViewTextBoxColumn,
            this.seleccionar});
            this.dataGridView1.DataSource = this.empresaBindingSource;
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
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
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
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            this.idempresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // razonsocialDataGridViewTextBoxColumn
            // 
            this.razonsocialDataGridViewTextBoxColumn.DataPropertyName = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.HeaderText = "razon_social";
            this.razonsocialDataGridViewTextBoxColumn.Name = "razonsocialDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // domcalleDataGridViewTextBoxColumn
            // 
            this.domcalleDataGridViewTextBoxColumn.DataPropertyName = "dom_calle";
            this.domcalleDataGridViewTextBoxColumn.HeaderText = "dom_calle";
            this.domcalleDataGridViewTextBoxColumn.Name = "domcalleDataGridViewTextBoxColumn";
            // 
            // nrocalleDataGridViewTextBoxColumn
            // 
            this.nrocalleDataGridViewTextBoxColumn.DataPropertyName = "nro_calle";
            this.nrocalleDataGridViewTextBoxColumn.HeaderText = "nro_calle";
            this.nrocalleDataGridViewTextBoxColumn.Name = "nrocalleDataGridViewTextBoxColumn";
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            // 
            // deptoDataGridViewTextBoxColumn
            // 
            this.deptoDataGridViewTextBoxColumn.DataPropertyName = "depto";
            this.deptoDataGridViewTextBoxColumn.HeaderText = "depto";
            this.deptoDataGridViewTextBoxColumn.Name = "deptoDataGridViewTextBoxColumn";
            // 
            // codpostalDataGridViewTextBoxColumn
            // 
            this.codpostalDataGridViewTextBoxColumn.DataPropertyName = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.HeaderText = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.Name = "codpostalDataGridViewTextBoxColumn";
            // 
            // fechacreacionDataGridViewTextBoxColumn
            // 
            this.fechacreacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.HeaderText = "fecha_creacion";
            this.fechacreacionDataGridViewTextBoxColumn.Name = "fechacreacionDataGridViewTextBoxColumn";
            // 
            // rolusuarioidDataGridViewTextBoxColumn
            // 
            this.rolusuarioidDataGridViewTextBoxColumn.DataPropertyName = "rol_usuario_id";
            this.rolusuarioidDataGridViewTextBoxColumn.HeaderText = "rol_usuario_id";
            this.rolusuarioidDataGridViewTextBoxColumn.Name = "rolusuarioidDataGridViewTextBoxColumn";
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
            this.Load += new System.EventHandler(this.ListarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
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
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private GD2C2018DataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolusuarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
    }
}