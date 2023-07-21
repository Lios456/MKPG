using Interfaz2.clases;
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
    public partial class ListaClientes : Form
    {
        Cliente c = new Cliente();
        public ListaClientes()
        {
            InitializeComponent();
            this.comboBox1.SelectedItem = comboBox1.Items[1];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = this.tableLayoutPanel3.GetControlFromPosition(2, 0).Name;
            if (nombre == "textBox1")
            {
                var texto = tableLayoutPanel3.GetControlFromPosition(2, 0) as TextBox;
                dataGridView1.DataSource = new ConexionMysql().Select($"select * from cliente where {this.comboBox1.Text} like '%{texto.Text}%' order by {this.comboBox1.Text}");
            }
            else if (nombre == "fecha")
            {
                var fecha = tableLayoutPanel3.GetControlFromPosition(2, 0) as DateTimePicker;
                dataGridView1.DataSource = new ConexionMysql().Select($"select * from cliente where {this.comboBox1.Text} = '{fecha.Value.Year}-{fecha.Value.Month}-{fecha.Value.Day}' order by {this.comboBox1.Text}");
            }
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ConexionMysql().Select($"select * from cliente order by Apellido");
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            if (this.comboBox1.SelectedItem.ToString() == "Ingreso")
            {

                this.tableLayoutPanel3.Controls.Remove(tableLayoutPanel3.GetControlFromPosition(2, 0));
                var fecha = new DateTimePicker();
                this.tableLayoutPanel3.Controls.Add(fecha, 2, 0);
                fecha.Dock = DockStyle.Fill;
                fecha.Name = "fecha";

            }
            else if (this.comboBox1.SelectedItem.ToString() == "Nombre" || this.comboBox1.SelectedItem.ToString() == "Apellido")
            {
                try
                {
                    this.tableLayoutPanel3.Controls.Remove(tableLayoutPanel3.GetControlFromPosition(2, 0));
                    var textBox1 = new TextBox();
                    this.tableLayoutPanel3.Controls.Add(textBox1, 2, 0);
                    textBox1.Dock = DockStyle.Fill;
                    textBox1.BorderStyle = BorderStyle.FixedSingle;
                    textBox1.BackColor = Color.Black;
                    textBox1.ForeColor = Color.White;
                    textBox1.Name = "textBox1";
                }
                catch (Exception)
                {

                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (this.comboBox1.SelectedItem.ToString() == "Ingreso")
            {
                this.tableLayoutPanel3.Controls.Remove(this.textBox1);
                var fecha = new DateTimePicker();
                this.tableLayoutPanel3.Controls.Add(fecha, 0, 2);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var select = dataGridView1.CurrentRow.Index;
            if (select >= 0)
            {
                try
                {
                    c.Id = Convert.ToInt32(dataGridView1.Rows[select].Cells[0].Value);
                    c.Name = dataGridView1.Rows[select].Cells[1].Value.ToString();
                    c.LastName = dataGridView1.Rows[select].Cells[2].Value.ToString();
                    c.Phone = dataGridView1.Rows[select].Cells[3].Value.ToString();
                    c.Email = dataGridView1.Rows[select].Cells[4].Value.ToString();
                    c.Age = Convert.ToInt32(dataGridView1.Rows[select].Cells[5].Value);
                    c.Weight = Convert.ToDecimal(dataGridView1.Rows[select].Cells[6].Value);
                    c.City = dataGridView1.Rows[select].Cells[7].Value.ToString();
                    c.Barrio = dataGridView1.Rows[select].Cells[8].Value.ToString();
                    c.Calles = dataGridView1.Rows[select].Cells[9].Value.ToString();
                    c.Sex = dataGridView1.Rows[select].Cells[10].Value.ToString();
                    c.Ingreso = Convert.ToDateTime(dataGridView1.Rows[select].Cells[11].Value.ToString());
                    c.Salida = Convert.ToDateTime(dataGridView1.Rows[select].Cells[12].Value.ToString());
                    c.Observaciones = dataGridView1.Rows[select].Cells[13].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void filaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.eliminarcli(c);
            ListaClientes_Load(sender, e);
        }

        private void nombreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ConexionMysql().Delete($"update cliente set Nombre = '' where id = {c.Id}");
            ListaClientes_Load(sender, e);
        }

        private void apellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConexionMysql().Delete($"update cliente set Apellido = '' where id = {c.Id}");
            ListaClientes_Load(sender, e);
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConexionMysql().Delete($"update cliente set Ingreso = null where id = {c.Id}");
            ListaClientes_Load(sender, e);
        }
    }
}
