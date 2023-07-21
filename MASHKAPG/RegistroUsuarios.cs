using Interfaz2.clases;
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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //this.button1.BackColor = Color.Green;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //this.button2.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConexionMysql().insertar($"insert into usuario(Nombre,Password) values('{this.usuario.Text}','{Usuario.GetMD5(this.password.Text)}')");
            new Pantalla_principal().Show();
            this.Close();
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
