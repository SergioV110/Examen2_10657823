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
    public class ProveeBss
    {
        ProveeDal dal = new ProveeDal();
        public DataTable ListarProveeBss()
        {
            return dal.ListarProveesDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            dal.InsertarProveeDal(provee);
        }
        public DataTable ProveeDatosBss()
        {
            return dal.ProveeDatosDal();
        }
    }
}
