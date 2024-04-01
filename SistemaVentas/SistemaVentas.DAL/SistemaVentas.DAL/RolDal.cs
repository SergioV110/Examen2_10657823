using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolesDal()
        {
            string consulta = "select * from rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable RolNPVVDal()
        {
            string consulta = " SELECT U.NOMBREUSER AS VENDEDOR, P.NOMBRE AS PRODUCTO, SUM(DV.CANTIDAD) AS UNIDADES_VENDIDAS " +
                "                FROM USUARIO U " +
                "                   INNER JOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR " +
                "                   INNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA " +
                "                   INNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO " +
                "                   INNER JOIN USUARIOROL UR ON U.IDUSUARIO = UR.IDUSUARIO " +
                "               WHERE UR.IDROL = 4" +
                "               GROUP BY U.NOMBREUSER, P.NOMBRE ; ";
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
