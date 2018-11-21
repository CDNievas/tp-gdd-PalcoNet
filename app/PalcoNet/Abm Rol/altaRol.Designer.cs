namespace PalcoNet.Abm_Rol
{
    partial class altaRol
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
            this.lblRolNombre = new System.Windows.Forms.Label();
            this.lblRolFun = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRolAlta = new System.Windows.Forms.TextBox();
            this.clbRol = new System.Windows.Forms.CheckedListBox();
            this.btnClienteLimpiar = new System.Windows.Forms.Button();
            this.btnClienteGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(45, 75);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(62, 17);
            this.lblRolNombre.TabIndex = 0;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // lblRolFun
            // 
            this.lblRolFun.AutoSize = true;
            this.lblRolFun.Location = new System.Drawing.Point(45, 122);
            this.lblRolFun.Name = "lblRolFun";
            this.lblRolFun.Size = new System.Drawing.Size(115, 17);
            this.lblRolFun.TabIndex = 1;
            this.lblRolFun.Text = "Funcionalidades:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(340, 391);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(19, 28);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(285, 268);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Rol";
            // 
            // txtRolAlta
            // 
            this.txtRolAlta.Location = new System.Drawing.Point(144, 75);
            this.txtRolAlta.Name = "txtRolAlta";
            this.txtRolAlta.Size = new System.Drawing.Size(115, 22);
            this.txtRolAlta.TabIndex = 4;
            // 
            // clbRol
            // 
            this.clbRol.FormattingEnabled = true;
            this.clbRol.Items.AddRange(new object[] {
            "fun1",
            "fun2",
            "fun3",
            "fun4",
            "fun5"});
            this.clbRol.Location = new System.Drawing.Point(124, 142);
            this.clbRol.Name = "clbRol";
            this.clbRol.Size = new System.Drawing.Size(135, 106);
            this.clbRol.TabIndex = 5;
            // 
            // btnClienteLimpiar
            // 
            this.btnClienteLimpiar.Location = new System.Drawing.Point(-349, 284);
            this.btnClienteLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btnClienteLimpiar.TabIndex = 32;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnClienteGuardar
            // 
            this.btnClienteGuardar.Location = new System.Drawing.Point(217, 329);
            this.btnClienteGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteGuardar.Name = "btnClienteGuardar";
            this.btnClienteGuardar.Size = new System.Drawing.Size(88, 30);
            this.btnClienteGuardar.TabIndex = 31;
            this.btnClienteGuardar.Text = "Guardar";
            this.btnClienteGuardar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // altaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClienteLimpiar);
            this.Controls.Add(this.btnClienteGuardar);
            this.Controls.Add(this.clbRol);
            this.Controls.Add(this.txtRolAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRolFun);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "altaRol";
            this.Text = "altaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblRolFun;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRolAlta;
        private System.Windows.Forms.CheckedListBox clbRol;
        private System.Windows.Forms.Button btnClienteLimpiar;
        private System.Windows.Forms.Button btnClienteGuardar;
        private System.Windows.Forms.Button button1;
    }
}