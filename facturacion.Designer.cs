
namespace Trabajo_POO_Grupo_4
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.proyectoDataSet = new Trabajo_POO_Grupo_4.ProyectoDataSet();
            this.listadeCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listadeCuentasTableAdapter = new Trabajo_POO_Grupo_4.ProyectoDataSetTableAdapters.ListadeCuentasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidadTickets = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechadeIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGestionarFacturas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCuentasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionarFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCalcularPrecio.Location = new System.Drawing.Point(21, 226);
            this.btnCalcularPrecio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(535, 37);
            this.btnCalcularPrecio.TabIndex = 0;
            this.btnCalcularPrecio.Text = "Calcular Precio";
            this.btnCalcularPrecio.UseVisualStyleBackColor = false;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.button1_Click);
            // 
            // proyectoDataSet
            // 
            this.proyectoDataSet.DataSetName = "ProyectoDataSet";
            this.proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listadeCuentasBindingSource
            // 
            this.listadeCuentasBindingSource.DataMember = "ListadeCuentas";
            this.listadeCuentasBindingSource.DataSource = this.proyectoDataSet;
            // 
            // listadeCuentasTableAdapter
            // 
            this.listadeCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtCantidadTickets);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.FechadeIngreso);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.comboBoxTipo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvGestionarFacturas);
            this.panel1.Controls.Add(this.btnCalcularPrecio);
            this.panel1.Location = new System.Drawing.Point(355, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 478);
            this.panel1.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(21, 271);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(535, 22);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtCantidadTickets
            // 
            this.txtCantidadTickets.Location = new System.Drawing.Point(257, 145);
            this.txtCantidadTickets.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCantidadTickets.Name = "txtCantidadTickets";
            this.txtCantidadTickets.Size = new System.Drawing.Size(297, 22);
            this.txtCantidadTickets.TabIndex = 16;
            this.txtCantidadTickets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadTickets_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Candidad de tickets:";
            // 
            // FechadeIngreso
            // 
            this.FechadeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadeIngreso.Location = new System.Drawing.Point(257, 181);
            this.FechadeIngreso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FechadeIngreso.Name = "FechadeIngreso";
            this.FechadeIngreso.Size = new System.Drawing.Size(297, 22);
            this.FechadeIngreso.TabIndex = 14;
            this.FechadeIngreso.Value = new System.DateTime(2022, 8, 8, 0, 0, 0, 0);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(257, 14);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(297, 22);
            this.txtUser.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(256, 78);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(297, 22);
            this.txtApellido.TabIndex = 11;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(257, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 22);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Seleccione uno...",
            "Entrada General - $ 2700",
            "Entrada VIP - $4000"});
            this.comboBoxTipo.Location = new System.Drawing.Point(257, 112);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(297, 24);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de tickets:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de Ingreso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido de Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Cliente:";
            // 
            // dgvGestionarFacturas
            // 
            this.dgvGestionarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionarFacturas.Location = new System.Drawing.Point(20, 306);
            this.dgvGestionarFacturas.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvGestionarFacturas.Name = "dgvGestionarFacturas";
            this.dgvGestionarFacturas.RowHeadersWidth = 51;
            this.dgvGestionarFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestionarFacturas.Size = new System.Drawing.Size(535, 158);
            this.dgvGestionarFacturas.TabIndex = 0;
            this.dgvGestionarFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionarFacturas_CellClick);
            this.dgvGestionarFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionarFacturas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(599, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "FACTURACIÓN DE NAGAPARK";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(935, 469);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 71);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(935, 64);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 98);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Ventas";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(935, 282);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 82);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar Ventas";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(935, 379);
            this.btnLimpiarDatos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(121, 71);
            this.btnLimpiarDatos.TabIndex = 12;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(935, 176);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(121, 98);
            this.btnDescargar.TabIndex = 13;
            this.btnDescargar.Text = "Descargar Factura";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trabajo_POO_Grupo_4.Properties.Resources.wallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1409, 569);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeCuentasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionarFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecio;
        private ProyectoDataSet proyectoDataSet;
        private System.Windows.Forms.BindingSource listadeCuentasBindingSource;
        private ProyectoDataSetTableAdapters.ListadeCuentasTableAdapter listadeCuentasTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvGestionarFacturas;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker FechadeIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidadTickets;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnDescargar;
    }
}