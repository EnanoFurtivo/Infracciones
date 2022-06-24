namespace CapaVista
{
    partial class RegistrarUsuario
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.buttonRegistrarDuenio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(107, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Clave";
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(110, 325);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(186, 20);
            this.textBoxClave.TabIndex = 19;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(110, 162);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(186, 20);
            this.textBoxDni.TabIndex = 18;
            // 
            // buttonRegistrarDuenio
            // 
            this.buttonRegistrarDuenio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarDuenio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarDuenio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarDuenio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarDuenio.Location = new System.Drawing.Point(133, 396);
            this.buttonRegistrarDuenio.Name = "buttonRegistrarDuenio";
            this.buttonRegistrarDuenio.Size = new System.Drawing.Size(144, 28);
            this.buttonRegistrarDuenio.TabIndex = 17;
            this.buttonRegistrarDuenio.Text = "Registrar";
            this.buttonRegistrarDuenio.UseVisualStyleBackColor = false;
            this.buttonRegistrarDuenio.Click += new System.EventHandler(this.buttonRegistrarDuenio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(129, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Registrar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(107, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(110, 239);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(186, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(402, 506);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.buttonRegistrarDuenio);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button buttonRegistrarDuenio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}