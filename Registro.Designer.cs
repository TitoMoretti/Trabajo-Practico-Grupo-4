﻿namespace Trabajo_POO_Grupo_4
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.registrobox = new System.Windows.Forms.GroupBox();
            this.btnOjito = new System.Windows.Forms.Button();
            this.registrobox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(37, 276);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(167, 60);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Cuenta";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(287, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(425, 32);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(287, 63);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(425, 32);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(287, 103);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(425, 32);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(425, 32);
            this.txtEmail.TabIndex = 10;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(287, 180);
            this.txtContra.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(425, 32);
            this.txtContra.TabIndex = 11;
            this.txtContra.Tag = "contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 276);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 60);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(268, 348);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(167, 60);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar Datos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // registrobox
            // 
            this.registrobox.BackColor = System.Drawing.Color.Transparent;
            this.registrobox.Controls.Add(this.btnOjito);
            this.registrobox.Controls.Add(this.label2);
            this.registrobox.Controls.Add(this.btnBorrar);
            this.registrobox.Controls.Add(this.label3);
            this.registrobox.Controls.Add(this.label4);
            this.registrobox.Controls.Add(this.btnCancelar);
            this.registrobox.Controls.Add(this.label5);
            this.registrobox.Controls.Add(this.txtContra);
            this.registrobox.Controls.Add(this.label6);
            this.registrobox.Controls.Add(this.txtEmail);
            this.registrobox.Controls.Add(this.btnCrear);
            this.registrobox.Controls.Add(this.txtUsuario);
            this.registrobox.Controls.Add(this.txtNombre);
            this.registrobox.Controls.Add(this.txtApellido);
            this.registrobox.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.registrobox.Location = new System.Drawing.Point(349, 15);
            this.registrobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrobox.Name = "registrobox";
            this.registrobox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrobox.Size = new System.Drawing.Size(717, 441);
            this.registrobox.TabIndex = 15;
            this.registrobox.TabStop = false;
            this.registrobox.Text = "Para crear una cuenta, por favor introduzca lo siguiente:";
            // 
            // btnOjito
            // 
            this.btnOjito.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.ojito;
            this.btnOjito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOjito.Location = new System.Drawing.Point(675, 180);
            this.btnOjito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOjito.Name = "btnOjito";
            this.btnOjito.Size = new System.Drawing.Size(37, 31);
            this.btnOjito.TabIndex = 21;
            this.btnOjito.UseVisualStyleBackColor = true;
            this.btnOjito.Click += new System.EventHandler(this.btnOjito_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1415, 513);
            this.Controls.Add(this.registrobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.registrobox.ResumeLayout(false);
            this.registrobox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox registrobox;
        private System.Windows.Forms.Button btnOjito;
    }
}