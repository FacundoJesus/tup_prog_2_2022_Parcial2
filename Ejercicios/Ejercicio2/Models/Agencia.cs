using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();

        private List<Vehiculo> listaVehiculos = new List<Vehiculo>
        {
            new Vehiculo("LZL594"),
            new Vehiculo("ABC123"),
            new Vehiculo("FGH851"),
            new Vehiculo("THS451"),
            new Vehiculo("OYN127"),
            new Vehiculo("DOK481"),
        };
        

        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private Queue<NuevoCliente> nuevosClientes = new Queue<NuevoCliente>();

        public void AgregarTicket(Ticket turno)
        {
            if (turno != null) {

                if(turno is Denuncia)
                {
                    denuncias.Enqueue(turno as Denuncia);
                }
                else
                if (turno is NuevoCliente) {
                    nuevosClientes.Enqueue(turno as NuevoCliente);
                }
            }

        }

        public Ticket AtenderTicket(int tipo)
        {
            Ticket turno = null;

            if (tipo == 1)
            {
                if (denuncias.Count > 0)
                {
                    turno = denuncias.Dequeue();
                    ListaAtendidos.Add(turno);
                }                
                
            }
            else
            if (tipo == 2)
            {
                if(nuevosClientes.Count > 0)
                {
                    turno = nuevosClientes.Dequeue();
                    ListaAtendidos.Add(turno);
                }
                
            }

            return turno;
        }
    }
}
