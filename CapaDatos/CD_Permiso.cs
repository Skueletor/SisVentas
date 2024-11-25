using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int IdUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Construcción de la consulta
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdRol, p.NombreMenu");
                    query.AppendLine("FROM PERMISO p");
                    query.AppendLine("INNER JOIN ROL r ON r.IdRol = p.IdRol");
                    query.AppendLine("INNER JOIN USUARIO u ON u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @idUsuario");

                    // Creación del comando SQL
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    cmd.CommandType = CommandType.Text;

                    // Apertura de la conexión
                    oconexion.Open();

                    // Ejecución del comando y lectura de resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) }, // Corrección: usar "IdRol" en lugar de "IdUsuario"
                                NombreMenu = dr["NombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log opcional: puedes guardar o imprimir el error si es necesario
                    Console.WriteLine($"Error: {ex.Message}");
                    lista = new List<Permiso>(); // Devuelve una lista vacía en caso de error
                }
            }

            return lista;
        }
    }
}
