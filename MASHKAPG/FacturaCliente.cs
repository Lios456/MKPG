using MASHKAPG.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHKAPG
{
    public partial class FacturaCliente : Form
    {
        Cliente cliente;
        public FacturaCliente(Cliente c)
        {
            cliente = c;
            InitializeComponent();
            this.lbnombres.Text = c.Name;
            this.lbapellidos.Text = c.LastName;
            this.labedad.Text = c.Age.ToString();
            this.lbpeso.Text = c.Weight.ToString();
            this.lbsexo.Text = c.Sex;
            this.lbemail.Text = c.Email;
            this.lbcelular.Text = c.Phone;
            this.lbciudad.Text = c.City;
            this.lbbarrio.Text = c.Barrio;
            this.lbcalles.Text = c.Calles;
            this.lbobservaciones.Text = c.Observaciones;
            this.lbfechas.Text = $"{c.Ingreso} / {c.Salida}";

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.ingresarcliente(cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
