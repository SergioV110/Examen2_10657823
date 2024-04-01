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
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentasDal();
        }
        public void InsertarVentaBss(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public DataTable VentaDatosBss()
        {
            return dal.VentaDatosDal();
        }
    }
}
