using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + "," +
                                                         producto.IdMarca + "," +
                                                         "'" + producto.Nombre + "'," +
                                                         "'" + producto.CodigoBarra + "'," +
                                                         "'" + producto.Unidad + "'," +
                                                         "'" + producto.Descripion +"',"+
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable ProductoDatosDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, TIPOPROD.NOMBRE, MARCA.NOMBRE AS PRODUCTO, PRODUCTO.CODIGOBARRA, " +
                " PRODUCTO.NOMBRE AS NOMBRE_MARCA, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO " +
                " FROM     PRODUCTO INNER JOIN    " +
                " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN " +
                " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA ";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
        public DataTable ProductoTPIDal()
        {
            string consulta = "SELECT SUM(CANTIDAD) AS CantidadTotalEnInventario " +
                "              FROM DETALLEING; ";
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
