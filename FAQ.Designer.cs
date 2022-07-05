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
            this.PreguntasBox.Location = new System.Drawing.Point(12, 75);
            this.PreguntasBox.Name = "PreguntasBox";
            this.PreguntasBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreguntasBox.Size = new System.Drawing.Size(680, 323);
            this.PreguntasBox.TabIndex = 0;
            this.PreguntasBox.TabStop = false;
            this.PreguntasBox.Text = "Preguntas Frecuentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "La inspiración para crear NagaPark vino de nuestro\r\namor hacia la cultura japones" +
    "a, mas concretamente\r\ndel anime (animación japonesa) Ijiranaide Nagatoro-San";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta2.Location = new System.Drawing.Point(-2, 180);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(630, 29);
            this.lblPregunta2.TabIndex = 2;
            this.lblPregunta2.Text = "¿Cual fue la inspiración para la creacion de NagaPark?";
            // 
            // lblRespuesta1
            // 
            this.lblRespuesta1.AutoSize = true;
            this.lblRespuesta1.Location = new System.Drawing.Point(21, 72);
            this.lblRespuesta1.Name = "lblRespuesta1";
            this.lblRespuesta1.Size = new System.Drawing.Size(271, 92);
            this.lblRespuesta1.TabIndex = 1;
            this.lblRespuesta1.Text = "Ernesto Josemaría Moretti\r\nGalo Hoyos Avilés\r\nSantiago Vittori\r\nYue Huang";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta1.Location = new System.Drawing.Point(-4, 35);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(646, 29);
            this.lblPregunta1.TabIndex = 0;
            this.lblPregunta1.Text = "¿Quiénes participaron en la creación de esta aplicación?";
            // 
            // picFAQ
            // 
            this.picFAQ.BackColor = System.Drawing.Color.Transparent;
            this.picFAQ.Image = global::Trabajo_POO_Grupo_4.Properties.Resources.faq;
            this.picFAQ.Location = new System.Drawing.Point(37, 3);
            this.picFAQ.Name = "picFAQ";
            this.picFAQ.Size = new System.Drawing.Size(75, 66);
            this.picFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFAQ.TabIndex = 4;
            this.picFAQ.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCerrar.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(258, 404);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(177, 74);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(704, 492);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.picFAQ);
            this.Controls.Add(this.PreguntasBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAQ";
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