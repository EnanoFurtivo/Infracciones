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
            this.buttonRegistrarVehiculo = new System.Windows.Forms.Button();
            this.buttonRegistrarUsuario = new System.Windows.Forms.Button();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEliminarInfraccion = new System.Windows.Forms.Button();
            this.buttonRegistrarInfraccion = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelSubMenuInfracciones = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubMenuInfracciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.labelBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBienvenida.Location = new System.Drawing.Point(216, 22);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(206, 27);
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
            this.buttonFormInfraccion.Font = new System.Drawing.Font("Calibri", 11F);
            this.buttonFormInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormInfraccion.Location = new System.Drawing.Point(0, 197);
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
            this.buttonFormInfracciones.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormInfracciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormInfracciones.Location = new System.Drawing.Point(0, 255);
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
            this.buttonFormRegistrarPago.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormRegistrarPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFormRegistrarPago.Location = new System.Drawing.Point(0, 459);
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
            this.panel1.Controls.Add(this.buttonRegistrarVehiculo);
            this.panel1.Controls.Add(this.buttonRegistrarUsuario);
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.buttonFormRegistrarPago);
            this.panel1.Controls.Add(this.buttonFormInfracciones);
            this.panel1.Controls.Add(this.buttonFormInfraccion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 560);
            this.panel1.TabIndex = 6;
            // 
            // buttonRegistrarVehiculo
            // 
            this.buttonRegistrarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarVehiculo.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarVehiculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarVehiculo.Location = new System.Drawing.Point(0, 408);
            this.buttonRegistrarVehiculo.Name = "buttonRegistrarVehiculo";
            this.buttonRegistrarVehiculo.Size = new System.Drawing.Size(209, 45);
            this.buttonRegistrarVehiculo.TabIndex = 12;
            this.buttonRegistrarVehiculo.Text = "Registrar Vehiculo";
            this.buttonRegistrarVehiculo.UseVisualStyleBackColor = false;
            this.buttonRegistrarVehiculo.Click += new System.EventHandler(this.buttonRegistrarVehiculo_Click);
            // 
            // buttonRegistrarUsuario
            // 
            this.buttonRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarUsuario.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarUsuario.Location = new System.Drawing.Point(0, 352);
            this.buttonRegistrarUsuario.Name = "buttonRegistrarUsuario";
            this.buttonRegistrarUsuario.Size = new System.Drawing.Size(209, 45);
            this.buttonRegistrarUsuario.TabIndex = 11;
            this.buttonRegistrarUsuario.Text = "Registrar Usuario";
            this.buttonRegistrarUsuario.UseVisualStyleBackColor = false;
            this.buttonRegistrarUsuario.Click += new System.EventHandler(this.buttonRegistrarUsuario_Click);
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(0, 512);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(209, 45);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.logoinfracciones;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEliminarInfraccion
            // 
            this.buttonEliminarInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonEliminarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonEliminarInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonEliminarInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminarInfraccion.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminarInfraccion.Location = new System.Drawing.Point(104, 0);
            this.buttonEliminarInfraccion.Name = "buttonEliminarInfraccion";
            this.buttonEliminarInfraccion.Size = new System.Drawing.Size(102, 36);
            this.buttonEliminarInfraccion.TabIndex = 9;
            this.buttonEliminarInfraccion.Text = "Eliminar";
            this.buttonEliminarInfraccion.UseVisualStyleBackColor = false;
            this.buttonEliminarInfraccion.Click += new System.EventHandler(this.buttonEliminarInfraccion_Click);
            // 
            // buttonRegistrarInfraccion
            // 
            this.buttonRegistrarInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarInfraccion.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRegistrarInfraccion.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarInfraccion.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarInfraccion.Location = new System.Drawing.Point(3, 0);
            this.buttonRegistrarInfraccion.Name = "buttonRegistrarInfraccion";
            this.buttonRegistrarInfraccion.Size = new System.Drawing.Size(96, 36);
            this.buttonRegistrarInfraccion.TabIndex = 8;
            this.buttonRegistrarInfraccion.Text = "Registrar";
            this.buttonRegistrarInfraccion.UseVisualStyleBackColor = false;
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
            // panelSubMenuInfracciones
            // 
            this.panelSubMenuInfracciones.Controls.Add(this.buttonEliminarInfraccion);
            this.panelSubMenuInfracciones.Controls.Add(this.buttonRegistrarInfraccion);
            this.panelSubMenuInfracciones.Location = new System.Drawing.Point(1, 303);
            this.panelSubMenuInfracciones.Name = "panelSubMenuInfracciones";
            this.panelSubMenuInfracciones.Size = new System.Drawing.Size(209, 46);
            this.panelSubMenuInfracciones.TabIndex = 13;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.panelSubMenuInfracciones);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubMenuInfracciones.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonRegistrarVehiculo;
        private System.Windows.Forms.Button buttonRegistrarUsuario;
        private System.Windows.Forms.Panel panelSubMenuInfracciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}