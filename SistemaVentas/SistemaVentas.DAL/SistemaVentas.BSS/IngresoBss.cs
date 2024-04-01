using SistemaVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.BSS
{
    public class IngresoBss
    {
        IngresoDal dal = new IngresoDal();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresosDal();
        }
        public void InsertarIngresoBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDal(ingreso);
        }
        public DataTable IngresoDatosBss()
        {
            return dal.IngresoDatosDal();
        }
    }
}
