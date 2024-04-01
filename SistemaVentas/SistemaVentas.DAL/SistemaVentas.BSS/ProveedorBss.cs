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
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedoresDal();
        }
        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }
        public DataTable ProovedorTLINBss() 
        {  
            return dal.ProveedorTLINDal();
        }
    }
}
