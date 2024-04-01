using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values("+cliente.IdPersona+ ","+
                                                         "'" + cliente.TipoCliente + "'," +
                                                         "'" + cliente.CodigoCliente + "'," +                                                        
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable ClienteDatosDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+''+ PERSONA.APELLIDO)NOMBRE_COMPLETO, CLIENTE.TIPOCLIENTE," +
                " CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO" +
                " FROM     CLIENTE " +
                "         INNER JOIN " +
                "         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
        public DataTable ClienteNyADal() 
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE + ' ' + PERSONA.APELLIDO) NOMBRE_Y_APELLIDO " +
                "   FROM  CLIENTE " +
                "           INNER JOIN    PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA ";
            return conexion.EjecutarDataTabla(consulta, "abcd");
        }
    }
}
