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
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductosDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public DataTable ProductoDatosBss()
        {
            return dal.ProductoDatosDal();
        }
        public DataTable ProductoTPIBss()
        {
            return dal.ProductoTPIDal();
        }
    }
}
