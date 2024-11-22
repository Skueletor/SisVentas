using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Helpers
{
    public static class UsuarioHelper
    {
        public static Usuario GetAdminPredeterminado()
        {
            return new Usuario
            {
                IdUsuario = 1, //1 admin - 0 user
                NombreCompleto = "ADMIN PREDEFINIDO",
                Documento = "admin",
                Clave = "admin123",
                Estado = true,
                oRol = new Rol { IdRol = 1, Descripcion = "Administrador" }
            };
        }

        public static bool EsAdminPredeterminado(Usuario usuario)
        {
            var admin = GetAdminPredeterminado();
            return usuario.Documento == admin.Documento && usuario.Clave == admin.Clave;
        }
    }
}
