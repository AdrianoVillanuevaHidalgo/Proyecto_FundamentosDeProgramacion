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
        public double HorasEstacionado { get; set; }

        // Constructor
        public Vehiculo(string placa, string id, double horasEstacionado)
        {
            Placa = placa;
            ID = id;
            HorasEstacionado = horasEstacionado;
        }
    }
}
