using GestionPedidos.BSS;
using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPedidos.VISTA.PedidosVista
{
    public partial class PedidosInsertarVista : Form
    {
        public PedidosInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bss = new ClienteBss();
        PedidosBss bssPedidos = new PedidosBss();
        private void PedidosInsertarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClientesBss();
        }


        private void button1_Click_1(object sender, EventArgs e) //escoger cliente
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttoning_Click(object sender, EventArgs e)
        {
            PedidosInsertarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente cliente = bss.ObtenerIdClienteBss(IdClienteSeleccionado);
            textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.IdCliente = IdClienteSeleccionado;
            pedidos.Fecha = dateTimePicker1.Value;
            pedidos.Total = Convert.ToDecimal(textBox2.Text);
            pedidos.Estado = comboBox1.SelectedItem.ToString();

            bssPedidos.InsertarPedidoBss(pedidos);
            MessageBox.Show("Agregado exitosamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
