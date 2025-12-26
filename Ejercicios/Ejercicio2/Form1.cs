using Ejercicio2.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Agencia agencia = new Agencia();

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                agencia = bf.Deserialize(fs) as Agencia;
                #pragma warning restore SYSLIB0011
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error al Deserializar",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            */
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.OpenOrCreate, FileAccess.Write);
                #pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, agencia);
                #pragma warning restore SYSLIB0011
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error al Serializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            */
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

            Ticket ticket = null;

            if (rbDenuncia.Checked)
            {
                string patente = tbPatente.Text;
                Vehiculo vehiculo = new Vehiculo(patente);

                ticket = new Denuncia(vehiculo);

                tbPatente.Clear();
            }
            else
            if (rbNuevoCliente.Checked)
            {
                try
                {
                    long dni = Convert.ToInt64(tbDNI.Text);
                    ticket = new NuevoCliente(dni);
                    
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message,"Error de DNI",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tbDNI.Clear();

            }


            if (ticket == null)
            {
                MessageBox.Show("Debes seleccionar una opción");
            }
            else
            if (ticket != null)
            {
                agencia.AgregarTicket(ticket);
                lsbTurnos.Items.Add(ticket);
            }

        }

        private void btnAtenderDenuncia_Click(object sender, EventArgs e)
        {
            Ticket turno = agencia.AtenderTicket(1);

            if (turno == null)
            {
                MessageBox.Show("No hay turno del tipo Denuncia para atender");
            }
            lsbTurnos.Items.Remove(turno);
        }

        private void btnAtenderNuevoCliente_Click(object sender, EventArgs e)
        {
            Ticket turno = agencia.AtenderTicket(2);

            if (turno == null)
            {
                MessageBox.Show("No hay turno del tipo Nuevo Cliente para atender");
            }
            lsbTurnos.Items.Remove(turno);
        }
    }
}
