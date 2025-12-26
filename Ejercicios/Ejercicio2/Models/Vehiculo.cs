using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Vehiculo:IComparable
    {
        private string nroPatente;
        private NuevoCliente cliente;

        public Vehiculo(string patente)
        {
            this.nroPatente = patente;
        }

        public NuevoCliente VerDueño()
        {
            return this.cliente;
        }

        public string VerPatente()
        {
            return this.nroPatente;
        }

        public int CompareTo(object obj)
        {
            Vehiculo nuevoVehiculo = obj as Vehiculo;
            if(nuevoVehiculo != null)
            {
                return this.nroPatente.CompareTo(nuevoVehiculo.nroPatente);
            }
            return -1;
        }


    }
}
