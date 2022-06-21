namespace CapaVista
{
    partial class Inicio
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
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonFormInfraccion = new System.Windows.Forms.Button();
            this.buttonFormRegistroInfraccion = new System.Windows.Forms.Button();
            this.buttonFormRegistrarPago = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBienvenida.Location = new System.Drawing.Point(216, 15);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(195, 25);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido de nuevo";
            // 
            // buttonFormInfraccion
            // 
            this.buttonFormInfraccion.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFormInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormInfraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFormInfraccion.Location = new System.Drawing.Point(0, 210);
            this.buttonFormInfraccion.Name = "buttonFormInfraccion";
            this.buttonFormInfraccion.Size = new System.Drawing.Size(203, 45);
            this.buttonFormInfraccion.TabIndex = 3;
            this.buttonFormInfraccion.Text = "Infracciones";
            this.buttonFormInfraccion.UseVisualStyleBackColor = false;
            this.buttonFormInfraccion.Click += new System.EventHandler(this.buttonFormInfraccion_Click);
            // 
            // buttonFormRegistroInfraccion
            // 
            this.buttonFormRegistroInfraccion.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFormRegistroInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormRegistroInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonFormRegistroInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonFormRegistroInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormRegistroInfraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormRegistroInfraccion.Location = new System.Drawing.Point(0, 304);
            this.buttonFormRegistroInfraccion.Name = "buttonFormRegistroInfraccion";
            this.buttonFormRegistroInfraccion.Size = new System.Drawing.Size(203, 45);
            this.buttonFormRegistroInfraccion.TabIndex = 4;
            this.buttonFormRegistroInfraccion.Text = "Registrar Infraccion";
            this.buttonFormRegistroInfraccion.UseVisualStyleBackColor = false;
            this.buttonFormRegistroInfraccion.Click += new System.EventHandler(this.buttonFormRegistroInfraccion_Click);
            // 
            // buttonFormRegistrarPago
            // 
            this.buttonFormRegistrarPago.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFormRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormRegistrarPago.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFormRegistrarPago.Location = new System.Drawing.Point(0, 403);
            this.buttonFormRegistrarPago.Name = "buttonFormRegistrarPago";
            this.buttonFormRegistrarPago.Size = new System.Drawing.Size(203, 45);
            this.buttonFormRegistrarPago.TabIndex = 5;
            this.buttonFormRegistrarPago.Text = "Registrar Pago";
            this.buttonFormRegistrarPago.UseVisualStyleBackColor = false;
            this.buttonFormRegistrarPago.Click += new System.EventHandler(this.buttonFormRegistrarPago_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.buttonFormRegistrarPago);
            this.panel1.Controls.Add(this.buttonFormRegistroInfraccion);
            this.panel1.Controls.Add(this.buttonFormInfraccion);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 537);
            this.panel1.TabIndex = 6;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonCerrarSesion.Location = new System.Drawing.Point(0, 492);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(203, 45);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(211, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(402, 493);
            this.panelContenedor.TabIndex = 7;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonFormInfraccion;
        private System.Windows.Forms.Button buttonFormRegistrarPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button buttonFormRegistroInfraccion;
    }
}