namespace PalcoNet.Generar_Rendicion_Comisiones
{
    partial class GenerarRendiciones
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
            this.groupBoxRendirComisiones = new System.Windows.Forms.GroupBox();
            this.dataGridViewRendirComisiones = new System.Windows.Forms.DataGridView();
            this.btnRendirComisiones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRendirComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendirComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRendirComisiones
            // 
            this.groupBoxRendirComisiones.Controls.Add(this.label1);
            this.groupBoxRendirComisiones.Controls.Add(this.dataGridViewRendirComisiones);
            this.groupBoxRendirComisiones.Location = new System.Drawing.Point(48, 27);
            this.groupBoxRendirComisiones.Name = "groupBoxRendirComisiones";
            this.groupBoxRendirComisiones.Size = new System.Drawing.Size(822, 439);
            this.groupBoxRendirComisiones.TabIndex = 0;
            this.groupBoxRendirComisiones.TabStop = false;
            this.groupBoxRendirComisiones.Text = "Rendicion de Comisiones";
            // 
            // dataGridViewRendirComisiones
            // 
            this.dataGridViewRendirComisiones.AllowUserToAddRows = false;
            this.dataGridViewRendirComisiones.AllowUserToDeleteRows = false;
            this.dataGridViewRendirComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRendirComisiones.Location = new System.Drawing.Point(29, 63);
            this.dataGridViewRendirComisiones.Name = "dataGridViewRendirComisiones";
            this.dataGridViewRendirComisiones.ReadOnly = true;
            this.dataGridViewRendirComisiones.Size = new System.Drawing.Size(774, 361);
            this.dataGridViewRendirComisiones.TabIndex = 0;
            this.dataGridViewRendirComisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRendirComisiones
            // 
            this.btnRendirComisiones.Location = new System.Drawing.Point(700, 472);
            this.btnRendirComisiones.Name = "btnRendirComisiones";
            this.btnRendirComisiones.Size = new System.Drawing.Size(170, 49);
            this.btnRendirComisiones.TabIndex = 1;
            this.btnRendirComisiones.Text = "Rendir Comisiones";
            this.btnRendirComisiones.UseVisualStyleBackColor = true;
            this.btnRendirComisiones.Click += new System.EventHandler(this.btnRendirComisiones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se rendirán las siguientes compras por un total de ";
            // 
            // GenerarRendiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 555);
            this.Controls.Add(this.btnRendirComisiones);
            this.Controls.Add(this.groupBoxRendirComisiones);
            this.Name = "GenerarRendiciones";
            this.Text = "Generar rendicion comisiones";
            this.Load += new System.EventHandler(this.GenerarRendiciones_Load);
            this.groupBoxRendirComisiones.ResumeLayout(false);
            this.groupBoxRendirComisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRendirComisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRendirComisiones;
        private System.Windows.Forms.DataGridView dataGridViewRendirComisiones;
        private System.Windows.Forms.Button btnRendirComisiones;
        private System.Windows.Forms.Label label1;
    }
}