﻿namespace CapaVista
{
    partial class RegistroInfraccion
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
            this.comboBoxTipoInfraccion = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaInfraccion = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarInfraccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTipoInfraccion
            // 
            this.comboBoxTipoInfraccion.FormattingEnabled = true;
            this.comboBoxTipoInfraccion.Location = new System.Drawing.Point(108, 107);
            this.comboBoxTipoInfraccion.Name = "comboBoxTipoInfraccion";
            this.comboBoxTipoInfraccion.Size = new System.Drawing.Size(186, 21);
            this.comboBoxTipoInfraccion.TabIndex = 0;
            this.comboBoxTipoInfraccion.Text = "Seleccione un tipo de infraccion";
            // 
            // dateTimePickerFechaInfraccion
            // 
            this.dateTimePickerFechaInfraccion.Location = new System.Drawing.Point(108, 241);
            this.dateTimePickerFechaInfraccion.Name = "dateTimePickerFechaInfraccion";
            this.dateTimePickerFechaInfraccion.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerFechaInfraccion.TabIndex = 1;
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Location = new System.Drawing.Point(108, 170);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(186, 21);
            this.comboBoxVehiculo.TabIndex = 2;
            this.comboBoxVehiculo.Text = "Seleccione Vehiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione fecha de infraccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(127, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registrar Infraccion";
            // 
            // buttonRegistrarInfraccion
            // 
            this.buttonRegistrarInfraccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarInfraccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarInfraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarInfraccion.Location = new System.Drawing.Point(129, 309);
            this.buttonRegistrarInfraccion.Name = "buttonRegistrarInfraccion";
            this.buttonRegistrarInfraccion.Size = new System.Drawing.Size(144, 28);
            this.buttonRegistrarInfraccion.TabIndex = 5;
            this.buttonRegistrarInfraccion.Text = "Registrar";
            this.buttonRegistrarInfraccion.UseVisualStyleBackColor = true;
            // 
            // RegistroInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.buttonRegistrarInfraccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVehiculo);
            this.Controls.Add(this.dateTimePickerFechaInfraccion);
            this.Controls.Add(this.comboBoxTipoInfraccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroInfraccion";
            this.Text = "RegistroInfraccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipoInfraccion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInfraccion;
        private System.Windows.Forms.ComboBox comboBoxVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrarInfraccion;
    }
}