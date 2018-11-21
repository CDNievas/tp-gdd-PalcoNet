namespace PalcoNet.Abm_Rol
{
    partial class listadoRol
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
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tblGradoBusqueda = new System.Windows.Forms.DataGridView();
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoBuscar = new System.Windows.Forms.Button();
            this.columnIDGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtRolAlta = new System.Windows.Forms.TextBox();
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(405, 289);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(88, 30);
            this.btnBaja.TabIndex = 34;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(405, 224);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(88, 30);
            this.btnMod.TabIndex = 33;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Listar Rol";
            // 
            // tblGradoBusqueda
            // 
            this.tblGradoBusqueda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblGradoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGradoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDGrado,
            this.habilitado,
            this.funcionalidades,
            this.seleccionar});
            this.tblGradoBusqueda.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.tblGradoBusqueda.Location = new System.Drawing.Point(39, 224);
            this.tblGradoBusqueda.Name = "tblGradoBusqueda";
            this.tblGradoBusqueda.RowTemplate.Height = 24;
            this.tblGradoBusqueda.Size = new System.Drawing.Size(343, 208);
            this.tblGradoBusqueda.TabIndex = 31;
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(22, 164);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 30;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGradoBuscar
            // 
            this.btnGradoBuscar.Location = new System.Drawing.Point(325, 164);
            this.btnGradoBuscar.Name = "btnGradoBuscar";
            this.btnGradoBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoBuscar.TabIndex = 29;
            this.btnGradoBuscar.Text = "Buscar";
            this.btnGradoBuscar.UseVisualStyleBackColor = true;
            // 
            // columnIDGrado
            // 
            this.columnIDGrado.HeaderText = "ID";
            this.columnIDGrado.Name = "columnIDGrado";
            // 
            // habilitado
            // 
            this.habilitado.HeaderText = "habilitado";
            this.habilitado.Name = "habilitado";
            // 
            // funcionalidades
            // 
            this.funcionalidades.HeaderText = "Column1";
            this.funcionalidades.Name = "funcionalidades";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "seleccionar";
            this.seleccionar.Name = "seleccionar";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(31, 42);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(369, 98);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(515, 498);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // txtRolAlta
            // 
            this.txtRolAlta.Location = new System.Drawing.Point(151, 77);
            this.txtRolAlta.Name = "txtRolAlta";
            this.txtRolAlta.Size = new System.Drawing.Size(115, 22);
            this.txtRolAlta.TabIndex = 37;
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(52, 77);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(62, 17);
            this.lblRolNombre.TabIndex = 36;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "id:";
            // 
            // listadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 498);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRolAlta);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tblGradoBusqueda);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoBuscar);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "listadoRol";
            this.Text = "listadoRol";
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblGradoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoBuscar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtRolAlta;
        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}