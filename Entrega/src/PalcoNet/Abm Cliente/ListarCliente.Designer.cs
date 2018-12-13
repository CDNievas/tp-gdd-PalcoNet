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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteMod = new System.Windows.Forms.Button();
            this.btnClienteBaja = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClienteDoc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.ClienteTableAdapter();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnPagAnt = new System.Windows.Forms.Button();
            this.btnPagSig = new System.Windows.Forms.Button();
            this.clientesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 26);
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
            this.shapeContainer1.Size = new System.Drawing.Size(1155, 784);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(39, 80);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(690, 106);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar Clientes";
            // 
            // btnClienteMod
            // 
            this.btnClienteMod.Location = new System.Drawing.Point(1020, 361);
            this.btnClienteMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteMod.Name = "btnClienteMod";
            this.btnClienteMod.Size = new System.Drawing.Size(100, 46);
            this.btnClienteMod.TabIndex = 4;
            this.btnClienteMod.Text = "Modificar";
            this.btnClienteMod.UseVisualStyleBackColor = true;
            this.btnClienteMod.Click += new System.EventHandler(this.btnClienteMod_Click);
            // 
            // btnClienteBaja
            // 
            this.btnClienteBaja.Location = new System.Drawing.Point(1020, 447);
            this.btnClienteBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteBaja.Name = "btnClienteBaja";
            this.btnClienteBaja.Size = new System.Drawing.Size(100, 46);
            this.btnClienteBaja.TabIndex = 5;
            this.btnClienteBaja.Text = "Baja";
            this.btnClienteBaja.UseVisualStyleBackColor = true;
            this.btnClienteBaja.Click += new System.EventHandler(this.btnClienteBaja_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClienteDoc
            // 
            this.lblClienteDoc.AutoSize = true;
            this.lblClienteDoc.Location = new System.Drawing.Point(67, 145);
            this.lblClienteDoc.Name = "lblClienteDoc";
            this.lblClienteDoc.Size = new System.Drawing.Size(80, 17);
            this.lblClienteDoc.TabIndex = 7;
            this.lblClienteDoc.Text = "Documento";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 108);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(159, 142);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(144, 22);
            this.txtDocumento.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(215, 185);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 39);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar filtros";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 185);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 39);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(389, 112);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(389, 145);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 17);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "E-mail";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(469, 112);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 22);
            this.txtApellido.TabIndex = 14;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(469, 145);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 22);
            this.txtMail.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1020, 277);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 46);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Crear nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnPagAnt
            // 
            this.btnPagAnt.Location = new System.Drawing.Point(71, 726);
            this.btnPagAnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagAnt.Name = "btnPagAnt";
            this.btnPagAnt.Size = new System.Drawing.Size(147, 28);
            this.btnPagAnt.TabIndex = 17;
            this.btnPagAnt.Text = "Pág. anterior";
            this.btnPagAnt.UseVisualStyleBackColor = true;
            this.btnPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click);
            // 
            // btnPagSig
            // 
            this.btnPagSig.Location = new System.Drawing.Point(809, 726);
            this.btnPagSig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagSig.Name = "btnPagSig";
            this.btnPagSig.Size = new System.Drawing.Size(144, 28);
            this.btnPagSig.TabIndex = 18;
            this.btnPagSig.Text = "Pág. Siguiente";
            this.btnPagSig.UseVisualStyleBackColor = true;
            this.btnPagSig.Click += new System.EventHandler(this.btnPagSig_Click);
            // 
            // clientesDataGrid
            // 
            this.clientesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGrid.Location = new System.Drawing.Point(48, 263);
            this.clientesDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientesDataGrid.Name = "clientesDataGrid";
            this.clientesDataGrid.Size = new System.Drawing.Size(920, 404);
            this.clientesDataGrid.TabIndex = 19;
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 784);
            this.Controls.Add(this.clientesDataGrid);
            this.Controls.Add(this.btnPagSig);
            this.Controls.Add(this.btnPagAnt);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblClienteDoc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnClienteBaja);
            this.Controls.Add(this.btnClienteMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClienteMod;
        private System.Windows.Forms.Button btnClienteBaja;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClienteDoc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private GD2C2018DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnPagAnt;
        private System.Windows.Forms.Button btnPagSig;
        private System.Windows.Forms.DataGridView clientesDataGrid;
    }
}