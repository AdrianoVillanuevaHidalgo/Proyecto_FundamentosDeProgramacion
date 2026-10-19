using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVehicular
{
    public partial class Form1 : Form
    {
        private GestionVehiculos gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = new GestionVehiculos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial de columnas del DataGridView
            dgvVehiculos.ColumnCount = 3;
            dgvVehiculos.Columns[0].Name = "Placa";
            dgvVehiculos.Columns[1].Name = "ID";
            dgvVehiculos.Columns[2].Name = "Horas";
        }

        private void ActualizarGrid()
        {
            dgvVehiculos.Rows.Clear();
            Vehiculo[] lista = gestor.ObtenerVehiculos(out int total);
            for (int i = 0; i < total; i++)
            {
                dgvVehiculos.Rows.Add(lista[i].Placa, lista[i].ID, lista[i].HorasEstacionado);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            string id = txtID.Text.Trim();

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(txtHoras.Text, out double horas))
            {
                bool registrado = gestor.Registrar(placa, id, horas);
                if (registrado)
                {
                    MessageBox.Show("Vehículo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("El estacionamiento está lleno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para las horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            Vehiculo v = gestor.BuscarPorPlaca(placa);
            if (v != null)
            {
                txtID.Text = v.ID;
                txtHoras.Text = v.HorasEstacionado.ToString();
                MessageBox.Show("¡Vehículo encontrado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado con esa placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            gestor.OrdenarBurbuja();
            ActualizarGrid();
            MessageBox.Show("Vehículos ordenados por método Burbuja.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            gestor.OrdenarSeleccion();
            ActualizarGrid();
            MessageBox.Show("Vehículos ordenados por método Selección.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMayorTiempo_Click(object sender, EventArgs e)
        {
            Vehiculo v = gestor.MayorTiempo();
            if (v != null)
            {
                MessageBox.Show($"Vehículo con Mayor Tiempo:\nPlaca: {v.Placa}\nID: {v.ID}\nHoras: {v.HorasEstacionado}", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay vehículos registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMenorTiempo_Click(object sender, EventArgs e)
        {
            Vehiculo v = gestor.MenorTiempo();
            if (v != null)
            {
                MessageBox.Show($"Vehículo con Menor Tiempo:\nPlaca: {v.Placa}\nID: {v.ID}\nHoras: {v.HorasEstacionado}", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay vehículos registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtID.Clear();
            txtHoras.Clear();
            txtPlaca.Focus();
        }
    }
}
