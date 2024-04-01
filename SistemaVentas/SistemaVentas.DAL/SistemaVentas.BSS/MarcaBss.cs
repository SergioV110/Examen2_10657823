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
    public class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {
            return dal.ListarMarcasDal();
        }
        public void InsertarMarcaBss(Marca marca)
        {
            dal.InsertarMarcaDal(marca);
        }
        public DataTable MarcaNmasVBss()
        {
            return dal.MarcaNmasVDal();
        }
    }
}
