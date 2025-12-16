using Ejercicio1.Models;
using Microsoft.VisualBasic.Devices;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();


        }

        private List<Auto> autos = new List<Auto>();

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                sistema = bf.Deserialize(fs) as Sistema;
                #pragma warning restore SYSLIB0011
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Deserializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            
            autos.AddRange(new List<Auto> {
                new Auto(100, "Audi AA"),
                new Auto(110,"Cronos TZ"),
                new Auto(120,"Cronos TZ"),
                new Auto(120,"Cronos Full"),
                new Auto(130,"Mobi"),
                new Auto(140,"Toyota SW")
            }
            );

            lsbAutos.Items.AddRange(autos.ToArray());
            */
        }


        private Sistema sistema = new Sistema();

        int _nro = -1;

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            int capacidad = Convert.ToInt32(tbCapacidad.Text);

            _nro = sistema.GenerarCamion(fecha, capacidad);

            MessageBox.Show("Camión Creado!");

            #region
            tbCapacidad.Clear();
            dateTimePicker1.Value = DateTime.Now;
            #endregion
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (_nro != -1)
            {
                Auto autoSeleccionado = lsbAutos.SelectedItem as Auto;
                if (autoSeleccionado != null)
                {
                    sistema.CargarCamion(_nro, autoSeleccionado);

                    lsbAutos.Items.Remove(autoSeleccionado);

                    MessageBox.Show("Auto Cargado!");
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un auto de la lista de Autos!");
                }
            }
            else
            {
                MessageBox.Show("Primero debes crear un camión");
            }

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (_nro != -1)
            {
                Auto auto = sistema.DescargarCamion(_nro);
                lsbAutos.Items.Add(auto);
                MessageBox.Show("Auto Descargado!");
            }
            else
            {
                MessageBox.Show("Primero debes crear un camión");
            }
        }

        private void btnCerrarCamion_Click(object sender, EventArgs e)
        {
            if (_nro != -1)
            {
                try
                {
                    sistema.CerrarCamion(_nro);
                    MessageBox.Show("Archivo .CSV del Camión creado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Primero debes crear un camión");
            }
        }

        private void btnRecibirCamion_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(txt)|*.txt";
            openFileDialog1.Title = "IMPORTAR CAMIÓN CON VEHICULOS";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                string path = openFileDialog1.FileName;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine(); //Leo encabezado: nroRegistro;modelo;precio;
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] splitResult = linea.Split(';');
                        int nroRegistro = Convert.ToInt32(splitResult[0].Trim());
                        string modelo = splitResult[1].Trim();
                        double precio = Convert.ToDouble(splitResult[2].Trim());

                        Auto auto = new Auto(nroRegistro, modelo);
                        auto.Precio = precio;

                        lsbAutosRecibidos.Items.Add(auto);
                    }
                    Camion camionRecibido = new Camion(DateTime.Now, lsbAutosRecibidos.Items.Count);
                    _nro = camionRecibido.NroRegistro;
                    sistema.RecibirCamion(camionRecibido);
                    foreach(Auto auto in lsbAutosRecibidos.Items)
                    {
                        sistema.CargarCamion(_nro, auto);
                    }
                    MessageBox.Show("Camión importado satisfactoriamente!");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnDescargarCamion_Click(object sender, EventArgs e)
        {
            if (_nro != -1)
            {
                Auto auto = sistema.DescargarCamion(_nro);
                while (auto != null)
                {

                    lsbAutos.Items.Add(auto);
                    lsbAutosRecibidos.Items.Remove(auto);

                    auto = sistema.DescargarCamion(_nro);
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                
                fs = new FileStream("datos.bin", FileMode.Create, FileAccess.Write);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sistema);
                #pragma warning restore SYSLIB0011
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Serializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            */
        }
    }
}
