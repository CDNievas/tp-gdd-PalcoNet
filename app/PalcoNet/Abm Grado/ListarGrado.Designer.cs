namespace PalcoNet.Abm_Grado
{
    partial class ListarGrado
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
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoBuscar = new System.Windows.Forms.Button();
            this.lblGradoID = new System.Windows.Forms.Label();
            this.txtbGradoID = new System.Windows.Forms.TextBox();
            this.lblGradoComision = new System.Windows.Forms.Label();
            this.numGradoId = new System.Windows.Forms.NumericUpDown();
            this.tblGradoBusqueda = new System.Windows.Forms.DataGridView();
            this.ColumnDescripcionGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIDGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComisionGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numGradoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(232, 163);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 19;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGradoBuscar
            // 
            this.btnGradoBuscar.Location = new System.Drawing.Point(348, 163);
            this.btnGradoBuscar.Name = "btnGradoBuscar";
            this.btnGradoBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoBuscar.TabIndex = 18;
            this.btnGradoBuscar.Text = "Buscar";
            this.btnGradoBuscar.UseVisualStyleBackColor = true;
            // 
            // lblGradoID
            // 
            this.lblGradoID.AutoSize = true;
            this.lblGradoID.Location = new System.Drawing.Point(59, 42);
            this.lblGradoID.Name = "lblGradoID";
            this.lblGradoID.Size = new System.Drawing.Size(69, 17);
            this.lblGradoID.TabIndex = 20;
            this.lblGradoID.Text = "Grado ID:";
            // 
            // txtbGradoID
            // 
            this.txtbGradoID.Location = new System.Drawing.Point(175, 42);
            this.txtbGradoID.Name = "txtbGradoID";
            this.txtbGradoID.Size = new System.Drawing.Size(123, 22);
            this.txtbGradoID.TabIndex = 21;
            // 
            // lblGradoComision
            // 
            this.lblGradoComision.AutoSize = true;
            this.lblGradoComision.Location = new System.Drawing.Point(59, 91);
            this.lblGradoComision.Name = "lblGradoComision";
            this.lblGradoComision.Size = new System.Drawing.Size(113, 17);
            this.lblGradoComision.TabIndex = 22;
            this.lblGradoComision.Text = "Grado Comision:";
            // 
            // numGradoId
            // 
            this.numGradoId.Location = new System.Drawing.Point(178, 91);
            this.numGradoId.Name = "numGradoId";
            this.numGradoId.Size = new System.Drawing.Size(120, 22);
            this.numGradoId.TabIndex = 23;
            // 
            // tblGradoBusqueda
            // 
            this.tblGradoBusqueda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblGradoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblGradoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDescripcionGrado,
            this.columnIDGrado,
            this.columnComisionGrado});
            this.tblGradoBusqueda.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.tblGradoBusqueda.Location = new System.Drawing.Point(45, 223);
            this.tblGradoBusqueda.Name = "tblGradoBusqueda";
            this.tblGradoBusqueda.RowTemplate.Height = 24;
            this.tblGradoBusqueda.Size = new System.Drawing.Size(332, 65);
            this.tblGradoBusqueda.TabIndex = 24;
            // 
            // ColumnDescripcionGrado
            // 
            this.ColumnDescripcionGrado.HeaderText = "descripcion";
            this.ColumnDescripcionGrado.Name = "ColumnDescripcionGrado";
            // 
            // columnIDGrado
            // 
            this.columnIDGrado.HeaderText = "ID";
            this.columnIDGrado.Name = "columnIDGrado";
            // 
            // columnComisionGrado
            // 
            this.columnComisionGrado.HeaderText = "comision";
            this.columnComisionGrado.Name = "columnComisionGrado";
            // 
            // ListarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 334);
            this.Controls.Add(this.tblGradoBusqueda);
            this.Controls.Add(this.numGradoId);
            this.Controls.Add(this.lblGradoComision);
            this.Controls.Add(this.txtbGradoID);
            this.Controls.Add(this.lblGradoID);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoBuscar);
            this.Name = "ListarGrado";
            this.Text = "ListarGrado";
            ((System.ComponentModel.ISupportInitialize)(this.numGradoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGradoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoBuscar;
        private System.Windows.Forms.Label lblGradoID;
        private System.Windows.Forms.TextBox txtbGradoID;
        private System.Windows.Forms.Label lblGradoComision;
        private System.Windows.Forms.NumericUpDown numGradoId;
        private System.Windows.Forms.DataGridView tblGradoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcionGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnComisionGrado;
    }
}