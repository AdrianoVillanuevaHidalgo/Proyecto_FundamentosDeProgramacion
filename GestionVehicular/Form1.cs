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
            dgvVehiculos.ColumnCount = 5;
            dgvVehiculos.Columns[0].Name = "Placa";
            dgvVehiculos.Columns[1].Name = "ID";
            dgvVehiculos.Columns[2].Name = "Tipo de Vehiculo";
            dgvVehiculos.Columns[3].Name = "Hora de Ingreso";
            dgvVehiculos.Columns[4].Name = "Horas Estacionado";
            foreach (DataGridViewColumn columna in dgvVehiculos.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            dgvVehiculos.Rows.Clear();
            Vehiculo[] lista = gestor.ObtenerVehiculos(out int total);
            for (int i = 0; i < total; i++)
            {
                dgvVehiculos.Rows.Add(lista[i].Placa, lista[i].ID, lista[i].TipoVehiculo, lista[i].HoraIngreso.ToString("hh:mm tt"), $"{lista[i].HorasEstacionado:F2} hrs");
            }
            lblAforo.Text = $"Aforo Disponible: {gestor.AforoDisponible} de {gestor.capacidadMaxima} espacios.";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            string id = txtID.Text.Trim();
            string tipo = txtTipo.Text.Trim().ToUpper();
            placa = placa.ToUpper();
            id = id.ToUpper();

            if (Validaciones.EntradaVacia(placa) || Validaciones.EntradaVacia(id))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Validaciones.ValidarPlaca(placa))
            {
                MessageBox.Show("La placa debe tener 3 letras seguidas de 3 números (ejemplo: BTS419)", "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return;
            }

            if (!Validaciones.ValidarID(id))
            {
                MessageBox.Show("El ID debe empezar con \"N00\" seguido de 6 números (ejemplo: N00221488)", "ID inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }

            if (!Validaciones.ValidarTipo(tipo))
            {
                MessageBox.Show("El tipo de vehiculo debe ser un auto o una moto", "Tipo de Vehiculo invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipo.Focus();
                return;
            }
            bool registrado = gestor.Registrar(placa, id, tipo);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.Trim();
            Vehiculo v = gestor.BuscarPorPlaca(placa);
            if (v != null)
            {
                txtID.Text = v.ID;
                txtTipo.Text = v.TipoVehiculo.ToString();
                MessageBox.Show("¡Vehículo encontrado!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado con esa placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            gestor.OrdenarBurbuja();
            ActualizarGrid();
            MessageBox.Show("Vehículos ordenados por hora.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMayorTiempo_Click(object sender, EventArgs e)
        {
            Vehiculo v = gestor.MayorTiempo();
            if (v != null)
            {
                MessageBox.Show($"Vehículo con Mayor Tiempo:\nPlaca: {v.Placa}\nID: {v.ID}\nTipo de Vehiculo: {v.TipoVehiculo}\nHoras: {v.HorasEstacionado:F2} hrs", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Vehículo con Menor Tiempo:\nPlaca: {v.Placa}\nID: {v.ID}\nTipo de Vehiculo: {v.TipoVehiculo}\nHoras: {v.HorasEstacionado:F2} hrs", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtTipo.Clear();
            txtPlaca.Focus();
        }
    }
}
