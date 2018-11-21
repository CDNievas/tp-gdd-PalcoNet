namespace PalcoNet.Abm_Cliente
{
    partial class ListarCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteMod = new System.Windows.Forms.Button();
            this.btnClienteBaja = new System.Windows.Forms.Button();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblClienteDoc = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.ClienteTableAdapter();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrodocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolusuarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.cuilDataGridViewTextBoxColumn,
            this.tipodocumentoDataGridViewTextBoxColumn,
            this.nrodocumentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.domcalleDataGridViewTextBoxColumn,
            this.numcalleDataGridViewTextBoxColumn,
            this.deptoDataGridViewTextBoxColumn,
            this.pisoDataGridViewTextBoxColumn,
            this.codpostalDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.fechacreacionDataGridViewTextBoxColumn,
            this.rolusuarioidDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listar Cliente";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(656, 596);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(36, 84);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(285, 106);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar Cliente";
            // 
            // btnClienteMod
            // 
            this.btnClienteMod.Location = new System.Drawing.Point(474, 256);
            this.btnClienteMod.Name = "btnClienteMod";
            this.btnClienteMod.Size = new System.Drawing.Size(100, 40);
            this.btnClienteMod.TabIndex = 4;
            this.btnClienteMod.Text = "modificar";
            this.btnClienteMod.UseVisualStyleBackColor = true;
            // 
            // btnClienteBaja
            // 
            this.btnClienteBaja.Location = new System.Drawing.Point(474, 318);
            this.btnClienteBaja.Name = "btnClienteBaja";
            this.btnClienteBaja.Size = new System.Drawing.Size(100, 46);
            this.btnClienteBaja.TabIndex = 5;
            this.btnClienteBaja.Text = "Baja";
            this.btnClienteBaja.UseVisualStyleBackColor = true;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(66, 112);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(23, 17);
            this.lblClienteID.TabIndex = 6;
            this.lblClienteID.Text = "id:";
            // 
            // lblClienteDoc
            // 
            this.lblClienteDoc.AutoSize = true;
            this.lblClienteDoc.Location = new System.Drawing.Point(45, 145);
            this.lblClienteDoc.Name = "lblClienteDoc";
            this.lblClienteDoc.Size = new System.Drawing.Size(88, 17);
            this.lblClienteDoc.TabIndex = 7;
            this.lblClienteDoc.Text = "Documento; ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 107);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(222, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuilDataGridViewTextBoxColumn
            // 
            this.cuilDataGridViewTextBoxColumn.DataPropertyName = "cuil";
            this.cuilDataGridViewTextBoxColumn.HeaderText = "cuil";
            this.cuilDataGridViewTextBoxColumn.Name = "cuilDataGridViewTextBoxColumn";
            // 
            // tipodocumentoDataGridViewTextBoxColumn
            // 
            this.tipodocumentoDataGridViewTextBoxColumn.DataPropertyName = "tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn.HeaderText = "tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn.Name = "tipodocumentoDataGridViewTextBoxColumn";
            // 
            // nrodocumentoDataGridViewTextBoxColumn
            // 
            this.nrodocumentoDataGridViewTextBoxColumn.DataPropertyName = "nro_documento";
            this.nrodocumentoDataGridViewTextBoxColumn.HeaderText = "nro_documento";
            this.nrodocumentoDataGridViewTextBoxColumn.Name = "nrodocumentoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
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
            // numcalleDataGridViewTextBoxColumn
            // 
            this.numcalleDataGridViewTextBoxColumn.DataPropertyName = "num_calle";
            this.numcalleDataGridViewTextBoxColumn.HeaderText = "num_calle";
            this.numcalleDataGridViewTextBoxColumn.Name = "numcalleDataGridViewTextBoxColumn";
            // 
            // deptoDataGridViewTextBoxColumn
            // 
            this.deptoDataGridViewTextBoxColumn.DataPropertyName = "depto";
            this.deptoDataGridViewTextBoxColumn.HeaderText = "depto";
            this.deptoDataGridViewTextBoxColumn.Name = "deptoDataGridViewTextBoxColumn";
            // 
            // pisoDataGridViewTextBoxColumn
            // 
            this.pisoDataGridViewTextBoxColumn.DataPropertyName = "piso";
            this.pisoDataGridViewTextBoxColumn.HeaderText = "piso";
            this.pisoDataGridViewTextBoxColumn.Name = "pisoDataGridViewTextBoxColumn";
            // 
            // codpostalDataGridViewTextBoxColumn
            // 
            this.codpostalDataGridViewTextBoxColumn.DataPropertyName = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.HeaderText = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.Name = "codpostalDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
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
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 596);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblClienteDoc);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.btnClienteBaja);
            this.Controls.Add(this.btnClienteMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClienteMod;
        private System.Windows.Forms.Button btnClienteBaja;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblClienteDoc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GD2C2018DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrodocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolusuarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}