namespace PalcoNet.Abm_Cliente
{
    partial class AltaTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroTarjeta = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.guardarDatosTarjeta = new System.Windows.Forms.Button();
            this.dateTimeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar datos de tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Tarjeta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de seguridad:";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Location = new System.Drawing.Point(134, 66);
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.Size = new System.Drawing.Size(129, 20);
            this.txtNroTarjeta.TabIndex = 3;
            // 
            // txtCCV
            // 
            this.txtCCV.Location = new System.Drawing.Point(134, 107);
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(129, 20);
            this.txtCCV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de tarjeta:";
            // 
            // comboTipoTarjeta
            // 
            this.comboTipoTarjeta.FormattingEnabled = true;
            this.comboTipoTarjeta.Location = new System.Drawing.Point(361, 66);
            this.comboTipoTarjeta.Name = "comboTipoTarjeta";
            this.comboTipoTarjeta.Size = new System.Drawing.Size(137, 21);
            this.comboTipoTarjeta.TabIndex = 8;
            // 
            // guardarDatosTarjeta
            // 
            this.guardarDatosTarjeta.Location = new System.Drawing.Point(229, 164);
            this.guardarDatosTarjeta.Name = "guardarDatosTarjeta";
            this.guardarDatosTarjeta.Size = new System.Drawing.Size(75, 23);
            this.guardarDatosTarjeta.TabIndex = 10;
            this.guardarDatosTarjeta.Text = "Guardar";
            this.guardarDatosTarjeta.UseVisualStyleBackColor = true;
            this.guardarDatosTarjeta.Click += new System.EventHandler(this.guardarDatosTarjeta_Click);
            // 
            // dateTimeVencimiento
            // 
            this.dateTimeVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeVencimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeVencimiento.Location = new System.Drawing.Point(398, 107);
            this.dateTimeVencimiento.Name = "dateTimeVencimiento";
            this.dateTimeVencimiento.Size = new System.Drawing.Size(130, 20);
            this.dateTimeVencimiento.TabIndex = 11;
            // 
            // altaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 199);
            this.Controls.Add(this.dateTimeVencimiento);
            this.Controls.Add(this.guardarDatosTarjeta);
            this.Controls.Add(this.comboTipoTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCCV);
            this.Controls.Add(this.txtNroTarjeta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "altaTarjeta";
            this.Text = "Datos tarjeta";
            this.Load += new System.EventHandler(this.altaTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroTarjeta;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipoTarjeta;
        private System.Windows.Forms.Button guardarDatosTarjeta;
        private System.Windows.Forms.DateTimePicker dateTimeVencimiento;
    }
}