namespace CapaVista
{
    partial class RegistrarVehiculo
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
            this.buttonRegistrarVehiculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDuenios = new System.Windows.Forms.ComboBox();
            this.textBoxDominio = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistrarVehiculo
            // 
            this.buttonRegistrarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarVehiculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarVehiculo.Location = new System.Drawing.Point(133, 377);
            this.buttonRegistrarVehiculo.Name = "buttonRegistrarVehiculo";
            this.buttonRegistrarVehiculo.Size = new System.Drawing.Size(144, 28);
            this.buttonRegistrarVehiculo.TabIndex = 11;
            this.buttonRegistrarVehiculo.Text = "Registrar";
            this.buttonRegistrarVehiculo.UseVisualStyleBackColor = false;
            this.buttonRegistrarVehiculo.Click += new System.EventHandler(this.buttonRegistrarVehiculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registrar Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dominio";
            // 
            // comboBoxDuenios
            // 
            this.comboBoxDuenios.FormattingEnabled = true;
            this.comboBoxDuenios.Location = new System.Drawing.Point(110, 220);
            this.comboBoxDuenios.Name = "comboBoxDuenios";
            this.comboBoxDuenios.Size = new System.Drawing.Size(186, 21);
            this.comboBoxDuenios.TabIndex = 6;
            this.comboBoxDuenios.Text = "Seleccione un dueño";
            // 
            // textBoxDominio
            // 
            this.textBoxDominio.Location = new System.Drawing.Point(110, 143);
            this.textBoxDominio.Name = "textBoxDominio";
            this.textBoxDominio.Size = new System.Drawing.Size(186, 20);
            this.textBoxDominio.TabIndex = 12;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(110, 306);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(186, 20);
            this.textBoxMarca.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(107, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Marca";
            // 
            // RegistrarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(402, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxDominio);
            this.Controls.Add(this.buttonRegistrarVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDuenios);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarVehiculo";
            this.Text = "RegistrarVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrarVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDuenios;
        private System.Windows.Forms.TextBox textBoxDominio;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label3;
    }
}