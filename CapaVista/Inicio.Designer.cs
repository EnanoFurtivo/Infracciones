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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonFormInfraccion = new System.Windows.Forms.Button();
            this.buttonFormInfracciones = new System.Windows.Forms.Button();
            this.buttonFormRegistrarPago = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEliminarInfraccion = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonRegistrarInfraccion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.labelBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBienvenida.Location = new System.Drawing.Point(216, 23);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(213, 20);
            this.labelBienvenida.TabIndex = 0;
            this.labelBienvenida.Text = "Bienvenido de Nuevo";
            // 
            // buttonFormInfraccion
            // 
            this.buttonFormInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonFormInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonFormInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonFormInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormInfraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFormInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormInfraccion.Location = new System.Drawing.Point(0, 210);
            this.buttonFormInfraccion.Name = "buttonFormInfraccion";
            this.buttonFormInfraccion.Size = new System.Drawing.Size(209, 45);
            this.buttonFormInfraccion.TabIndex = 3;
            this.buttonFormInfraccion.Text = "Tipos de Infracciones";
            this.buttonFormInfraccion.UseVisualStyleBackColor = false;
            this.buttonFormInfraccion.Click += new System.EventHandler(this.buttonFormInfraccion_Click);
            // 
            // buttonFormInfracciones
            // 
            this.buttonFormInfracciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonFormInfracciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormInfracciones.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonFormInfracciones.FlatAppearance.BorderSize = 0;
            this.buttonFormInfracciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormInfracciones.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormInfracciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormInfracciones.Location = new System.Drawing.Point(0, 304);
            this.buttonFormInfracciones.Name = "buttonFormInfracciones";
            this.buttonFormInfracciones.Size = new System.Drawing.Size(209, 45);
            this.buttonFormInfracciones.TabIndex = 4;
            this.buttonFormInfracciones.Text = "Infracciones";
            this.buttonFormInfracciones.UseVisualStyleBackColor = false;
            this.buttonFormInfracciones.Click += new System.EventHandler(this.buttonFormRegistroInfraccion_Click);
            // 
            // buttonFormRegistrarPago
            // 
            this.buttonFormRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonFormRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFormRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFormRegistrarPago.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFormRegistrarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormRegistrarPago.Location = new System.Drawing.Point(0, 403);
            this.buttonFormRegistrarPago.Name = "buttonFormRegistrarPago";
            this.buttonFormRegistrarPago.Size = new System.Drawing.Size(209, 45);
            this.buttonFormRegistrarPago.TabIndex = 5;
            this.buttonFormRegistrarPago.Text = "Registrar Pago";
            this.buttonFormRegistrarPago.UseVisualStyleBackColor = false;
            this.buttonFormRegistrarPago.Click += new System.EventHandler(this.buttonFormRegistrarPago_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonEliminarInfraccion);
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.buttonRegistrarInfraccion);
            this.panel1.Controls.Add(this.buttonFormRegistrarPago);
            this.panel1.Controls.Add(this.buttonFormInfracciones);
            this.panel1.Controls.Add(this.buttonFormInfraccion);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 560);
            this.panel1.TabIndex = 6;
            // 
            // buttonEliminarInfraccion
            // 
            this.buttonEliminarInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonEliminarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonEliminarInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonEliminarInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminarInfraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminarInfraccion.Location = new System.Drawing.Point(107, 352);
            this.buttonEliminarInfraccion.Name = "buttonEliminarInfraccion";
            this.buttonEliminarInfraccion.Size = new System.Drawing.Size(102, 36);
            this.buttonEliminarInfraccion.TabIndex = 9;
            this.buttonEliminarInfraccion.Text = "Eliminar";
            this.buttonEliminarInfraccion.UseVisualStyleBackColor = false;
            this.buttonEliminarInfraccion.Visible = false;
            this.buttonEliminarInfraccion.Click += new System.EventHandler(this.buttonEliminarInfraccion_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(0, 492);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(209, 45);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonRegistrarInfraccion
            // 
            this.buttonRegistrarInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRegistrarInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarInfraccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarInfraccion.Location = new System.Drawing.Point(0, 352);
            this.buttonRegistrarInfraccion.Name = "buttonRegistrarInfraccion";
            this.buttonRegistrarInfraccion.Size = new System.Drawing.Size(96, 36);
            this.buttonRegistrarInfraccion.TabIndex = 8;
            this.buttonRegistrarInfraccion.Text = "Registrar";
            this.buttonRegistrarInfraccion.UseVisualStyleBackColor = false;
            this.buttonRegistrarInfraccion.Visible = false;
            this.buttonRegistrarInfraccion.Click += new System.EventHandler(this.buttonRegistrarInfraccion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panelContenedor.Location = new System.Drawing.Point(211, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(402, 506);
            this.panelContenedor.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonFormInfracciones;
        private System.Windows.Forms.Button buttonEliminarInfraccion;
        private System.Windows.Forms.Button buttonRegistrarInfraccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}