namespace PalcoNet.Abm_Rol
{
    partial class ListadoRol
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2018DataSet = new PalcoNet.GD2C2018DataSet();
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoBuscar = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.rolTableAdapter = new PalcoNet.GD2C2018DataSetTableAdapters.RolTableAdapter();
            this.rolesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(306, 370);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(87, 24);
            this.btnBaja.TabIndex = 34;
            this.btnBaja.Text = "Deshabilitar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(51, 370);
            this.btnMod.Margin = new System.Windows.Forms.Padding(2);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(66, 24);
            this.btnMod.TabIndex = 33;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Listar Rol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.gD2C2018DataSet;
            // 
            // gD2C2018DataSet
            // 
            this.gD2C2018DataSet.DataSetName = "GD2C2018DataSet";
            this.gD2C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(287, 53);
            this.btnGradoLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnGradoLimpiar.TabIndex = 30;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            this.btnGradoLimpiar.Click += new System.EventHandler(this.btnGradoLimpiar_Click);
            // 
            // btnGradoBuscar
            // 
            this.btnGradoBuscar.Location = new System.Drawing.Point(420, 53);
            this.btnGradoBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGradoBuscar.Name = "btnGradoBuscar";
            this.btnGradoBuscar.Size = new System.Drawing.Size(66, 24);
            this.btnGradoBuscar.TabIndex = 29;
            this.btnGradoBuscar.Text = "Buscar";
            this.btnGradoBuscar.UseVisualStyleBackColor = true;
            this.btnGradoBuscar.Click += new System.EventHandler(this.btnGradoBuscar_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(17, 42);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(670, 44);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(703, 405);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 56);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(48, 59);
            this.lblRolNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(47, 13);
            this.lblRolNombre.TabIndex = 36;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // rolesDataGrid
            // 
            this.rolesDataGrid.AllowUserToAddRows = false;
            this.rolesDataGrid.AllowUserToDeleteRows = false;
            this.rolesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGrid.Location = new System.Drawing.Point(17, 96);
            this.rolesDataGrid.Name = "rolesDataGrid";
            this.rolesDataGrid.ReadOnly = true;
            this.rolesDataGrid.Size = new System.Drawing.Size(671, 260);
            this.rolesDataGrid.TabIndex = 38;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(460, 370);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 24);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(173, 370);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 40;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 405);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rolesDataGrid);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoBuscar);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListadoRol";
            this.Text = "listadoRol";
            this.Load += new System.EventHandler(this.listadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoBuscar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRolNombre;
        private GD2C2018DataSet gD2C2018DataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private GD2C2018DataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.DataGridView rolesDataGrid;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnHabilitar;
    }
}