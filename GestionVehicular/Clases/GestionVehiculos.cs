using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicular
{
    public class GestionVehiculos
    {
        private Vehiculo[] vehiculos;
        public int cantidad { get; private set; }
        public int capacidadMaxima { get; } = 100;
        public int AforoDisponible
        {
            get { return capacidadMaxima - cantidad; }
        }
        public GestionVehiculos()
        {
            vehiculos = new Vehiculo[capacidadMaxima];
            cantidad = 0;
        }

        // Registrar vehículo
        public bool Registrar(string placa, string codigo, string tipo)
        {
            if (cantidad < capacidadMaxima)
            {
                vehiculos[cantidad] = new Vehiculo(placa, codigo, tipo);
                cantidad++;
                return true;
            }
            return false; // Arreglo lleno
        }

        // Buscar vehículo por placa
        public Vehiculo BuscarPorPlaca(string placa)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (vehiculos[i].Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
                {
                    return vehiculos[i];
                }
            }
            return null;
        }

        // Metodo que busca vehículo por codigo
        // devuelve null si el codigo no esta registrado
        public Vehiculo BuscarPorCodigo(string codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (vehiculos[i].Codigo == codigo)
                {
                    return vehiculos[i];
                }
            }
            return null;
        }

        // Método para obtener todos los vehículos actuales
        public Vehiculo[] ObtenerVehiculos(out int total)
        {
            total = cantidad;
            return vehiculos;
        }

        // Ordenamiento por Burbuja (segun horas de permanencia)
        public void OrdenarBurbuja()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - i - 1; j++)
                {
                    if (vehiculos[j].HorasEstacionado > vehiculos[j + 1].HorasEstacionado)
                    {
                        Vehiculo aux = vehiculos[j];
                        vehiculos[j] = vehiculos[j + 1];
                        vehiculos[j + 1] = aux;
                    }
                }
            }
        }

        // Vehículo con mayor tiempo
        public Vehiculo MayorTiempo()
        {
            if (cantidad == 0) return null;
            Vehiculo mayor = vehiculos[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (vehiculos[i].HorasEstacionado > mayor.HorasEstacionado)
                {
                    mayor = vehiculos[i];
                }
            }
            return mayor;
        }

        // Vehículo con menor tiempo
        public Vehiculo MenorTiempo()
        {
            if (cantidad == 0) return null;
            Vehiculo menor = vehiculos[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (vehiculos[i].HorasEstacionado < menor.HorasEstacionado)
                {
                    menor = vehiculos[i];
                }
            }
            return menor;
        }

        // Metodo que devuelve un arreglo con los vehiculos que coincidieron con la busqueda
        public Vehiculo[] BuscarCoincidencias(string texto, bool porPlaca, out int total)
        {
            // Se crea el arreglo para almacenar las coincidencias
            // el arreglo tengra la misma longitud que el de las casillas ocupadas en el arreglo Vehiculos
            Vehiculo[] coincidencias = new Vehiculo[cantidad];
            total = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Vehiculo vehiculo = vehiculos[i];
                string dato;

                if (porPlaca)
                {
                    dato = vehiculo.Placa;
                }
                else
                {
                    dato = vehiculo.Codigo;
                }

                // busca el string texto dentro del string dato
                // StringComparison.OrdinalIgnoreCase hace que se ignoren mayusculas y minusculas
                bool contieneTexto = dato.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;

                if (contieneTexto)
                {
                    coincidencias[total] = vehiculo;
                    total++;
                }
            }
            return coincidencias;
        }

        // Metodo para modificar una instacia de la clase vehiculo
        public void Modificar(string idOriginal, string placa, string codigo, string tipo)
        {
            Vehiculo vehiculo = BuscarPorCodigo(idOriginal);

            vehiculo.Placa = placa;
            vehiculo.Codigo = codigo;
            vehiculo.TipoVehiculo = tipo;
        }
    }
}
