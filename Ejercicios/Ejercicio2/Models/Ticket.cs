using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public abstract class Ticket
    {

        private int nroOrden;
        private DateTime fechaHora;

        public int VerNro()
        {
            return this.nroOrden;
        }

        public DateTime VerFechaHora() 
        { 
            return this.fechaHora;
        }

    }
}
