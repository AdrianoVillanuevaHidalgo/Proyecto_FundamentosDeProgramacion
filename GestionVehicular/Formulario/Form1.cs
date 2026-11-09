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
        private bool datosPruebaCargados = false;

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
            dgvVehiculos.Columns[1].Name = "Codigo";
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
            Vehiculo[] arreglo = gestor.ObtenerVehiculos(out int total);
            MostrarEnGrid(arreglo, total);
            lblAforo.Text = $"{gestor.AforoDisponible} de {gestor.capacidadMaxima} espacios.";
        }

        private void MostrarEnGrid(Vehiculo[] arreglo, int total)
        {
            dgvVehiculos.Rows.Clear();
            for (int i = 0; i < total; i++)
            {
                dgvVehiculos.Rows.Add(arreglo[i].Placa, arreglo[i].Codigo, arreglo[i].TipoVehiculo,
                    arreglo[i].HoraIngreso.ToString("hh:mm tt"), $"{arreglo[i].HorasEstacionado:F2} hrs");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string placa = txtPlaca.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string tipo = cboTipo.SelectedItem == null ? "" : cboTipo.SelectedItem.ToString();
            placa = placa.ToUpper();
            codigo = codigo.ToUpper();

            if (Validaciones.EntradaVacia(placa) || Validaciones.EntradaVacia(codigo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!txtPlaca.Enabled)
            {
                placa = txtPlaca.Text.Trim();
            }
            else
            {
                if (!Validaciones.ValidarPlaca(placa))
                {
                    MessageBox.Show("La placa debe tener 3 letras seguidas de 3 números (ejemplo: BTS419)", "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    return;
                }
            }
            if (!Validaciones.ValidarCodigo(codigo))
            {
                MessageBox.Show("El codigo debe empezar con \"N00\" seguido de 6 números (ejemplo: N00221488)", "codigo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }


            if (gestor.BuscarPorPlaca(placa) != null)
            {
                MessageBox.Show("Esa placa ya está registrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.BuscarPorCodigo(codigo) != null)
            {
                MessageBox.Show("Ese código ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registrado = gestor.Registrar(placa, codigo, tipo);
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
            string texto = txtBuscar.Text.Trim();

            if (Validaciones.EntradaVacia(texto))
            {
                MessageBox.Show("Escriba el texto a buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            bool porPlaca = cboBuscarPor.SelectedIndex == 0;

            Vehiculo[] resultado = gestor.BuscarCoincidencias(texto, porPlaca, out int total);
            MostrarEnGrid(resultado, total);

            if (total == 0)
            {
                MessageBox.Show("No se encontraron vehículos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Vehículo con Mayor Tiempo:\nPlaca: {v.Placa}\nCodigo: {v.Codigo}\nTipo de Vehiculo: {v.TipoVehiculo}\nHoras: {v.HorasEstacionado:F2} hrs", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Vehículo con Menor Tiempo:\nPlaca: {v.Placa}\nCodigo: {v.Codigo}\nTipo de Vehiculo: {v.TipoVehiculo}\nHoras: {v.HorasEstacionado:F2} hrs", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCodigo.Clear();
            cboTipo.SelectedIndex = 0;
            txtPlaca.Focus();
        }

        // Carga datos, utiles para testear
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            if (datosPruebaCargados)
            {
                return;
            }
            datosPruebaCargados = true;

            gestor.Registrar("BTS419", "N00221480", "Auto");
            gestor.BuscarPorCodigo("N00221480").HoraIngreso = DateTime.Now.AddHours(-5.5);

            gestor.Registrar("XYZ789", "N00221481", "Moto");
            gestor.BuscarPorCodigo("N00221481").HoraIngreso = DateTime.Now.AddHours(-2);

            gestor.Registrar("ABC123", "N00746281", "Camioneta");
            gestor.BuscarPorCodigo("N00746281").HoraIngreso = DateTime.Now.AddHours(-8.25);

            gestor.Registrar("KLM456", "N00391852", "Auto");
            gestor.BuscarPorCodigo("N00391852").HoraIngreso = DateTime.Now.AddHours(-0.5);

            gestor.Registrar("PQR321", "N00827514", "Moto");
            gestor.BuscarPorCodigo("N00827514").HoraIngreso = DateTime.Now.AddHours(-3.75);

            gestor.Registrar("DEF654", "N00563197", "Camioneta");
            gestor.BuscarPorCodigo("N00563197").HoraIngreso = DateTime.Now.AddHours(-6);

            gestor.Registrar("GHI987", "N00652918", "Auto");
            gestor.BuscarPorCodigo("N00652918").HoraIngreso = DateTime.Now.AddHours(-1.25);

            gestor.Registrar("No aplica", "N00195764", "Bicicleta");
            gestor.BuscarPorCodigo("N00195764").HoraIngreso = DateTime.Now.AddHours(-4);

            gestor.Registrar("No aplica", "N00362857", "Scooter");
            gestor.BuscarPorCodigo("N00362857").HoraIngreso = DateTime.Now.AddHours(-0.75);

            gestor.Registrar("STU579", "N00248361", "Moto");
            gestor.BuscarPorCodigo("N00248361").HoraIngreso = DateTime.Now.AddHours(-7);

            ActualizarGrid();
            btnCargarDatos.Enabled = false;
        }
    }
}
