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
        // Se crea una instancia de la clase GestionVehiculos
        GestionVehiculos gestor = new GestionVehiculos();
        private bool datosPruebaCargados = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial de columnas del DataGridView
            dgvVehiculos.ColumnCount = 5;
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.AllowUserToResizeRows = false;
            dgvVehiculos.AllowUserToResizeColumns = false;
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

            string[] tipos = { "Auto", "Moto", "Camioneta", "Bicicleta", "Scooter" };
            cboTipo.Items.AddRange(tipos);
            cboTipo.SelectedIndex = 0;

            cboBuscarPor.Items.Add("Buscar por Placa");
            cboBuscarPor.Items.Add("Buscar por Codigo");
            cboBuscarPor.SelectedIndex = 0;
            
        }

        // ===== METODOS =====
        private void ActualizarGrid()
        {
            List<Vehiculo> lista = gestor.ObtenerVehiculos();
            MostrarEnGrid(lista);
            lblAforo.Text = $"{gestor.AforoDisponible} de {gestor.capacidadMaxima} espacios.";
        }
        private void MostrarEnGrid(List<Vehiculo> lista)
        {
            dgvVehiculos.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].HoraSalida == DateTime.MinValue)
                {
                    dgvVehiculos.Rows.Add(lista[i].Placa, lista[i].Codigo, lista[i].TipoVehiculo,
                    lista[i].HoraIngreso.ToString("hh:mm tt"), $"{lista[i].HorasEstacionado:F2} hrs");
                }
            }
        }
        private void CargarDatosPrueba()
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
        public void ActualizarTextBox()
        {

            if (cboTipo.Text == "Bicicleta" || cboTipo.Text == "Scooter")
            {
                txtPlaca.Text = "No aplica";
                txtPlaca.Enabled = false;
            }

            else if (!txtPlaca.Enabled)
            {
                txtPlaca.Clear();
                txtPlaca.Enabled = true;
            }
        }
        private void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtCodigo.Clear();
            cboTipo.SelectedIndex = 0;
            txtPlaca.Focus();
        }
      
        // ===== BOTONES =====

        // Carga datos, utiles para testear
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
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

            List<Vehiculo> resultado = gestor.BuscarCoincidencias(texto, porPlaca);
            MostrarEnGrid(resultado);

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron vehículos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            gestor.OrdenarBurbuja();
            ActualizarGrid();
            MessageBox.Show("Vehículos ordenados por hora.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatosPrueba();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (dgvVehiculos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione en la tabla, el vehículo que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
                string placa = fila.Cells["Placa"].Value.ToString();
                string codigo = fila.Cells["codigo"].Value.ToString();
                string tipo = fila.Cells["Tipo de Vehiculo"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de eliminar el vehículo?\n\nPlaca: {placa}\nID: {codigo}\nTipo de Vehiculo: {tipo}",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    gestor.Eliminar(codigo);
                    ActualizarGrid();
                    MessageBox.Show("Vehículo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string placa = txtPlaca.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string tipo = cboTipo.SelectedItem.ToString();
            placa = placa.ToUpper();
            codigo = codigo.ToUpper();

            // Se valida que los TextBox no esten vacios
            if (Validaciones.EntradaVacia(placa) || Validaciones.EntradaVacia(codigo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Se valida que placa y codigo tengan un formato correcto
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

            List<Vehiculo> lista = gestor.ObtenerVehiculos();

            // Se verifica que una placa o un codigo no sean parte de un vehiculo que sigue dentro del estacionamiento 
            if (Validaciones.PlacaEstaDentro(placa, lista))
            {
                MessageBox.Show("Esa placa ya está registrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validaciones.CodigoEstaDentro(codigo, lista))
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
        private void btnPegar_Click(object sender, EventArgs e)
        {
            {
                if (dgvVehiculos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione en la tabla, el vehículo que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow fila = dgvVehiculos.SelectedRows[0];

                cboTipo.SelectedItem = fila.Cells["Tipo de Vehiculo"].Value.ToString();
                txtPlaca.Text = fila.Cells["Placa"].Value.ToString();
                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione en la tabla, el vehículo que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Datos actuales del vehiculo seleccionado
            DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
            string idOriginal = fila.Cells["codigo"].Value.ToString();
            string placaOriginal = fila.Cells["Placa"].Value.ToString();
            string tipoOriginal = fila.Cells["Tipo de Vehiculo"].Value.ToString();

            // Datos nuevos escritos en los campos
            string tipo = cboTipo.SelectedItem.ToString();
            string codigo = txtCodigo.Text.Trim().ToUpper();
            string placa = txtPlaca.Text.Trim();

            // "No aplica" se deja tal cual
            if (txtPlaca.Enabled)
            {
                placa = placa.ToUpper();
            }

            if (Validaciones.EntradaVacia(placa) || Validaciones.EntradaVacia(codigo))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPlaca.Enabled && !Validaciones.ValidarPlaca(placa))
            {
                MessageBox.Show("La placa debe tener 3 letras seguidas de 3 números (ejemplo: BTS419)", "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return;
            }

            if (!Validaciones.ValidarCodigo(codigo))
            {
                MessageBox.Show("El codigo debe empezar con \"N00\" seguido de 6 números (ejemplo: N00221488)", "codigo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            // La placa y el codigo no deben pertenecer a OTRO vehiculo
            Vehiculo conMismaPlaca = gestor.BuscarPorPlaca(placa);
            if (conMismaPlaca != null && conMismaPlaca.Codigo != idOriginal)
            {
                MessageBox.Show("Esa placa ya está registrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vehiculo conMismoID = gestor.BuscarPorCodigo(codigo);
            if (conMismoID != null && codigo != idOriginal)
            {
                MessageBox.Show("Ese código ya está registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmacion mostrando el antes y despues
            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de modificar el vehículo?\n\n" +
                $"ANTES\nPlaca: {placaOriginal}\nID: {idOriginal}\nTipo de Vehiculo: {tipoOriginal}\n\n" +
                $"DESPUÉS\nPlaca: {placa}\nID: {codigo}\nTipo de Vehiculo: {tipo}",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                gestor.Modificar(idOriginal, placa, codigo, tipo);
                ActualizarGrid();
                LimpiarCampos();
                MessageBox.Show("Vehículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            List<string> historial = gestor.ObtenerHistorial();

            if (historial.Count == 0 )
            {
                MessageBox.Show(
                    "No hay actividad registrada",
                    "Historial Vacio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string mensaje = string.Join("\n", historial);

            MessageBox.Show(
                mensaje,
                "Historial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }
        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione en la tabla, el vehículo que va a salir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dgvVehiculos.SelectedRows[0];
            string placa = fila.Cells["Placa"].Value.ToString();
            string codigo = fila.Cells["codigo"].Value.ToString();
            string tipo = fila.Cells["Tipo de Vehiculo"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Registrar la salida del vehículo?\n\nPlaca: {placa}\nID: {codigo}\nTipo de Vehiculo: {tipo}",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                gestor.RegistrarSalida(codigo);
                ActualizarGrid();
                MessageBox.Show("Salida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        // ===== OTROS CONTROLES =====
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTextBox();
        }
    }
}