using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveesDal()
        {
            string consulta = "select * from provee";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + "," +
                                                           provee.IdProveedor + "," +
                                                         "'" + provee.Fecha + "'," +
                                                         "'" + provee.Precio + "')";
                                                         
            conexion.Ejecutar(consulta);
        }
        public DataTable ProveeDatosDal()
        {
            string consulta = "SELECT PROVEE.IDPROVEE, PRODUCTO.NOMBRE NOMBRE_PRODUCTO, PRODUCTO.UNIDAD, PROVEEDOR.NOMBRE AS NOMBRE_PROVEE, " +
                " PROVEEDOR.TELEFONO, PROVEE.FECHA, PROVEE.PRECIO " +
                " FROM     PROVEE INNER JOIN " +
                "          PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN    " +
                "          PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
