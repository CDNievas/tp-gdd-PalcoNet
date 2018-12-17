namespace PalcoNet.Listado_Estadistico
{
    partial class SeleccionEmpresa
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
            this.botonAccept = new System.Windows.Forms.Button();
            this.empresaDataGrid = new System.Windows.Forms.DataGridView();
            this.textCuit = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.labelEmpresaCuit = new System.Windows.Forms.Label();
            this.botonPagSig = new System.Windows.Forms.Button();
            this.botonPagAnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.botonAccept.Location = new System.Drawing.Point(565, 434);
            this.botonAccept.Name = "btnAccept";
            this.botonAccept.Size = new System.Drawing.Size(75, 23);
            this.botonAccept.TabIndex = 0;
            this.botonAccept.Text = "Aceptar";
            this.botonAccept.UseVisualStyleBackColor = true;
            this.botonAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // empresasDataGrid
            // 
            this.empresaDataGrid.AllowUserToAddRows = false;
            this.empresaDataGrid.AllowUserToDeleteRows = false;
            this.empresaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresaDataGrid.Location = new System.Drawing.Point(12, 99);
            this.empresaDataGrid.Name = "empresasDataGrid";
            this.empresaDataGrid.ReadOnly = true;
            this.empresaDataGrid.Size = new System.Drawing.Size(659, 305);
            this.empresaDataGrid.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.textCuit.Location = new System.Drawing.Point(337, 18);
            this.textCuit.Name = "txtCuit";
            this.textCuit.Size = new System.Drawing.Size(100, 20);
            this.textCuit.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(421, 52);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.botonBuscar.Name = "btnBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 32);
            this.botonBuscar.TabIndex = 28;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(168, 52);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.botonLimpiar.Name = "btnLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 32);
            this.botonLimpiar.TabIndex = 27;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtMail
            // 
            this.textMail.Location = new System.Drawing.Point(530, 21);
            this.textMail.Margin = new System.Windows.Forms.Padding(2);
            this.textMail.Name = "txtMail";
            this.textMail.Size = new System.Drawing.Size(125, 20);
            this.textMail.TabIndex = 26;
            // 
            // txtRazonSocial
            // 
            this.textRazonSocial.Location = new System.Drawing.Point(112, 18);
            this.textRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.textRazonSocial.Name = "txtRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(143, 20);
            this.textRazonSocial.TabIndex = 25;
            // 
            // lblRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(28, 21);
            this.labelRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRazonSocial.Name = "lblRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.labelRazonSocial.TabIndex = 24;
            this.labelRazonSocial.Text = "Razón social";
            // 
            // label2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(472, 24);
            this.lbl2.Name = "label2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "E- mail";
            // 
            // lblEmpresaCuit
            // 
            this.labelEmpresaCuit.AutoSize = true;
            this.labelEmpresaCuit.Location = new System.Drawing.Point(290, 21);
            this.labelEmpresaCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmpresaCuit.Name = "lblEmpresaCuit";
            this.labelEmpresaCuit.Size = new System.Drawing.Size(32, 13);
            this.labelEmpresaCuit.TabIndex = 30;
            this.labelEmpresaCuit.Text = "CUIT";
            // 
            // btnPagSig
            // 
            this.botonPagSig.Location = new System.Drawing.Point(337, 434);
            this.botonPagSig.Name = "btnPagSig";
            this.botonPagSig.Size = new System.Drawing.Size(103, 23);
            this.botonPagSig.TabIndex = 33;
            this.botonPagSig.Text = "Pág. Siguiente";
            this.botonPagSig.UseVisualStyleBackColor = true;
            this.botonPagSig.Click += new System.EventHandler(this.btnPagSig_Click);
            // 
            // btnPagAnt
            // 
            this.botonPagAnt.Location = new System.Drawing.Point(168, 434);
            this.botonPagAnt.Name = "btnPagAnt";
            this.botonPagAnt.Size = new System.Drawing.Size(98, 23);
            this.botonPagAnt.TabIndex = 32;
            this.botonPagAnt.Text = "Pág. Anterior";
            this.botonPagAnt.UseVisualStyleBackColor = true;
            this.botonPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click);
            // 
            // SeleccionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 469);
            this.Controls.Add(this.botonPagSig);
            this.Controls.Add(this.botonPagAnt);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.labelEmpresaCuit);
            this.Controls.Add(this.textCuit);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.textRazonSocial);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.empresaDataGrid);
            this.Controls.Add(this.botonAccept);
            this.Name = "SeleccionEmpresa";
            this.Text = "SeleccionEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAccept;
        private System.Windows.Forms.DataGridView empresaDataGrid;
        private System.Windows.Forms.TextBox textCuit;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label labelEmpresaCuit;
        private System.Windows.Forms.Button botonPagSig;
        private System.Windows.Forms.Button botonPagAnt;
    }
}