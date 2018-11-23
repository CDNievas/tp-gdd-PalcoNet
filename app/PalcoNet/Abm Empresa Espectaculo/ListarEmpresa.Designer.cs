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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblEmpresaCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.btnEmpresaBaja = new System.Windows.Forms.Button();
            this.btnEmpresaMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.empresaTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.EmpresaTableAdapter();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.btnPagAnt = new System.Windows.Forms.Button();
            this.btnPagSig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(423, 87);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 87);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(506, 50);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 20);
            this.txtMail.TabIndex = 19;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(121, 50);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(143, 20);
            this.txtRazonSocial.TabIndex = 18;
            // 
            // lblEmpresaCuit
            // 
            this.lblEmpresaCuit.AutoSize = true;
            this.lblEmpresaCuit.Location = new System.Drawing.Point(279, 53);
            this.lblEmpresaCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresaCuit.Name = "lblEmpresaCuit";
            this.lblEmpresaCuit.Size = new System.Drawing.Size(32, 13);
            this.lblEmpresaCuit.TabIndex = 17;
            this.lblEmpresaCuit.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(49, 53);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 16;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // btnEmpresaBaja
            // 
            this.btnEmpresaBaja.Location = new System.Drawing.Point(694, 276);
            this.btnEmpresaBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpresaBaja.Name = "btnEmpresaBaja";
            this.btnEmpresaBaja.Size = new System.Drawing.Size(75, 37);
            this.btnEmpresaBaja.TabIndex = 15;
            this.btnEmpresaBaja.Text = "Baja";
            this.btnEmpresaBaja.UseVisualStyleBackColor = true;
            // 
            // btnEmpresaMod
            // 
            this.btnEmpresaMod.Location = new System.Drawing.Point(694, 220);
            this.btnEmpresaMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpresaMod.Name = "btnEmpresaMod";
            this.btnEmpresaMod.Size = new System.Drawing.Size(75, 37);
            this.btnEmpresaMod.TabIndex = 14;
            this.btnEmpresaMod.Text = "Modificar";
            this.btnEmpresaMod.UseVisualStyleBackColor = true;
            this.btnEmpresaMod.Click += new System.EventHandler(this.btnEmpresaMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrar Empresa";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(804, 511);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(35, 33);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(638, 96);
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(316, 50);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "E- mail";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(694, 168);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 37);
            this.btnNueva.TabIndex = 25;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            // 
            // empresasDataGrid
            // 
            this.empresasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresasDataGrid.Location = new System.Drawing.Point(35, 144);
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.Size = new System.Drawing.Size(639, 298);
            this.empresasDataGrid.TabIndex = 26;
            // 
            // btnPagAnt
            // 
            this.btnPagAnt.Location = new System.Drawing.Point(92, 467);
            this.btnPagAnt.Name = "btnPagAnt";
            this.btnPagAnt.Size = new System.Drawing.Size(98, 23);
            this.btnPagAnt.TabIndex = 27;
            this.btnPagAnt.Text = "Pág. Anterior";
            this.btnPagAnt.UseVisualStyleBackColor = true;
            this.btnPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click);
            // 
            // btnPagSig
            // 
            this.btnPagSig.Location = new System.Drawing.Point(541, 467);
            this.btnPagSig.Name = "btnPagSig";
            this.btnPagSig.Size = new System.Drawing.Size(103, 23);
            this.btnPagSig.TabIndex = 28;
            this.btnPagSig.Text = "Pág. Siguiente";
            this.btnPagSig.UseVisualStyleBackColor = true;
            this.btnPagSig.Click += new System.EventHandler(this.btnPagSig_Click);
            // 
            // ListarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.btnPagSig);
            this.Controls.Add(this.btnPagAnt);
            this.Controls.Add(this.empresasDataGrid);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblEmpresaCuit);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.btnEmpresaBaja);
            this.Controls.Add(this.btnEmpresaMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListarEmpresa";
            this.Text = "ListarEmpresa";
            this.Load += new System.EventHandler(this.ListarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblEmpresaCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Button btnEmpresaBaja;
        private System.Windows.Forms.Button btnEmpresaMod;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private GD2C2018DataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.Button btnPagAnt;
        private System.Windows.Forms.Button btnPagSig;
    }
}