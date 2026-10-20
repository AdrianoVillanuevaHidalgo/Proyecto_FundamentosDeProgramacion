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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnMayorTiempo = new System.Windows.Forms.Button();
            this.btnMenorTiempo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.lblAforo = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(52, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(541, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROL DE VEHÍCULOS  EN ESTACIONAMIENTO";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtTipo);
            this.gbDatos.Controls.Add(this.txtID);
            this.gbDatos.Controls.Add(this.txtPlaca);
            this.gbDatos.Controls.Add(this.lblTipo);
            this.gbDatos.Controls.Add(this.lblID);
            this.gbDatos.Controls.Add(this.lblPlaca);
            this.gbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(81, 81);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(276, 131);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Vehículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "(Auto/Moto)";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(159, 88);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(159, 21);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 22);
            this.txtPlaca.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 94);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(125, 16);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Vehiculo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(134, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Codigo de Alumno";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(7, 27);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(47, 16);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(363, 81);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(176, 43);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(363, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(176, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(363, 169);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(176, 43);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbuja.Location = new System.Drawing.Point(363, 218);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(176, 43);
            this.btnBurbuja.TabIndex = 5;
            this.btnBurbuja.Text = "Ordenar";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnMayorTiempo
            // 
            this.btnMayorTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorTiempo.Location = new System.Drawing.Point(81, 267);
            this.btnMayorTiempo.Name = "btnMayorTiempo";
            this.btnMayorTiempo.Size = new System.Drawing.Size(235, 43);
            this.btnMayorTiempo.TabIndex = 7;
            this.btnMayorTiempo.Text = "Mayor Tiempo";
            this.btnMayorTiempo.UseVisualStyleBackColor = true;
            this.btnMayorTiempo.Click += new System.EventHandler(this.btnMayorTiempo_Click);
            // 
            // btnMenorTiempo
            // 
            this.btnMenorTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorTiempo.Location = new System.Drawing.Point(322, 267);
            this.btnMenorTiempo.Name = "btnMenorTiempo";
            this.btnMenorTiempo.Size = new System.Drawing.Size(217, 43);
            this.btnMenorTiempo.TabIndex = 8;
            this.btnMenorTiempo.Text = "Menor Tiempo";
            this.btnMenorTiempo.UseVisualStyleBackColor = true;
            this.btnMenorTiempo.Click += new System.EventHandler(this.btnMenorTiempo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(81, 217);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(276, 43);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(81, 329);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(458, 169);
            this.dgvVehiculos.TabIndex = 10;
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAforo.Location = new System.Drawing.Point(52, 43);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(178, 25);
            this.lblAforo.TabIndex = 11;
            this.lblAforo.Text = "Aforo Disponible:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 533);
            this.Controls.Add(this.lblAforo);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMenorTiempo);
            this.Controls.Add(this.btnMayorTiempo);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Sistema de Control de Estacionamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnMayorTiempo;
        private System.Windows.Forms.Button btnMenorTiempo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private Label label1;
        private Label lblAforo;
    }
}

