using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicular
{
    public class GestionVehiculos
    {
        //Propiedades de cualquier instancia de la clase GestionVehiculos
        private List<Vehiculo> vehiculos;
        public int cantidad { get { return vehiculos.Count(v => v.HoraSalida == DateTime.MinValue); } }
        public int capacidadMaxima { get; } = 100;
        public int AforoDisponible
        {
            get { return capacidadMaxima - cantidad; }
        }
        
        // Metodo constructor de la clase GestionVehiculos
        public GestionVehiculos()
        {
            vehiculos = new List<Vehiculo>();
        }


        // Registrar vehículo
        public bool Registrar(string placa, string codigo, string tipo)
        {
            if (cantidad < capacidadMaxima)
            {
                Vehiculo nuevo = new Vehiculo(placa, codigo, tipo);
                vehiculos.Add(nuevo);
                return true;
            }
            return false; // Aforo lleno
        }

        // Metodo que busca vehículo por placa
        // devuelve null si la placa no esta registrada o si es "no aplica"
        public Vehiculo BuscarPorPlaca(string placa)
        {
            // no se considera "No aplica", ya que varios vehiculos pueden compartir esa "placa"
            if (placa == "No aplica")
            {
                return null;
            }
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].HoraSalida != DateTime.MinValue)
                {
                    continue;
                }
                if (vehiculos[i].Placa == placa)
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
            for (int i = 0; i < vehiculos.Count ; i++)
            {
                if (!(vehiculos[i].HoraSalida == DateTime.MinValue))
                {
                    continue;
                }
                  
                if (vehiculos[i].Codigo == codigo)
                {
                    return vehiculos[i];
                }
            }
            return null;
        }

        // Método para obtener todos los vehículos actuales
        public List<Vehiculo> ObtenerVehiculos()
        {
            return vehiculos;
        }

        // Ordenamiento por Burbuja (segun horas de permanencia)
        public void OrdenarBurbuja()
        {
            for (int i = 0; i < vehiculos.Count; i++)
            {
                for (int j = 0; j < vehiculos.Count - i - 1; j++)
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
            if (vehiculos.Count == 0) return null;
            Vehiculo mayor = vehiculos[0];
            for (int i = 1; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].HoraSalida != DateTime.MinValue)
                {
                    continue;
                }

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
            if (vehiculos.Count == 0) return null;
            Vehiculo menor = vehiculos[0];
            for (int i = 1; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].HoraSalida != DateTime.MinValue)
                {
                    continue;
                }

                if (vehiculos[i].HorasEstacionado < menor.HorasEstacionado)
                {
                    menor = vehiculos[i];
                }
            }
            return menor;
        }

        // Metodo para eliminar un elemento del arreglo Vehiculos segun la fila seleccionada
        public void Eliminar(string codigo)
        {
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Codigo == codigo && vehiculos[i].HoraSalida == DateTime.MinValue)
                {
                    vehiculos.RemoveAt(i);
                    return;
                }
            }
        }

        // Metodo que devuelve un arreglo con los vehiculos que coincidieron con la busqueda
        public List<Vehiculo> BuscarCoincidencias(string texto, bool porPlaca)
        {
            List<Vehiculo> coincidencias = new List<Vehiculo>();

            for (int i = 0; i < vehiculos.Count; i++)
            {
                
                Vehiculo vehiculo = vehiculos[i];

                if (vehiculo.HoraSalida != DateTime.MinValue) continue;

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
                    coincidencias.Add(vehiculo);
                }
            }
            return coincidencias;
        }
        // Metodo que arma el texto de una linea del historial
        private string CrearTexto(Vehiculo vehiculo, string accion)
        {
            return $"El vehículo {vehiculo.TipoVehiculo} (Placa: {vehiculo.Placa} - Código: {vehiculo.Codigo}) {accion}";
        }

        // Metodo que guarda el vehiculo en la lista de retirados y lo quita del arreglo
        public void RegistrarSalida(string codigo)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.HoraSalida != DateTime.MinValue)
                {
                    continue;
                }
                if (v.Codigo == codigo)
                {
                    v.HoraSalida = DateTime.Now;
                    return;
                }
            }
        }

        // Metodo que arma el historial completo, ordenado por hora
        public List<string> ObtenerHistorial()
        {
            List<DateTime> horas = new List<DateTime>();
            List<string> acciones = new List<string>();
            List<string> historial = new List<string>();
            
            // Se arma las listas paralelas(horas y acciones)
            for (int i = 0; i < vehiculos.Count; i++)
            {
                horas.Add(vehiculos[i].HoraIngreso);
                acciones.Add(CrearTexto(vehiculos[i], "ha ingresado."));

                if (vehiculos[i].HoraSalida != DateTime.MinValue)
                {
                    horas.Add(vehiculos[i].HoraSalida);
                    acciones.Add(CrearTexto(vehiculos[i], "se ha retirado."));
                }
            }

            // Se ordenan las listas paralelas segun la hora 
            for (int i = 0;i < horas.Count;i++)
            {
                for (int j = 0; j < acciones.Count - i - 1; j++)
                {
                    if (horas[j] > horas[j+1])
                    {
                        DateTime auxHora = horas[j];
                        horas[j] = horas[j + 1];
                        horas[j + 1] = auxHora;

                        string auxAccion = acciones[j];
                        acciones[j] = acciones[j + 1];
                        acciones[j + 1] = auxAccion;
                    }
                }
            }

            // Se arma la lista que se devolvera mediante este metodo
            for (int i =0; i < horas.Count; i++)
            {
                historial.Add($"[{horas[i]}] {acciones[i]}");
            }
            return historial;
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
