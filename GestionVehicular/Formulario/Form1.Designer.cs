using System;
using System.Windows.Forms;

namespace GestionVehicular
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnMayorTiempo = new System.Windows.Forms.Button();
            this.btnMenorTiempo = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAforo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnPegar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Gold;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(496, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROL DE VEHÍCULOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(189, 182);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 27);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(189, 140);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(110, 27);
            this.txtPlaca.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(25, 226);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(160, 24);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Vehiculo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(25, 184);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(160, 24);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo de Alumno:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblPlaca.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPlaca.Location = new System.Drawing.Point(25, 142);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(160, 24);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(26, 266);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(159, 51);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbuja.Location = new System.Drawing.Point(500, 143);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(217, 48);
            this.btnBurbuja.TabIndex = 5;
            this.btnBurbuja.Text = "Ordenar";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnMayorTiempo
            // 
            this.btnMayorTiempo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorTiempo.Location = new System.Drawing.Point(26, 645);
            this.btnMayorTiempo.Name = "btnMayorTiempo";
            this.btnMayorTiempo.Size = new System.Drawing.Size(217, 51);
            this.btnMayorTiempo.TabIndex = 7;
            this.btnMayorTiempo.Text = "Mayor Tiempo";
            this.btnMayorTiempo.UseVisualStyleBackColor = true;
            this.btnMayorTiempo.Click += new System.EventHandler(this.btnMayorTiempo_Click);
            // 
            // btnMenorTiempo
            // 
            this.btnMenorTiempo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorTiempo.Location = new System.Drawing.Point(257, 645);
            this.btnMenorTiempo.Name = "btnMenorTiempo";
            this.btnMenorTiempo.Size = new System.Drawing.Size(218, 51);
            this.btnMenorTiempo.TabIndex = 8;
            this.btnMenorTiempo.Text = "Menor Tiempo";
            this.btnMenorTiempo.UseVisualStyleBackColor = true;
            this.btnMenorTiempo.Click += new System.EventHandler(this.btnMenorTiempo_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AllowUserToResizeColumns = false;
            this.dgvVehiculos.AllowUserToResizeRows = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(26, 430);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersVisible = false;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(692, 205);
            this.dgvVehiculos.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(-3, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 109);
            this.panel1.TabIndex = 12;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.BackColor = System.Drawing.Color.Gold;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 15F);
            this.lblTitulo2.Location = new System.Drawing.Point(82, 47);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(358, 45);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "EN ESTACIONAMIENTO";
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "AFORO DISPONIBLE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAforo
            // 
            this.lblAforo.BackColor = System.Drawing.Color.Gold;
            this.lblAforo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAforo.Location = new System.Drawing.Point(512, 57);
            this.lblAforo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(209, 24);
            this.lblAforo.TabIndex = 17;
            this.lblAforo.Text = "*Aforo Disponible*";
            this.lblAforo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "DATOS DEL VEHÍCULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 10F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto"});
            this.cboTipo.Location = new System.Drawing.Point(189, 224);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(109, 27);
            this.cboTipo.TabIndex = 19;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(26, 321);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(272, 48);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(511, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "ACCIONES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(500, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(217, 48);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.Location = new System.Drawing.Point(501, 267);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(217, 48);
            this.btnRegistrarSalida.TabIndex = 5;
            this.btnRegistrarSalida.Text = "Registrar Salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorial.Location = new System.Drawing.Point(501, 329);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(217, 48);
            this.btnVerHistorial.TabIndex = 5;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.Font = new System.Drawing.Font("Arial", 10F);
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Location = new System.Drawing.Point(26, 394);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(187, 27);
            this.cboBuscarPor.TabIndex = 21;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(219, 394);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 27);
            this.txtBuscar.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(346, 393);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 30);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackgroundImage = global::GestionVehicular.Properties.Resources.lapiz_20;
            this.btnCargarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(606, 645);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(51, 51);
            this.btnCargarDatos.TabIndex = 4;
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnPegar
            // 
            this.btnPegar.BackgroundImage = global::GestionVehicular.Properties.Resources.Pegar_20;
            this.btnPegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPegar.Location = new System.Drawing.Point(189, 266);
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(53, 51);
            this.btnPegar.TabIndex = 9;
            this.btnPegar.UseVisualStyleBackColor = true;
            this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::GestionVehicular.Properties.Resources.bote_de_basura_20;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(246, 266);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(53, 51);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::GestionVehicular.Properties.Resources.actualizar_20;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(667, 645);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 51);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(745, 708);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAforo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnPegar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMenorTiempo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnMayorTiempo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sistema de Control de Estacionamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnMayorTiempo;
        private System.Windows.Forms.Button btnMenorTiempo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private Panel panel1;
        private Label lblTitulo2;
        private Label label2;
        private Label lblAforo;
        private Label label1;
        private ComboBox cboTipo;
        private Button btnPegar;
        private Button btnModificar;
        private Label label3;
        private Button btnEliminar;
        private Button btnRegistrarSalida;
        private Button btnVerHistorial;
        private ComboBox cboBuscarPor;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCargarDatos;
    }
}

