namespace PalcoNet.Abm_Rol
{
    partial class AltaRolForm
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnClienteLimpiar = new System.Windows.Forms.Button();
            this.btnClienteGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.funcionalidadesCheckList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblRolNombre
            // 
            this.lblRolNombre.AutoSize = true;
            this.lblRolNombre.Location = new System.Drawing.Point(34, 61);
            this.lblRolNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolNombre.Name = "lblRolNombre";
            this.lblRolNombre.Size = new System.Drawing.Size(47, 13);
            this.lblRolNombre.TabIndex = 0;
            this.lblRolNombre.Text = "Nombre:";
            // 
            // lblRolFun
            // 
            this.lblRolFun.AutoSize = true;
            this.lblRolFun.Location = new System.Drawing.Point(34, 99);
            this.lblRolFun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolFun.Name = "lblRolFun";
            this.lblRolFun.Size = new System.Drawing.Size(87, 13);
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
            this.shapeContainer1.Size = new System.Drawing.Size(337, 471);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(19, 28);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(293, 437);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 61);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnClienteLimpiar
            // 
            this.btnClienteLimpiar.Location = new System.Drawing.Point(-262, 231);
            this.btnClienteLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteLimpiar.Name = "btnClienteLimpiar";
            this.btnClienteLimpiar.Size = new System.Drawing.Size(66, 24);
            this.btnClienteLimpiar.TabIndex = 32;
            this.btnClienteLimpiar.Text = "Limpiar";
            this.btnClienteLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnClienteGuardar
            // 
            this.btnClienteGuardar.Location = new System.Drawing.Point(174, 436);
            this.btnClienteGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteGuardar.Name = "btnClienteGuardar";
            this.btnClienteGuardar.Size = new System.Drawing.Size(66, 24);
            this.btnClienteGuardar.TabIndex = 31;
            this.btnClienteGuardar.Text = "Guardar";
            this.btnClienteGuardar.UseVisualStyleBackColor = true;
            this.btnClienteGuardar.Click += new System.EventHandler(this.btnClienteGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionalidadesCheckList
            // 
            this.funcionalidadesCheckList.FormattingEnabled = true;
            this.funcionalidadesCheckList.Location = new System.Drawing.Point(37, 127);
            this.funcionalidadesCheckList.Name = "funcionalidadesCheckList";
            this.funcionalidadesCheckList.Size = new System.Drawing.Size(246, 289);
            this.funcionalidadesCheckList.TabIndex = 34;
            // 
            // AltaRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 471);
            this.Controls.Add(this.funcionalidadesCheckList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClienteLimpiar);
            this.Controls.Add(this.btnClienteGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRolFun);
            this.Controls.Add(this.lblRolNombre);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaRolForm";
            this.Text = "altaRol";
            this.Load += new System.EventHandler(this.AltaRolForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolNombre;
        private System.Windows.Forms.Label lblRolFun;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnClienteLimpiar;
        private System.Windows.Forms.Button btnClienteGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox funcionalidadesCheckList;
    }
}