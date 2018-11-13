namespace PalcoNet.Abm_Grado
{
    partial class ActualizarGrado
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
            this.lblGradoComision = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGradoLimpiar = new System.Windows.Forms.Button();
            this.btnGradoBuscar = new System.Windows.Forms.Button();
            this.nGradoComision = new System.Windows.Forms.NumericUpDown();
            this.lblGradoID = new System.Windows.Forms.Label();
            this.txtGradoID = new System.Windows.Forms.TextBox();
            this.btnGradoModificar = new System.Windows.Forms.Button();
            this.lblGradoDescripcion = new System.Windows.Forms.Label();
            this.txtGradoDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nGradoComision)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGradoComision
            // 
            this.lblGradoComision.AutoSize = true;
            this.lblGradoComision.Location = new System.Drawing.Point(35, 100);
            this.lblGradoComision.Name = "lblGradoComision";
            this.lblGradoComision.Size = new System.Drawing.Size(69, 17);
            this.lblGradoComision.TabIndex = 0;
            this.lblGradoComision.Text = "Comision:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnGradoLimpiar
            // 
            this.btnGradoLimpiar.Location = new System.Drawing.Point(240, 268);
            this.btnGradoLimpiar.Name = "btnGradoLimpiar";
            this.btnGradoLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoLimpiar.TabIndex = 21;
            this.btnGradoLimpiar.Text = "Limpiar";
            this.btnGradoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGradoBuscar
            // 
            this.btnGradoBuscar.Location = new System.Drawing.Point(257, 34);
            this.btnGradoBuscar.Name = "btnGradoBuscar";
            this.btnGradoBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoBuscar.TabIndex = 20;
            this.btnGradoBuscar.Text = "Buscar";
            this.btnGradoBuscar.UseVisualStyleBackColor = true;
            // 
            // nGradoComision
            // 
            this.nGradoComision.Location = new System.Drawing.Point(126, 100);
            this.nGradoComision.Name = "nGradoComision";
            this.nGradoComision.Size = new System.Drawing.Size(120, 22);
            this.nGradoComision.TabIndex = 22;
            // 
            // lblGradoID
            // 
            this.lblGradoID.AutoSize = true;
            this.lblGradoID.Location = new System.Drawing.Point(35, 38);
            this.lblGradoID.Name = "lblGradoID";
            this.lblGradoID.Size = new System.Drawing.Size(25, 17);
            this.lblGradoID.TabIndex = 23;
            this.lblGradoID.Text = "ID:";
            // 
            // txtGradoID
            // 
            this.txtGradoID.Location = new System.Drawing.Point(126, 38);
            this.txtGradoID.Name = "txtGradoID";
            this.txtGradoID.Size = new System.Drawing.Size(100, 22);
            this.txtGradoID.TabIndex = 24;
            // 
            // btnGradoModificar
            // 
            this.btnGradoModificar.Location = new System.Drawing.Point(343, 268);
            this.btnGradoModificar.Name = "btnGradoModificar";
            this.btnGradoModificar.Size = new System.Drawing.Size(88, 30);
            this.btnGradoModificar.TabIndex = 25;
            this.btnGradoModificar.Text = "modificar";
            this.btnGradoModificar.UseVisualStyleBackColor = true;
            // 
            // lblGradoDescripcion
            // 
            this.lblGradoDescripcion.AutoSize = true;
            this.lblGradoDescripcion.Location = new System.Drawing.Point(35, 162);
            this.lblGradoDescripcion.Name = "lblGradoDescripcion";
            this.lblGradoDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblGradoDescripcion.TabIndex = 26;
            this.lblGradoDescripcion.Text = "Descripcion:";
            // 
            // txtGradoDescripcion
            // 
            this.txtGradoDescripcion.Location = new System.Drawing.Point(126, 157);
            this.txtGradoDescripcion.Multiline = true;
            this.txtGradoDescripcion.Name = "txtGradoDescripcion";
            this.txtGradoDescripcion.Size = new System.Drawing.Size(202, 91);
            this.txtGradoDescripcion.TabIndex = 27;
            // 
            // ActualizarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 342);
            this.Controls.Add(this.txtGradoDescripcion);
            this.Controls.Add(this.lblGradoDescripcion);
            this.Controls.Add(this.btnGradoModificar);
            this.Controls.Add(this.txtGradoID);
            this.Controls.Add(this.lblGradoID);
            this.Controls.Add(this.nGradoComision);
            this.Controls.Add(this.btnGradoLimpiar);
            this.Controls.Add(this.btnGradoBuscar);
            this.Controls.Add(this.lblGradoComision);
            this.Name = "ActualizarGrado";
            this.Text = "ActualizarGrado";
            ((System.ComponentModel.ISupportInitialize)(this.nGradoComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradoComision;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnGradoLimpiar;
        private System.Windows.Forms.Button btnGradoBuscar;
        private System.Windows.Forms.NumericUpDown nGradoComision;
        private System.Windows.Forms.Label lblGradoID;
        private System.Windows.Forms.TextBox txtGradoID;
        private System.Windows.Forms.Button btnGradoModificar;
        private System.Windows.Forms.Label lblGradoDescripcion;
        private System.Windows.Forms.TextBox txtGradoDescripcion;
    }
}