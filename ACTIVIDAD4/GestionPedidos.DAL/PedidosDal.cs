using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.DAL
{
    public class PedidosDal
    {
        public DataTable ListarPedidosDal ()
        {
            string consulta = "select *\r\nfrom PEDIDOS";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarPedidosClienteDal(int id)
        {
            string consulta = "select IdPedido, C.Nombre, FECHA, Total, Estado\r\nfrom PEDIDOS P\r\n\tINNER JOIN CLIENTE C ON C.IDCLIENTE = P.IDCLIENTE\r\nWHERE P.IdCliente = " + id;
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable CalcularTotalClienteDal(int id)
        {
            string consulta = "select C.Nombre, SUM(TOTAL) AS MONTOPEDIDOS, COUNT(IDPEDIDO) AS TOTALPEDIDOS\r\nfrom PEDIDOS P\r\n\tINNER JOIN CLIENTE C ON C.IDCLIENTE = P.IDCLIENTE\r\nWHERE P.IdCliente =" + id + "\r\nGROUP BY C.Nombre";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPedidoDal(Pedidos pedidos)
        {
            string consulta = "INSERT INTO PEDIDOS VALUES(" +
                              "'" + pedidos.IdCliente + "' ," +
                              " '" + pedidos.Fecha + "' ," +
                              " " +pedidos.Total+ " ," +
                              " '" +pedidos.Estado+ "' )";
            Conexion.Ejecutar(consulta);
        }
        public Pedidos ObtenerIdPedidoDal (int id)
        {
            string consulta = "SELECT * FROM PEDIDOS WHERE IDPEDIDO = " + id;
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            Pedidos pedidos = new Pedidos();
            if (lista.Rows.Count > 0)
            {
                pedidos.IdPedido = Convert.ToInt32(lista.Rows[0]["idpedido"]);
                pedidos.IdCliente = Convert.ToInt32(lista.Rows[0]["idcliente"]);
                pedidos.Fecha = Convert.ToDateTime(lista.Rows[0]["fecha"]);
                pedidos.Total = Convert.ToDecimal(lista.Rows[0]["total"]);
                pedidos.Estado = lista.Rows[0]["estado"].ToString();
            }
            return pedidos;
        }
        public void EditarPedidoDal (Pedidos pedidos)
        {
            string consulta = "UPDATE PEDIDOS SET FECHA = '" + pedidos.Fecha + "' ," +
                                                     "TOTAL = " + pedidos.Total + " , " +
                                                     "ESTADO = '" + pedidos.Estado + "' " +
                              "WHERE IDPEDIDO =" + pedidos.IdPedido;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarPedidoDal (int id)
        {
            string consulta = "DELETE  FROM PEDIDOS WHERE IDPEDIDO = " + id;
            Conexion.Ejecutar(consulta);
        }

    }
}
