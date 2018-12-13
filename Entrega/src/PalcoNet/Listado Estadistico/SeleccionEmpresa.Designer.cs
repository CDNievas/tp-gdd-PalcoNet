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
            this.btnAccept = new System.Windows.Forms.Button();
            this.empresasDataGrid = new System.Windows.Forms.DataGridView();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresaCuit = new System.Windows.Forms.Label();
            this.btnPagSig = new System.Windows.Forms.Button();
            this.btnPagAnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(565, 434);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // empresasDataGrid
            // 
            this.empresasDataGrid.AllowUserToAddRows = false;
            this.empresasDataGrid.AllowUserToDeleteRows = false;
            this.empresasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresasDataGrid.Location = new System.Drawing.Point(12, 99);
            this.empresasDataGrid.Name = "empresasDataGrid";
            this.empresasDataGrid.ReadOnly = true;
            this.empresasDataGrid.Size = new System.Drawing.Size(659, 305);
            this.empresasDataGrid.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(337, 18);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(421, 52);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 32);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(168, 52);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(530, 21);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 20);
            this.txtMail.TabIndex = 26;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(112, 18);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(143, 20);
            this.txtRazonSocial.TabIndex = 25;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(28, 21);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 24;
            this.lblRazonSocial.Text = "Razón social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "E- mail";
            // 
            // lblEmpresaCuit
            // 
            this.lblEmpresaCuit.AutoSize = true;
            this.lblEmpresaCuit.Location = new System.Drawing.Point(290, 21);
            this.lblEmpresaCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresaCuit.Name = "lblEmpresaCuit";
            this.lblEmpresaCuit.Size = new System.Drawing.Size(32, 13);
            this.lblEmpresaCuit.TabIndex = 30;
            this.lblEmpresaCuit.Text = "CUIT";
            // 
            // btnPagSig
            // 
            this.btnPagSig.Location = new System.Drawing.Point(337, 434);
            this.btnPagSig.Name = "btnPagSig";
            this.btnPagSig.Size = new System.Drawing.Size(103, 23);
            this.btnPagSig.TabIndex = 33;
            this.btnPagSig.Text = "Pág. Siguiente";
            this.btnPagSig.UseVisualStyleBackColor = true;
            this.btnPagSig.Click += new System.EventHandler(this.btnPagSig_Click);
            // 
            // btnPagAnt
            // 
            this.btnPagAnt.Location = new System.Drawing.Point(168, 434);
            this.btnPagAnt.Name = "btnPagAnt";
            this.btnPagAnt.Size = new System.Drawing.Size(98, 23);
            this.btnPagAnt.TabIndex = 32;
            this.btnPagAnt.Text = "Pág. Anterior";
            this.btnPagAnt.UseVisualStyleBackColor = true;
            this.btnPagAnt.Click += new System.EventHandler(this.btnPagAnt_Click);
            // 
            // SeleccionEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 469);
            this.Controls.Add(this.btnPagSig);
            this.Controls.Add(this.btnPagAnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpresaCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.empresasDataGrid);
            this.Controls.Add(this.btnAccept);
            this.Name = "SeleccionEmpresa";
            this.Text = "SeleccionEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.empresasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView empresasDataGrid;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresaCuit;
        private System.Windows.Forms.Button btnPagSig;
        private System.Windows.Forms.Button btnPagAnt;
    }
}