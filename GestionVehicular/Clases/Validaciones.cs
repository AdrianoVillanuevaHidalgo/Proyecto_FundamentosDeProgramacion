using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicular
{
    public class Validaciones
    {
        public static bool EntradaVacia(string texto)
        {
            return texto.Trim() == "";
        }

        public static bool ValidarPlaca(string placa)
        {
            placa = placa.Trim().ToUpper();
            if (placa.Length != 6)
            {
                return false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    return false;
                }
            }
            for (int i = 3; i < 6; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarCodigo(string codigo)
        {
            codigo = codigo.Trim().ToUpper();
            if (codigo.Length != 9 || !codigo.StartsWith("N00"))
            {
                return false;
            }
            for (int i = 3; i < 9; i++)
            {
                if (!char.IsDigit(codigo[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidarTipo(string tipo)
        {
            tipo = tipo.Trim().ToUpper();
            if (tipo != "AUTO" && tipo != "MOTO")
            {
                return false;
            }
            return true;
        }
    }
}
