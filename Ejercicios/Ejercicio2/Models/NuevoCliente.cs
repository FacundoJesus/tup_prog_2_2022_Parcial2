using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class NuevoCliente:Ticket
    {
        private long dni;
        private static int numero;

        public NuevoCliente(long dni)
        {
            if (dni < 5000000)
            {
                throw new DNINoValidoException("DNI menor a 5.000.000");
            }
            this.dni = dni;
            numero++;
        }

        public override string ToString()
        {
            return $"NUEVOCLIENTE;{this.dni};nº {numero}";
        }
    }
}
