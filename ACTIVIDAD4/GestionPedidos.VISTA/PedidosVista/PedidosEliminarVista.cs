using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPedidos.VISTA.PedidosVista
{
    public partial class PedidosEliminarVista : Form
    {
        Pedidos pedidos = new Pedidos();
        PedidosBss bss = new PedidosBss();
        public PedidosEliminarVista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedidos = bss.ObtenerIdPedidoBss(Convert.ToInt32(textBox1.Text));
            textBox2.Text = pedidos.IdCliente.ToString();
            dateTimePicker1.Value = pedidos.Fecha;
            textBox3.Text = pedidos.Total.ToString();
            comboBox1.SelectedItem = pedidos.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPedidoSeleccionado = Convert.ToInt32(Convert.ToInt32(textBox1.Text));
            DialogResult result = MessageBox.Show("Esta seguro de eliminarlo?", "Eliminando",
                                                  MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPedidoBss(IdPedidoSeleccionado);
                MessageBox.Show("Eliminado exitosamente");
            }
        }

        private void PedidosEliminarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
