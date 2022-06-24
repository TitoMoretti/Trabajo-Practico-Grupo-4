namespace Trabajo_POO_Grupo_4
{
    partial class Bienvenido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenido));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.bienvenidobox = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.bienvenidobox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(7, 22);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(397, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Location = new System.Drawing.Point(7, 76);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(397, 49);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrarme";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // bienvenidobox
            // 
            this.bienvenidobox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bienvenidobox.Controls.Add(this.cancelar);
            this.bienvenidobox.Controls.Add(this.btnLogin);
            this.bienvenidobox.Controls.Add(this.btnRegistrar);
            this.bienvenidobox.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenidobox.Location = new System.Drawing.Point(16, 37);
            this.bienvenidobox.Margin = new System.Windows.Forms.Padding(4);
            this.bienvenidobox.Name = "bienvenidobox";
            this.bienvenidobox.Padding = new System.Windows.Forms.Padding(4);
            this.bienvenidobox.Size = new System.Drawing.Size(411, 191);
            this.bienvenidobox.TabIndex = 2;
            this.bienvenidobox.TabStop = false;
            this.bienvenidobox.Text = "Bienvenido a Nagapark! ¿Qué desea hacer?";
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.cancelar.Location = new System.Drawing.Point(8, 132);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(395, 48);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 268);
            this.Controls.Add(this.bienvenidobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cuentas Nagapark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bienvenidobox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox bienvenidobox;
        private System.Windows.Forms.Button cancelar;
    }
}

