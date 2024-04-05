using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionPedidos.DAL;
using GestionPedidos.Modelos;

namespace GestionPedidos.BSS
{
    public class PedidosBss
    {
        PedidosDal dal = new PedidosDal();
        public DataTable ListarPedidosBss()
        {
            return dal.ListarPedidosDal();
        }
        public DataTable ListarPedidosClienteBss (int id)
        {
            return dal.ListarPedidosClienteDal(id);
        }
        public DataTable CalcularPedidosClienteBss (int id)
        {
            return dal.CalcularTotalClienteDal(id);
        }
        public void InsertarPedidoBss (Pedidos pedidos)
        {
            dal.InsertarPedidoDal(pedidos);
        }
        public Pedidos ObtenerIdPedidoBss (int id)
        {
            return dal.ObtenerIdPedidoDal (id);
        }
        public void EditarPedidoBss (Pedidos pedidos)
        {
            dal.EditarPedidoDal(pedidos);
        }
        public void EliminarPedidoBss (int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
