using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MASHKAPG
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            cargarform(new ListaClientes());

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void cargarform(object f)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);

            }
            Form fm = f as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(fm);
            this.mainpanel.Tag = fm;
            fm.Show();
        }

        private void REGISTRARCLIENTES_Click(object sender, EventArgs e)
        {
            cargarform(new RegistroClientes());
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VERCLIENTES_Click(object sender, EventArgs e)
        {
            cargarform(new ListaClientes());
        }

        private void Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void VERCLIENTES_MouseHover(object sender, EventArgs e)
        {
            this.VERCLIENTES.BackColor = Color.Gray;
        }

        private void REGISTRARCLIENTES_MouseHover(object sender, EventArgs e)
        {
            this.REGISTRARCLIENTES.BackColor = Color.Gray;
        }

        private void VERHORARIOS_MouseHover(object sender, EventArgs e)
        {
            this.VERHORARIOS.BackColor = Color.Gray;
        }

        private void VERCLIENTES_MouseLeave(object sender, EventArgs e)
        {
            this.VERCLIENTES.BackColor = Color.Black;
        }

        private void REGISTRARCLIENTES_MouseLeave(object sender, EventArgs e)
        {
            this.REGISTRARCLIENTES.BackColor = Color.Black;
        }

        private void VERHORARIOS_MouseLeave(object sender, EventArgs e)
        {
            this.VERHORARIOS.BackColor = Color.Black;
        }
    }
}
