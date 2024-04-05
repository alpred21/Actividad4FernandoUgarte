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
    public partial class PedidosListarPorClienteVista : Form
    {
        public PedidosListarPorClienteVista()
        {
            InitializeComponent();
        }
        PedidosBss bss = new PedidosBss();
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = bss.ListarPedidosClienteBss(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
