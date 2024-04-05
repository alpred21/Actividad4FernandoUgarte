using GestionPedidos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPedidos.DAL
{
    public class ClientesDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "SELECT * FROM CLIENTE";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public Cliente ObtenerIdClienteDal (int id)
        {
            string consulta = "SELECT * FROM CLIENTE WHERE IDCLIENTE = " + id;
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            Cliente cliente = new Cliente();
            if (lista.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(lista.Rows[0]["idcliente"]);
                cliente.Nombre = lista.Rows[0]["nombre"].ToString();
                cliente.Apellido = lista.Rows[0]["apellido"].ToString();
                cliente.CorreoElectronico = lista.Rows[0]["CorreoElectronico"].ToString();
                cliente.Telefono = lista.Rows[0]["telefono"].ToString();
                cliente.Direccion = lista.Rows[0]["direccion"].ToString();
            }
            return cliente;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "INSERT INTO CLIENTE VALUES(" +
                              "'" + cliente.Nombre + "' ," +
                              " '" + cliente.Apellido + "' ," +
                              " '" + cliente.CorreoElectronico + "' ," +
                              " '" + cliente.Telefono + "' ," +
                              " '" + cliente.Direccion + "' )";
            Conexion.Ejecutar(consulta);
        }
        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "UPDATE CLIENTE SET NOMBRE = '" + cliente.Nombre + "' ," +
                                                     "APELLIDO = '" + cliente.Apellido + "' ," +
                                                     "CORREOELECTRONICO = '" + cliente.CorreoElectronico + "'," +
                                                     "TELEFONO = '" + cliente.Telefono + "' , " +
                                                     "DIRECCION = '" + cliente.Direccion + "' " +
                              "WHERE IDCLIENTE =" + cliente.IdCliente;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "DELETE  FROM CLIENTE WHERE IDCLIENTE = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
