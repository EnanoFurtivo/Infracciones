﻿namespace CapaVista
{
    partial class RegistrarPago
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
            this.checkedListBoxInfraccion = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVehiculos = new System.Windows.Forms.ListBox();
            this.buttonRegistrarPagos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxInfraccion
            // 
            this.checkedListBoxInfraccion.BackColor = System.Drawing.Color.MintCream;
            this.checkedListBoxInfraccion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxInfraccion.FormattingEnabled = true;
            this.checkedListBoxInfraccion.HorizontalScrollbar = true;
            this.checkedListBoxInfraccion.Location = new System.Drawing.Point(223, 84);
            this.checkedListBoxInfraccion.Name = "checkedListBoxInfraccion";
            this.checkedListBoxInfraccion.Size = new System.Drawing.Size(167, 319);
            this.checkedListBoxInfraccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Infracciones cometidas";
            // 
            // listBoxVehiculos
            // 
            this.listBoxVehiculos.BackColor = System.Drawing.Color.MintCream;
            this.listBoxVehiculos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVehiculos.FormattingEnabled = true;
            this.listBoxVehiculos.HorizontalScrollbar = true;
            this.listBoxVehiculos.ItemHeight = 18;
            this.listBoxVehiculos.Location = new System.Drawing.Point(12, 84);
            this.listBoxVehiculos.Name = "listBoxVehiculos";
            this.listBoxVehiculos.Size = new System.Drawing.Size(167, 328);
            this.listBoxVehiculos.TabIndex = 3;
            this.listBoxVehiculos.SelectedIndexChanged += new System.EventHandler(this.listBoxVehiculos_SelectedIndexChanged);
            // 
            // buttonRegistrarPagos
            // 
            this.buttonRegistrarPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.buttonRegistrarPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrarPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistrarPagos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistrarPagos.Location = new System.Drawing.Point(259, 449);
            this.buttonRegistrarPagos.Name = "buttonRegistrarPagos";
            this.buttonRegistrarPagos.Size = new System.Drawing.Size(131, 32);
            this.buttonRegistrarPagos.TabIndex = 4;
            this.buttonRegistrarPagos.Text = "Registrar Pagos";
            this.buttonRegistrarPagos.UseVisualStyleBackColor = false;
            this.buttonRegistrarPagos.Click += new System.EventHandler(this.buttonRegistrarPagos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehiculos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(219, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Infracciones";
            // 
            // dateTimePickerFechaPago
            // 
            this.dateTimePickerFechaPago.Location = new System.Drawing.Point(12, 461);
            this.dateTimePickerFechaPago.Name = "dateTimePickerFechaPago";
            this.dateTimePickerFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaPago.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleccionar fecha de pago";
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(402, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFechaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRegistrarPagos);
            this.Controls.Add(this.listBoxVehiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxInfraccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPago";
            this.Text = "RegistrarPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxInfraccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVehiculos;
        private System.Windows.Forms.Button buttonRegistrarPagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPago;
        private System.Windows.Forms.Label label4;
    }
}