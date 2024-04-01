using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentasDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                         venta.IdVendedor + "," +
                                                         "'" +venta.Fecha + "'," +
                                                         "'" + venta.Total + "'," +
                                                         "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        public DataTable VentaDatosDal()
        {
            string consulta = "SELECT VENTA.IDVENTA, CLIENTE.TIPOCLIENTE, USUARIO.NOMBREUSER, VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO" +
                " FROM     VENTA INNER JOIN                  " +
                " CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE INNER JOIN     " +
                "            USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
