namespace Trabajo_POO_Grupo_4
{
    partial class FAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQ));
            this.PreguntasBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.lblRespuesta1 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.picFAQ = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PreguntasBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFAQ)).BeginInit();
            this.SuspendLayout();
            // 
            // PreguntasBox
            // 
            this.PreguntasBox.Controls.Add(this.label1);
            this.PreguntasBox.Controls.Add(this.lblPregunta2);
            this.PreguntasBox.Controls.Add(this.lblRespuesta1);
            this.PreguntasBox.Controls.Add(this.lblPregunta1);
            this.PreguntasBox.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreguntasBox.Location = new System.Drawing.Point(8, 49);
            this.PreguntasBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreguntasBox.Name = "PreguntasBox";
            this.PreguntasBox.Size = new System.Drawing.Size(453, 210);
            this.PreguntasBox.TabIndex = 0;
            this.PreguntasBox.TabStop = false;
            this.PreguntasBox.Text = "Preguntas Frecuentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "La inspiración para crear NagaPark vino de nuestro\r\namor hacia la cultura japones" +
    "a, mas concretamente\r\ndel anime (animación japonesa) Ijiranaide Nagatoro-San";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta2.Location = new System.Drawing.Point(-2, 117);
            this.lblPregunta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(433, 20);
            this.lblPregunta2.TabIndex = 2;
            this.lblPregunta2.Text = "¿Cual fue la inspiración para la creacion de NagaPark?";
            // 
            // lblRespuesta1
            // 
            this.lblRespuesta1.AutoSize = true;
            this.lblRespuesta1.Location = new System.Drawing.Point(14, 47);
            this.lblRespuesta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRespuesta1.Name = "lblRespuesta1";
            this.lblRespuesta1.Size = new System.Drawing.Size(185, 68);
            this.lblRespuesta1.TabIndex = 1;
            this.lblRespuesta1.Text = "Ernesto Josemaría Moretti\r\nGalo Hoyos Avilés\r\nSantiago Vittori\r\nYue Huang";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta1.Location = new System.Drawing.Point(-3, 23);
            this.lblPregunta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(443, 20);
            this.lblPregunta1.TabIndex = 0;
            this.lblPregunta1.Text = "¿Quiénes participaron en la creación de esta aplicación?";
            // 
            // picFAQ
            // 
            this.picFAQ.BackColor = System.Drawing.Color.Transparent;
            this.picFAQ.Image = global::Trabajo_POO_Grupo_4.Properties.Resources.faq;
            this.picFAQ.Location = new System.Drawing.Point(25, 2);
            this.picFAQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picFAQ.Name = "picFAQ";
            this.picFAQ.Size = new System.Drawing.Size(50, 43);
            this.picFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFAQ.TabIndex = 4;
            this.picFAQ.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCerrar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(172, 262);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 48);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(470, 320);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.picFAQ);
            this.Controls.Add(this.PreguntasBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FAQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAQ";
            this.PreguntasBox.ResumeLayout(false);
            this.PreguntasBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFAQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PreguntasBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.Label lblRespuesta1;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.PictureBox picFAQ;
        private System.Windows.Forms.Button btnCerrar;
    }
}