﻿namespace FrbaCommerce.Abm_Cliente
{
    partial class Abm_Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Listar_Cli = new System.Windows.Forms.Button();
            this.button_Dar_Baja_Cli = new System.Windows.Forms.Button();
            this.button_Modificar_Cli = new System.Windows.Forms.Button();
            this.button_Crear_Cli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Listar_Cli);
            this.groupBox1.Controls.Add(this.button_Dar_Baja_Cli);
            this.groupBox1.Controls.Add(this.button_Modificar_Cli);
            this.groupBox1.Controls.Add(this.button_Crear_Cli);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // button_Listar_Cli
            // 
            this.button_Listar_Cli.Location = new System.Drawing.Point(6, 180);
            this.button_Listar_Cli.Name = "button_Listar_Cli";
            this.button_Listar_Cli.Size = new System.Drawing.Size(169, 33);
            this.button_Listar_Cli.TabIndex = 4;
            this.button_Listar_Cli.Text = "Listar clientes";
            this.button_Listar_Cli.UseVisualStyleBackColor = true;
            this.button_Listar_Cli.Click += new System.EventHandler(this.button_Listar_Cli_Click);
            // 
            // button_Dar_Baja_Cli
            // 
            this.button_Dar_Baja_Cli.Location = new System.Drawing.Point(6, 128);
            this.button_Dar_Baja_Cli.Name = "button_Dar_Baja_Cli";
            this.button_Dar_Baja_Cli.Size = new System.Drawing.Size(169, 33);
            this.button_Dar_Baja_Cli.TabIndex = 3;
            this.button_Dar_Baja_Cli.Text = "Dar de baja cliente";
            this.button_Dar_Baja_Cli.UseVisualStyleBackColor = true;
            this.button_Dar_Baja_Cli.Click += new System.EventHandler(this.button_Dar_Baja_Cli_Click);
            // 
            // button_Modificar_Cli
            // 
            this.button_Modificar_Cli.Location = new System.Drawing.Point(6, 76);
            this.button_Modificar_Cli.Name = "button_Modificar_Cli";
            this.button_Modificar_Cli.Size = new System.Drawing.Size(169, 33);
            this.button_Modificar_Cli.TabIndex = 2;
            this.button_Modificar_Cli.Text = "Modificar cliente";
            this.button_Modificar_Cli.UseVisualStyleBackColor = true;
            this.button_Modificar_Cli.Click += new System.EventHandler(this.button_Modificar_Cli_Click);
            // 
            // button_Crear_Cli
            // 
            this.button_Crear_Cli.Location = new System.Drawing.Point(6, 21);
            this.button_Crear_Cli.Name = "button_Crear_Cli";
            this.button_Crear_Cli.Size = new System.Drawing.Size(169, 33);
            this.button_Crear_Cli.TabIndex = 1;
            this.button_Crear_Cli.Text = "Crear cliente";
            this.button_Crear_Cli.UseVisualStyleBackColor = true;
            this.button_Crear_Cli.Click += new System.EventHandler(this.button_Crear_Cli_Click);
            // 
            // Abm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 251);
            this.Controls.Add(this.groupBox1);
            this.Name = "Abm_Cliente";
            this.Text = "Abm_Cliente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Dar_Baja_Cli;
        private System.Windows.Forms.Button button_Modificar_Cli;
        private System.Windows.Forms.Button button_Crear_Cli;
        private System.Windows.Forms.Button button_Listar_Cli;
    }
}