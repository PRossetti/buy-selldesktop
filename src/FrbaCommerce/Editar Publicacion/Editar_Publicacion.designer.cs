﻿namespace FrbaCommerce.Editar_Publicacion
{
    partial class Editar_Publicacion
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
            this.label_ErrorDescripcion = new System.Windows.Forms.Label();
            this.label_ErrorStock = new System.Windows.Forms.Label();
            this.label_ErrorPrecio = new System.Windows.Forms.Label();
            this.label_ErrorMensaje = new System.Windows.Forms.Label();
            this.checkBox_PermitirPreguntas = new System.Windows.Forms.CheckBox();
            this.button_ModificarPublicacion = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Visibilidad = new System.Windows.Forms.ComboBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ErrorRubros = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_Rubros = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_QuitarRubro = new System.Windows.Forms.Button();
            this.button_AgregarRubro = new System.Windows.Forms.Button();
            this.listBox_RubrosSeleccionados = new System.Windows.Forms.ListBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ErrorDescripcion
            // 
            this.label_ErrorDescripcion.AutoSize = true;
            this.label_ErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorDescripcion.Location = new System.Drawing.Point(191, 14);
            this.label_ErrorDescripcion.Name = "label_ErrorDescripcion";
            this.label_ErrorDescripcion.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorDescripcion.TabIndex = 36;
            // 
            // label_ErrorStock
            // 
            this.label_ErrorStock.AutoSize = true;
            this.label_ErrorStock.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorStock.Location = new System.Drawing.Point(191, 54);
            this.label_ErrorStock.Name = "label_ErrorStock";
            this.label_ErrorStock.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorStock.TabIndex = 35;
            // 
            // label_ErrorPrecio
            // 
            this.label_ErrorPrecio.AutoSize = true;
            this.label_ErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorPrecio.Location = new System.Drawing.Point(191, 93);
            this.label_ErrorPrecio.Name = "label_ErrorPrecio";
            this.label_ErrorPrecio.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorPrecio.TabIndex = 34;
            // 
            // label_ErrorMensaje
            // 
            this.label_ErrorMensaje.AutoSize = true;
            this.label_ErrorMensaje.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorMensaje.Location = new System.Drawing.Point(82, 355);
            this.label_ErrorMensaje.Name = "label_ErrorMensaje";
            this.label_ErrorMensaje.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorMensaje.TabIndex = 33;
            // 
            // checkBox_PermitirPreguntas
            // 
            this.checkBox_PermitirPreguntas.AutoSize = true;
            this.checkBox_PermitirPreguntas.Location = new System.Drawing.Point(221, 92);
            this.checkBox_PermitirPreguntas.Name = "checkBox_PermitirPreguntas";
            this.checkBox_PermitirPreguntas.Size = new System.Drawing.Size(110, 17);
            this.checkBox_PermitirPreguntas.TabIndex = 32;
            this.checkBox_PermitirPreguntas.Text = "Permitir preguntas";
            this.checkBox_PermitirPreguntas.UseVisualStyleBackColor = true;
            // 
            // button_ModificarPublicacion
            // 
            this.button_ModificarPublicacion.Location = new System.Drawing.Point(351, 378);
            this.button_ModificarPublicacion.Name = "button_ModificarPublicacion";
            this.button_ModificarPublicacion.Size = new System.Drawing.Size(75, 23);
            this.button_ModificarPublicacion.TabIndex = 31;
            this.button_ModificarPublicacion.Text = "Modificar";
            this.button_ModificarPublicacion.UseVisualStyleBackColor = true;
            this.button_ModificarPublicacion.Click += new System.EventHandler(this.button_ModificarPublicacion_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(16, 378);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 30;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estado:";
            // 
            // comboBox_Estado
            // 
            this.comboBox_Estado.FormattingEnabled = true;
            /*this.comboBox_Estado.Items.AddRange(new object[] {
            "Borrador",
            "Publicada",
            "Pausada",
            "Finalizada"});*/
            this.comboBox_Estado.Location = new System.Drawing.Point(290, 53);
            this.comboBox_Estado.Name = "comboBox_Estado";
            this.comboBox_Estado.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Estado.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Visibilidad:";
            // 
            // comboBox_Visibilidad
            // 
            this.comboBox_Visibilidad.FormattingEnabled = true;
            this.comboBox_Visibilidad.Location = new System.Drawing.Point(290, 14);
            this.comboBox_Visibilidad.Name = "comboBox_Visibilidad";
            this.comboBox_Visibilidad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Visibilidad.TabIndex = 26;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(85, 90);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_Precio.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ErrorRubros);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBox_Rubros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_QuitarRubro);
            this.groupBox1.Controls.Add(this.button_AgregarRubro);
            this.groupBox1.Controls.Add(this.listBox_RubrosSeleccionados);
            this.groupBox1.Location = new System.Drawing.Point(16, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BE_SHARPS.Rubros";
            // 
            // label_ErrorRubros
            // 
            this.label_ErrorRubros.AutoSize = true;
            this.label_ErrorRubros.ForeColor = System.Drawing.Color.Red;
            this.label_ErrorRubros.Location = new System.Drawing.Point(125, 184);
            this.label_ErrorRubros.Name = "label_ErrorRubros";
            this.label_ErrorRubros.Size = new System.Drawing.Size(0, 13);
            this.label_ErrorRubros.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Todos los rubros:";
            // 
            // listBox_Rubros
            // 
            this.listBox_Rubros.FormattingEnabled = true;
            this.listBox_Rubros.Location = new System.Drawing.Point(247, 39);
            this.listBox_Rubros.Name = "listBox_Rubros";
            this.listBox_Rubros.Size = new System.Drawing.Size(148, 134);
            this.listBox_Rubros.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rubros seleccionados:";
            // 
            // button_QuitarRubro
            // 
            this.button_QuitarRubro.Location = new System.Drawing.Point(15, 179);
            this.button_QuitarRubro.Name = "button_QuitarRubro";
            this.button_QuitarRubro.Size = new System.Drawing.Size(75, 23);
            this.button_QuitarRubro.TabIndex = 6;
            this.button_QuitarRubro.Text = "Quitar";
            this.button_QuitarRubro.UseVisualStyleBackColor = true;
            this.button_QuitarRubro.Click += new System.EventHandler(this.button_QuitarRubro_Click);
            // 
            // button_AgregarRubro
            // 
            this.button_AgregarRubro.Location = new System.Drawing.Point(190, 93);
            this.button_AgregarRubro.Name = "button_AgregarRubro";
            this.button_AgregarRubro.Size = new System.Drawing.Size(33, 23);
            this.button_AgregarRubro.TabIndex = 5;
            this.button_AgregarRubro.Text = "<-";
            this.button_AgregarRubro.UseVisualStyleBackColor = true;
            this.button_AgregarRubro.Click += new System.EventHandler(this.button_AgregarRubro_Click);
            // 
            // listBox_RubrosSeleccionados
            // 
            this.listBox_RubrosSeleccionados.FormattingEnabled = true;
            this.listBox_RubrosSeleccionados.Location = new System.Drawing.Point(15, 39);
            this.listBox_RubrosSeleccionados.Name = "listBox_RubrosSeleccionados";
            this.listBox_RubrosSeleccionados.Size = new System.Drawing.Size(148, 134);
            this.listBox_RubrosSeleccionados.TabIndex = 4;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(85, 51);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(100, 20);
            this.textBox_Stock.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stock:";
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(85, 12);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Descripcion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripcion:";
            // 
            // Editar_Publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 410);
            this.Controls.Add(this.label_ErrorDescripcion);
            this.Controls.Add(this.label_ErrorStock);
            this.Controls.Add(this.label_ErrorPrecio);
            this.Controls.Add(this.label_ErrorMensaje);
            this.Controls.Add(this.checkBox_PermitirPreguntas);
            this.Controls.Add(this.button_ModificarPublicacion);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Estado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Visibilidad);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.label1);
            this.Name = "Editar_Publicacion";
            this.Text = "Editar_Publicacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ErrorDescripcion;
        private System.Windows.Forms.Label label_ErrorStock;
        private System.Windows.Forms.Label label_ErrorPrecio;
        private System.Windows.Forms.Label label_ErrorMensaje;
        private System.Windows.Forms.CheckBox checkBox_PermitirPreguntas;
        private System.Windows.Forms.Button button_ModificarPublicacion;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Visibilidad;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ErrorRubros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_Rubros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_QuitarRubro;
        private System.Windows.Forms.Button button_AgregarRubro;
        private System.Windows.Forms.ListBox listBox_RubrosSeleccionados;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label label1;

    }
}