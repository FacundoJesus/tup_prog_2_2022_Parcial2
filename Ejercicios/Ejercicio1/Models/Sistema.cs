using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Sistema
    {
        private int nroOrden;
        public int NroOrden {  
            get
            {
                return nroOrden++;
            }
        }

        private List<Auto> listaAutos = new List<Auto>();
        private List<Camion> listaCamiones = new List<Camion>();

        public int GenerarCamion(DateTime fecha, int capacidad)
        {
            Camion nuevoCamion = new Camion(fecha, capacidad);
            listaCamiones.Add(nuevoCamion);
            nuevoCamion.NroRegistro = NroOrden;
            return NroOrden;
        }

        public void RecibirCamion(Camion unCamion)
        {
            listaCamiones.Add(unCamion);
            unCamion.NroRegistro = NroOrden;
        }

        public Auto DescargarCamion(int nroOrden)
        {
            Camion camionBuscado = BuscarCamion(nroOrden);
            Auto auto = null;
            if(camionBuscado != null)
            {
                auto = camionBuscado.RetirarVehiculo();
                listaAutos.Add(auto);
            }
            return auto;
        }

        public void CargarCamion(int nroOrden,Auto unAuto)
        {
            Camion camionBuscado = BuscarCamion(nroOrden);
            if(camionBuscado != null)
            {
                camionBuscado.CargarVehiculo(unAuto);
                listaAutos.Remove(unAuto);
            }

        }

        private Camion BuscarCamion(int nroOrden)
        {
            int pos = -1;
            int i = 0;
            while(pos == -1 &&  i < listaCamiones.Count)
            {
                if (listaCamiones[i].NroRegistro == nroOrden)
                {
                    pos = i;
                }
                i++;
            }

            Camion camion = null;
            if(pos != -1)
            {
                camion = listaCamiones[pos];
            }
            return camion;
        }

        public void CerrarCamion(int nroOrden)
        {
            Camion camionBuscado = BuscarCamion(nroOrden);

            if(camionBuscado != null)
            {
                string path = camionBuscado.ToString() + ".csv";
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("nroRegistro;Modelo");
                    foreach(string linea in camionBuscado.VerCarga())
                    {
                        sw.WriteLine(linea);
                    }
                }
                catch(Exception ex) 
                { throw ex; }
                finally
                {
                    if (sw != null) sw.Close();
                    if(fs != null) fs.Close();
                }
            }
        }

    }
}
