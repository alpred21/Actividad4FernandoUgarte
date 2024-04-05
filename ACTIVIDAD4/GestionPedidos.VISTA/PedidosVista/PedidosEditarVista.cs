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
    public partial class PedidosEditarVista : Form
    {
        Pedidos pedidos = new Pedidos();
        PedidosBss bss = new PedidosBss();
        public PedidosEditarVista()
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
            pedidos.IdCliente = Convert.ToInt32(textBox2.Text);
            pedidos.Fecha = dateTimePicker1.Value;
            pedidos.Total = Convert.ToDecimal(textBox3.Text);
            pedidos.Estado = comboBox1.SelectedItem.ToString();

            bss.EditarPedidoBss(pedidos);
            MessageBox.Show("Actualizado exitosamente");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
