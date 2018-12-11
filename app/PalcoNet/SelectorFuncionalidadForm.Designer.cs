namespace PalcoNet
{
    partial class SelectorFuncionalidadForm
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
            this.boxFuncionalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxFuncionalidad
            // 
            this.boxFuncionalidad.FormattingEnabled = true;
            this.boxFuncionalidad.Location = new System.Drawing.Point(52, 127);
            this.boxFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxFuncionalidad.Name = "boxFuncionalidad";
            this.boxFuncionalidad.Size = new System.Drawing.Size(271, 24);
            this.boxFuncionalidad.TabIndex = 0;
       
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la funcionalidad a utilizar";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(224, 234);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 28);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // SelectorFuncionalidadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxFuncionalidad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectorFuncionalidadForm";
            this.Text = "SelectorFuncionalidadForm";
            this.Load += new System.EventHandler(this.SelectorFuncionalidadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxFuncionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
    }
}