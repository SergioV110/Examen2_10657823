using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolesDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + "," +
                                                        ""+ usuarioRol.IdRol + "," +
                                                         "'" + usuarioRol.FechaAsigna + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public DataTable UsurioRolDatosDal()
        {
            string consulta = "SELECT USUARIOROL.IDUSUARIOROL, USUARIO.NOMBREUSER, ROL.NOMBRE, USUARIOROL.FECHAASIGNA, ROL.ESTADO " +
                "    FROM     USUARIOROL INNER JOIN " +
                "    USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN " +
                "    ROL ON USUARIOROL.IDROL = ROL.IDROL ";
            return conexion.EjecutarDataTabla(consulta, "fcdf");

        }
    }
}
