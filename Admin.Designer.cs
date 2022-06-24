namespace Trabajo_POO_Grupo_4
{
    partial class Admin
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
            this.dgvGestionarUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGestionarUsuarios
            // 
            this.dgvGestionarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionarUsuarios.Location = new System.Drawing.Point(13, 13);
            this.dgvGestionarUsuarios.Name = "dgvGestionarUsuarios";
            this.dgvGestionarUsuarios.RowHeadersWidth = 51;
            this.dgvGestionarUsuarios.RowTemplate.Height = 24;
            this.dgvGestionarUsuarios.Size = new System.Drawing.Size(835, 505);
            this.dgvGestionarUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(864, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(127, 61);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(863, 79);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(127, 61);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.btnModificarUsuario.Location = new System.Drawing.Point(864, 146);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(127, 61);
            this.btnModificarUsuario.TabIndex = 3;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 530);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvGestionarUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGestionarUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
    }
}