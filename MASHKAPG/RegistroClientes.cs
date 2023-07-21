using MASHKAPG.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHKAPG
{
    public partial class RegistroClientes : Form
    {

        public RegistroClientes()
        {

            InitializeComponent();
            var web1 = new System.Windows.Forms.WebBrowser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fecha = DateTime.Now;
            var c = new Cliente
            {
                Name = nombres.Text,
                LastName = apellidos.Text,
                Phone = celular.Text,
                Email = email.Text,
                Age = Convert.ToInt32(edad.Value),
                Weight = Convert.ToDecimal(peso.Value),
                City = ciudad.Text,
                Barrio = barrio.Text,
                Calles = calles.Text,
                Sex = sexo.Text,
                Ingreso = new DateTime(fecha.Year, fecha.Month, fecha.Day),
                Salida = new DateTime(fecha.Year, fecha.Month + 1, fecha.Day),
                Observaciones = observaciones.Text

            };

            try
            {
                new FacturaCliente(c).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantalla_principal f1 = new Pantalla_principal();
            f1.Show();
            this.Close();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
