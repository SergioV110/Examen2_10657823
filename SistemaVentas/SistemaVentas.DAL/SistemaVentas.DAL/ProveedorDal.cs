using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedoresDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "'," +
                                                         "'" + proveedor.Telefono + "'," +
                                                         "'" + proveedor.Direccion + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable ProveedorTLINDal()
        {
            string consulta = " SELECT PROVEEDOR.IDPROVEEDOR, PROVEEDOR.NOMBRE, INGRESO.TOTAL TOTAL_INGRESOS " +
                "              FROM     PROVEEDOR " +
                "                       INNER JOIN    INGRESO ON PROVEEDOR.IDPROVEEDOR = INGRESO.IDPROVEEDOR " ;
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
