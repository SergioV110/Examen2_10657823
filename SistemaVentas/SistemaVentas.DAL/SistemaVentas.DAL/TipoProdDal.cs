using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdsDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoProd)
        {
            string consulta = "insert into tipoprod values('" + tipoProd.Nombre + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
