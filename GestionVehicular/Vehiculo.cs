using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicular
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string ID { get; set; }
        public string TipoVehiculo { get; set; }
        public DateTime HoraIngreso { get; set; }

        // Constructor
        public Vehiculo(string placa, string id, string tipo)
        {
            Placa = placa;
            ID = id;
            TipoVehiculo = tipo;
            HoraIngreso = DateTime.Now;
        }
        public double HorasEstacionado
        {
            get
            {
                TimeSpan diferencia = DateTime.Now - HoraIngreso;
                return diferencia.TotalHours;
            }
        }
    }
}
