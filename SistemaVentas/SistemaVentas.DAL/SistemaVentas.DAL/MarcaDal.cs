using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcasDal()
        {
            string consulta = "select * from marca";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable MarcaNmasVDal() 
        {
            string consulta = "SELECT TOP 1 MARCA.NOMBRE AS MarcaMasVendida, SUM(DETALLEVENTA.CANTIDAD) AS CantidadVendida " +
                "FROM  DETALLEVENTA " +
                "       INNER JOIN PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO " +
                "       INNER JOIN MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA " +
                "  GROUP BY MARCA.NOMBRE " +
                "  ORDER BY CantidadVendida DESC; ";
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
