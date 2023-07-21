using Interfaz2.clases;
using MASHKAPG.clases;
using System.Runtime.InteropServices;

namespace MASHKAPG
{
    public partial class Pantalla_principal : Form
    {
        private int intentos = 3;

        public Pantalla_principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datos = new ConexionMysql().GetList($"select * from usuario where Nombre = '{usuariobox.Text}'");

            var nombre = datos[0];
            var pass = datos[1];
            if (usuariobox.Text == nombre && Usuario.GetMD5(contrabox.Text) == pass)
            {
                MessageBox.Show("Bienvenido");
                new Principal().Show();
                this.Hide();
            }
            else
            {
                if (intentos <= 0)
                {
                    MessageBox.Show("No te quedan intentos, vuelve a inicial la aplicación.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas.\nTienes {intentos} intentos.");
                    intentos -= 1;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistroUsuarios().Show();
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contrabox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                button1_Click(sender, e);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Config().Show();
        }
    }
}