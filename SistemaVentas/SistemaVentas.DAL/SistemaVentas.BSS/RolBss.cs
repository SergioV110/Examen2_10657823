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
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolesDal();
        }
        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }
        public DataTable RolNPVVBss()
        {
            return dal.RolNPVVDal();
        }

    }
}
