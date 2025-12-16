using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Camion
    {
        private DateTime fecha;
        private int cantidad;
        private double valorAsegurado;

        public int NroRegistro { get; set; } = 0;

        private Stack<Auto> transporte = new Stack<Auto>();

        public Camion(DateTime fecha, int cantidad)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;
        }

        public void CargarVehiculo(Auto unAuto)
        {
            if(transporte.Count < cantidad)
            {
                transporte.Push(unAuto);
                valorAsegurado += unAuto.Precio;
            }
        }

        public Auto RetirarVehiculo()
        {
            Auto auto = null;
            if( transporte.Count > 0)
            {
                auto = transporte.Pop();
            }
            return auto;
        }

        public string[] VerCarga()
        {
            string[] carga = new string[transporte.Count];
            int i = 0;
            foreach(Auto auto in transporte)
            {
                carga[i++] = auto.ToString();
            }
            return carga;
        }

        public override string ToString()
        {
            return $"{this.NroRegistro}_{this.fecha:dd-MM-yyyy}";
        }

        public double ValorAsegurado()
        {
            return valorAsegurado;
        }

        public int CantidadVehiculos()
        {
            return transporte.Count;
        }
    }
}
