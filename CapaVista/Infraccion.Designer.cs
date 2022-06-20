namespace CapaVista
{
    partial class Infraccion
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
            this.listBoxTipoInfraccion = new System.Windows.Forms.ListBox();
            this.buttonAgregarTipoInfraccion = new System.Windows.Forms.Button();
            this.buttonModificarTipoInfraccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTipoInfraccion
            // 
            this.listBoxTipoInfraccion.FormattingEnabled = true;
            this.listBoxTipoInfraccion.Location = new System.Drawing.Point(84, 53);
            this.listBoxTipoInfraccion.Name = "listBoxTipoInfraccion";
            this.listBoxTipoInfraccion.Size = new System.Drawing.Size(230, 342);
            this.listBoxTipoInfraccion.TabIndex = 0;
            // 
            // buttonAgregarTipoInfraccion
            // 
            this.buttonAgregarTipoInfraccion.Location = new System.Drawing.Point(84, 420);
            this.buttonAgregarTipoInfraccion.Name = "buttonAgregarTipoInfraccion";
            this.buttonAgregarTipoInfraccion.Size = new System.Drawing.Size(112, 30);
            this.buttonAgregarTipoInfraccion.TabIndex = 1;
            this.buttonAgregarTipoInfraccion.Text = "Agregar Infraccion";
            this.buttonAgregarTipoInfraccion.UseVisualStyleBackColor = true;
            // 
            // buttonModificarTipoInfraccion
            // 
            this.buttonModificarTipoInfraccion.Location = new System.Drawing.Point(202, 420);
            this.buttonModificarTipoInfraccion.Name = "buttonModificarTipoInfraccion";
            this.buttonModificarTipoInfraccion.Size = new System.Drawing.Size(112, 29);
            this.buttonModificarTipoInfraccion.TabIndex = 2;
            this.buttonModificarTipoInfraccion.Text = "Modificar Infraccion";
            this.buttonModificarTipoInfraccion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Infracciones";
            // 
            // Infraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModificarTipoInfraccion);
            this.Controls.Add(this.buttonAgregarTipoInfraccion);
            this.Controls.Add(this.listBoxTipoInfraccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Infraccion";
            this.Text = "Infraccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTipoInfraccion;
        private System.Windows.Forms.Button buttonAgregarTipoInfraccion;
        private System.Windows.Forms.Button buttonModificarTipoInfraccion;
        private System.Windows.Forms.Label label1;
    }
}