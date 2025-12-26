using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Denuncia:Ticket
    {
        private Vehiculo dominio;
        private static int numero;

        public Denuncia(Vehiculo asegurado):base()
        {
            this.dominio = asegurado;
            numero++;
        }

        public override string ToString()
        {
            return $"DENUNCIA;{this.dominio.VerPatente()};nº {numero};";
        }
    }
}
