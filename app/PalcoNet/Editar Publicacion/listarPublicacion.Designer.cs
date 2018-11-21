namespace PalcoNet.Editar_Publicacion
{
    partial class listarPublicacion
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
            this.txtListPublicacionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListPublicacionNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.tblGradoBusqueda = new System.Windows.Forms.DataGridView();
            this.btnPublicacionLimpiar = new System.Windows.Forms.Button();
            this.btnPublicacionBuscar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.publicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.PublicacionTableAdapter();
            this.publicacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idpublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desrcipcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaespectaculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtListPublicacionId
            // 
            this.txtListPublicacionId.Location = new System.Drawing.Point(150, 121);
            this.txtListPublicacionId.Name = "txtListPublicacionId";
            this.txtListPublicacionId.Size = new System.Drawing.Size(115, 22);
            this.txtListPublicacionId.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "id:";
            // 
            // txtListPublicacionNombre
            // 
            this.txtListPublicacionNombre.Location = new System.Drawing.Point(150, 90);
            this.txtListPublicacionNombre.Name = "txtListPublicacionNombre";
            this.txtListPublicacionNombre.Size = new System.Drawing.Size(115, 22);
            this.txtListPublicacionNombre.TabIndex = 47;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(51, 90);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(62, 17);
            this.lblRolNombre.TabIndex = 46;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(404, 302);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(88, 30);
            this.btnBaja.TabIndex = 45;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(404, 237);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(88, 30);
            this.btnMod.TabIndex = 44;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(32, 31);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(245, 31);
            this.l.TabIndex = 43;
            this.l.Text = "Listar Publicacion";
            // 
            // tblGradoBusqueda
            // 
            this.tblGradoBusqueda.AutoGenerateColumns = false;
            this.tblGradoBusqueda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblGradoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGradoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpublicacionDataGridViewTextBoxColumn,
            this.desrcipcionDataGridViewTextBoxColumn,
            this.fechapublicacionDataGridViewTextBoxColumn,
            this.fechavencimientoDataGridViewTextBoxColumn,
            this.fechaespectaculoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.domcalleDataGridViewTextBoxColumn,
            this.numcalleDataGridViewTextBoxColumn,
            this.codpostalDataGridViewTextBoxColumn,
            this.idempresaDataGridViewTextBoxColumn,
            this.rubroidDataGridViewTextBoxColumn,
            this.gradoidDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.tblGradoBusqueda.DataSource = this.publicacionBindingSource1;
            this.tblGradoBusqueda.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.tblGradoBusqueda.Location = new System.Drawing.Point(38, 237);
            this.tblGradoBusqueda.Name = "tblGradoBusqueda";
            this.tblGradoBusqueda.RowTemplate.Height = 24;
            this.tblGradoBusqueda.Size = new System.Drawing.Size(343, 208);
            this.tblGradoBusqueda.TabIndex = 42;
            // 
            // btnPublicacionLimpiar
            // 
            this.btnPublicacionLimpiar.Location = new System.Drawing.Point(21, 177);
            this.btnPublicacionLimpiar.Name = "btnPublicacionLimpiar";
            this.btnPublicacionLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnPublicacionLimpiar.TabIndex = 41;
            this.btnPublicacionLimpiar.Text = "Limpiar";
            this.btnPublicacionLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnPublicacionBuscar
            // 
            this.btnPublicacionBuscar.Location = new System.Drawing.Point(324, 177);
            this.btnPublicacionBuscar.Name = "btnPublicacionBuscar";
            this.btnPublicacionBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnPublicacionBuscar.TabIndex = 40;
            this.btnPublicacionBuscar.Text = "Buscar";
            this.btnPublicacionBuscar.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(575, 553);
            this.shapeContainer1.TabIndex = 50;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(23, 51);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(390, 110);
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicacionBindingSource
            // 
            this.publicacionBindingSource.DataMember = "Publicacion";
            this.publicacionBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // publicacionTableAdapter
            // 
            this.publicacionTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionBindingSource1
            // 
            this.publicacionBindingSource1.DataMember = "Publicacion";
            this.publicacionBindingSource1.DataSource = this.gD2C2018DataSet;
            // 
            // idpublicacionDataGridViewTextBoxColumn
            // 
            this.idpublicacionDataGridViewTextBoxColumn.DataPropertyName = "id_publicacion";
            this.idpublicacionDataGridViewTextBoxColumn.HeaderText = "id_publicacion";
            this.idpublicacionDataGridViewTextBoxColumn.Name = "idpublicacionDataGridViewTextBoxColumn";
            // 
            // desrcipcionDataGridViewTextBoxColumn
            // 
            this.desrcipcionDataGridViewTextBoxColumn.DataPropertyName = "desrcipcion";
            this.desrcipcionDataGridViewTextBoxColumn.HeaderText = "desrcipcion";
            this.desrcipcionDataGridViewTextBoxColumn.Name = "desrcipcionDataGridViewTextBoxColumn";
            // 
            // fechapublicacionDataGridViewTextBoxColumn
            // 
            this.fechapublicacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_publicacion";
            this.fechapublicacionDataGridViewTextBoxColumn.HeaderText = "fecha_publicacion";
            this.fechapublicacionDataGridViewTextBoxColumn.Name = "fechapublicacionDataGridViewTextBoxColumn";
            // 
            // fechavencimientoDataGridViewTextBoxColumn
            // 
            this.fechavencimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_vencimiento";
            this.fechavencimientoDataGridViewTextBoxColumn.HeaderText = "fecha_vencimiento";
            this.fechavencimientoDataGridViewTextBoxColumn.Name = "fechavencimientoDataGridViewTextBoxColumn";
            // 
            // fechaespectaculoDataGridViewTextBoxColumn
            // 
            this.fechaespectaculoDataGridViewTextBoxColumn.DataPropertyName = "fecha_espectaculo";
            this.fechaespectaculoDataGridViewTextBoxColumn.HeaderText = "fecha_espectaculo";
            this.fechaespectaculoDataGridViewTextBoxColumn.Name = "fechaespectaculoDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
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
            // codpostalDataGridViewTextBoxColumn
            // 
            this.codpostalDataGridViewTextBoxColumn.DataPropertyName = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.HeaderText = "cod_postal";
            this.codpostalDataGridViewTextBoxColumn.Name = "codpostalDataGridViewTextBoxColumn";
            // 
            // idempresaDataGridViewTextBoxColumn
            // 
            this.idempresaDataGridViewTextBoxColumn.DataPropertyName = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.HeaderText = "id_empresa";
            this.idempresaDataGridViewTextBoxColumn.Name = "idempresaDataGridViewTextBoxColumn";
            // 
            // rubroidDataGridViewTextBoxColumn
            // 
            this.rubroidDataGridViewTextBoxColumn.DataPropertyName = "rubro_id";
            this.rubroidDataGridViewTextBoxColumn.HeaderText = "rubro_id";
            this.rubroidDataGridViewTextBoxColumn.Name = "rubroidDataGridViewTextBoxColumn";
            // 
            // gradoidDataGridViewTextBoxColumn
            // 
            this.gradoidDataGridViewTextBoxColumn.DataPropertyName = "grado_id";
            this.gradoidDataGridViewTextBoxColumn.HeaderText = "grado_id";
            this.gradoidDataGridViewTextBoxColumn.Name = "gradoidDataGridViewTextBoxColumn";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // listarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 553);
            this.Controls.Add(this.txtListPublicacionId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListPublicacionNombre);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.l);
            this.Controls.Add(this.tblGradoBusqueda);
            this.Controls.Add(this.btnPublicacionLimpiar);
            this.Controls.Add(this.btnPublicacionBuscar);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "listarPublicacion";
            this.Text = "listarPublicacion";
            this.Load += new System.EventHandler(this.listarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListPublicacionId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListPublicacionNombre;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView tblGradoBusqueda;
        private System.Windows.Forms.Button btnPublicacionLimpiar;
        private System.Windows.Forms.Button btnPublicacionBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource publicacionBindingSource;
        private GD2C2018DataSetTableAdapters.PublicacionTableAdapter publicacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desrcipcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaespectaculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.BindingSource publicacionBindingSource1;
    }
}