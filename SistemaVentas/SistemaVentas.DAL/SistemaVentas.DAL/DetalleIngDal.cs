using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngsDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into detalleing values(" + detalleIng.IdIngreso + ","+
                                                         detalleIng.IdProducto + ","+
                                                         "'" + detalleIng.FechaVenc + "'," +
                                                         "'" + detalleIng.Cantidad + "'," +
                                                         "'" + detalleIng.PrecioCosto + "'," +
                                                         "'" + detalleIng.PrecioVenta + "'," +
                                                         "'" + detalleIng.SubTotal + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleIngDatosDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING, PRODUCTO.NOMBRE NOMRE_PRODUCTO, PRODUCTO.CODIGOBARRA, PRODUCTO.UNIDAD, " +
                " INGRESO.FECHAINGRESO, INGRESO.TOTAL, DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA," +
                " DETALLEING.SUBTOTAL, DETALLEING.ESTADO " +
                " FROM     DETALLEING INNER JOIN     " +
                "          PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN         " +
                "          INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
        public DataTable DetalleIngCCLDal()
        {
            string consulta = "SELECT C.IDCLIENTE  AS CLIENTE,  SUM(DV.SUBTOTAL) AS TOTAL_INGRESOS" +
                "   FROM CLIENTE C " +
                "           INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE" +
                "           INNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA " +
                "     GROUP BY C.IDCLIENTE; ";
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
