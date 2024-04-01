using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentasDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleVenta)
        {
            string consulta = "insert into detalleventa values(" + detalleVenta.IdVenta + "," +
                                                         detalleVenta.IdProducto + "," +
                                                         "'" + detalleVenta.Cantidad + "'," +
                                                         "'" + detalleVenta.PrecioVenta + "'," +
                                                         "'" + detalleVenta.SubTotal + "',"+
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleVentaDatosDal()
        {
            string consulta = "SELECT DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE NOMBRE_PRODUCTO, PRODUCTO.CODIGOBARRA," +
                " DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO " +
                " FROM     DETALLEVENTA INNER JOIN     " +
                "          VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN    " +
                "          PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO ";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
