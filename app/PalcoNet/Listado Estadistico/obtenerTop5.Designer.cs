namespace PalcoNet.Listado_Estadistico
{
    partial class obtenerTop5
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
            this.lbltop5 = new System.Windows.Forms.Label();
            this.lbltop5Filtro = new System.Windows.Forms.Label();
            this.btnfiltro1 = new System.Windows.Forms.RadioButton();
            this.btnfiltro3 = new System.Windows.Forms.RadioButton();
            this.btnfiltro2 = new System.Windows.Forms.RadioButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btntop5Limpiar = new System.Windows.Forms.Button();
            this.btntop5Guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltop5
            // 
            this.lbltop5.AutoSize = true;
            this.lbltop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop5.Location = new System.Drawing.Point(35, 25);
            this.lbltop5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltop5.Name = "lbltop5";
            this.lbltop5.Size = new System.Drawing.Size(201, 31);
            this.lbltop5.TabIndex = 1;
            this.lbltop5.Text = "Obtener Top 5";
            // 
            // lbltop5Filtro
            // 
            this.lbltop5Filtro.AutoSize = true;
            this.lbltop5Filtro.Location = new System.Drawing.Point(38, 73);
            this.lbltop5Filtro.Name = "lbltop5Filtro";
            this.lbltop5Filtro.Size = new System.Drawing.Size(79, 17);
            this.lbltop5Filtro.TabIndex = 3;
            this.lbltop5Filtro.Text = "Elegir Filtro";
            // 
            // btnfiltro1
            // 
            this.btnfiltro1.AutoSize = true;
            this.btnfiltro1.Location = new System.Drawing.Point(52, 105);
            this.btnfiltro1.Name = "btnfiltro1";
            this.btnfiltro1.Size = new System.Drawing.Size(110, 21);
            this.btnfiltro1.TabIndex = 4;
            this.btnfiltro1.TabStop = true;
            this.btnfiltro1.Text = "radioButton1";
            this.btnfiltro1.UseVisualStyleBackColor = true;
            // 
            // btnfiltro3
            // 
            this.btnfiltro3.AutoSize = true;
            this.btnfiltro3.Location = new System.Drawing.Point(440, 105);
            this.btnfiltro3.Name = "btnfiltro3";
            this.btnfiltro3.Size = new System.Drawing.Size(110, 21);
            this.btnfiltro3.TabIndex = 5;
            this.btnfiltro3.TabStop = true;
            this.btnfiltro3.Text = "radioButton2";
            this.btnfiltro3.UseVisualStyleBackColor = true;
            // 
            // btnfiltro2
            // 
            this.btnfiltro2.AutoSize = true;
            this.btnfiltro2.Location = new System.Drawing.Point(240, 105);
            this.btnfiltro2.Name = "btnfiltro2";
            this.btnfiltro2.Size = new System.Drawing.Size(110, 21);
            this.btnfiltro2.TabIndex = 6;
            this.btnfiltro2.TabStop = true;
            this.btnfiltro2.Text = "radioButton3";
            this.btnfiltro2.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(636, 533);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(34, 84);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(541, 76);
            // 
            // btntop5Limpiar
            // 
            this.btntop5Limpiar.Location = new System.Drawing.Point(41, 203);
            this.btntop5Limpiar.Name = "btntop5Limpiar";
            this.btntop5Limpiar.Size = new System.Drawing.Size(88, 30);
            this.btntop5Limpiar.TabIndex = 19;
            this.btntop5Limpiar.Text = "Limpiar";
            this.btntop5Limpiar.UseVisualStyleBackColor = true;
            // 
            // btntop5Guardar
            // 
            this.btntop5Guardar.Location = new System.Drawing.Point(483, 203);
            this.btntop5Guardar.Name = "btntop5Guardar";
            this.btntop5Guardar.Size = new System.Drawing.Size(88, 30);
            this.btntop5Guardar.TabIndex = 18;
            this.btntop5Guardar.Text = "Guardar";
            this.btntop5Guardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_id,
            this.tipo_usuario});
            this.dataGridView1.Location = new System.Drawing.Point(41, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 217);
            this.dataGridView1.TabIndex = 20;
            // 
            // usuario_id
            // 
            this.usuario_id.HeaderText = "usuario_id";
            this.usuario_id.Name = "usuario_id";
            // 
            // tipo_usuario
            // 
            this.tipo_usuario.HeaderText = "tipo_usuario";
            this.tipo_usuario.Name = "tipo_usuario";
            // 
            // obtenerTop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntop5Limpiar);
            this.Controls.Add(this.btntop5Guardar);
            this.Controls.Add(this.btnfiltro2);
            this.Controls.Add(this.btnfiltro3);
            this.Controls.Add(this.btnfiltro1);
            this.Controls.Add(this.lbltop5Filtro);
            this.Controls.Add(this.lbltop5);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "obtenerTop5";
            this.Text = "top5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltop5;
        private System.Windows.Forms.Label lbltop5Filtro;
        private System.Windows.Forms.RadioButton btnfiltro1;
        private System.Windows.Forms.RadioButton btnfiltro3;
        private System.Windows.Forms.RadioButton btnfiltro2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btntop5Limpiar;
        private System.Windows.Forms.Button btntop5Guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;

    }
}