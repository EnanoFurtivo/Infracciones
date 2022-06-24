namespace CapaVista
{
    partial class TipoInfracciones
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
            this.listBoxTipoInfraccion.BackColor = System.Drawing.Color.MintCream;
            this.listBoxTipoInfraccion.FormattingEnabled = true;
            this.listBoxTipoInfraccion.Location = new System.Drawing.Point(86, 53);
            this.listBoxTipoInfraccion.Name = "listBoxTipoInfraccion";
            this.listBoxTipoInfraccion.Size = new System.Drawing.Size(230, 342);
            this.listBoxTipoInfraccion.TabIndex = 0;
            // 
            // buttonAgregarTipoInfraccion
            // 
            this.buttonAgregarTipoInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonAgregarTipoInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarTipoInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregarTipoInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregarTipoInfraccion.Location = new System.Drawing.Point(86, 419);
            this.buttonAgregarTipoInfraccion.Name = "buttonAgregarTipoInfraccion";
            this.buttonAgregarTipoInfraccion.Size = new System.Drawing.Size(112, 43);
            this.buttonAgregarTipoInfraccion.TabIndex = 1;
            this.buttonAgregarTipoInfraccion.Text = "Agregar Tipo de Infraccion";
            this.buttonAgregarTipoInfraccion.UseVisualStyleBackColor = false;
            this.buttonAgregarTipoInfraccion.Click += new System.EventHandler(this.buttonAgregarTipoInfraccion_Click);
            // 
            // buttonModificarTipoInfraccion
            // 
            this.buttonModificarTipoInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonModificarTipoInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificarTipoInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModificarTipoInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModificarTipoInfraccion.Location = new System.Drawing.Point(204, 420);
            this.buttonModificarTipoInfraccion.Name = "buttonModificarTipoInfraccion";
            this.buttonModificarTipoInfraccion.Size = new System.Drawing.Size(112, 42);
            this.buttonModificarTipoInfraccion.TabIndex = 2;
            this.buttonModificarTipoInfraccion.Text = "Modificar Tipo de Infraccion";
            this.buttonModificarTipoInfraccion.UseVisualStyleBackColor = false;
            this.buttonModificarTipoInfraccion.Click += new System.EventHandler(this.buttonModificarTipoInfraccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Infracciones";
            // 
            // TipoInfracciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModificarTipoInfraccion);
            this.Controls.Add(this.buttonAgregarTipoInfraccion);
            this.Controls.Add(this.listBoxTipoInfraccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TipoInfracciones";
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