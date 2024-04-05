using GestionPedidos.BSS;
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
    public partial class PedidosListarVista : Form
    {
        public PedidosListarVista()
        {
            InitializeComponent();
        }

        PedidosBss bss = new PedidosBss();
        private void PedidosListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPedidosBss();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PedidosFiltrarCalcularClienteVista ventana5 = new PedidosFiltrarCalcularClienteVista();
            ventana5.Show();
        }

        private void button3_Click(object sender, EventArgs e) //btn ingresar pedido
        {
            PedidosInsertarVista ventana1 = new PedidosInsertarVista();
            /*ventana1 .Show();*/
            if (ventana1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e) //btn editar pedido
        {
            PedidosEditarVista ventana2 = new PedidosEditarVista();
            if (ventana2.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidosBss();
            }
        }

        private void button5_Click(object sender, EventArgs e) //btn eliminar pedido
        {
            PedidosEliminarVista ventana3 = new PedidosEliminarVista();
            if (ventana3.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPedidosBss();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PedidosListarPorClienteVista ventana4 = new PedidosListarPorClienteVista();
            ventana4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
