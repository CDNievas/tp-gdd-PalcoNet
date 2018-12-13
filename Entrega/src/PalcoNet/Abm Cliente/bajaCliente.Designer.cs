namespace PalcoNet.Abm_Cliente
{
    partial class bajaCliente
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
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.btnClienteLimpiar = new System.Windows.Forms.Button();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.btnClienteLimpiar);
            this.Filtros.Controls.Add(this.btnClienteBuscar);
            this.Filtros.Controls.Add(this.txtMail);
            this.Filtros.Controls.Add(this.txtDNI);
            this.Filtros.Controls.Add(this.txtApellido);
            this.Filtros.Controls.Add(this.txtNombre);
            this.Filtros.Controls.Add(this.lblMail);
            this.Filtros.Controls.Add(this.lblDNI);
            this.Filtros.Controls.Add(this.lblApellido);
            this.Filtros.Controls.Add(this.lblNombre);
            this.Filtros.Location = new System.Drawing.Point(43, 101);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(655, 188);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            // 
            // btnClienteLimpiar
            // 
            this.btnClienteLimpiar.Location = new System.Drawing.Point(97, 146);
            this.btnClienteLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnClienteLimpiar.TabIndex = 1;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Location = new System.Drawing.Point(463, 146);
            this.btnClienteBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Size = new System.Drawing.Size(66, 24);
            this.btnClienteBuscar.TabIndex = 2;
            this.btnClienteBuscar.Text = "Buscar";
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(377, 87);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(115, 84);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(155, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(377, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(152, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(332, 90);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 23);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "E-mail:";
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(63, 84);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(100, 23);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(332, 35);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baja cliente";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgClientes.Location = new System.Drawing.Point(48, 336);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersVisible = false;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(650, 176);
            this.dgClientes.TabIndex = 13;
            // 
            // bajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 569);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.label2);
            this.Name = "bajaCliente";
            this.Text = "Baja de Cliente";
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnClienteLimpiar;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.GroupBox Filtros;
        public System.Windows.Forms.DataGridView dgClientes;
    }
}