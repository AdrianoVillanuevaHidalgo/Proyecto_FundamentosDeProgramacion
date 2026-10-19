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
        public bool Registrar(string placa, string id, string tipo)
        {
            if (cantidad < capacidadMaxima)
            {
                vehiculos[cantidad] = new Vehiculo(placa, id, tipo);
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
    }
}
