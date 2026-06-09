using Microsoft.Data.SqlClient;
using POSCafeteria.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSCafeteria.DAL
{
    public class UsuarioDAL
    {
        public Usuario? ValidarLogin(string nombreUsuario, string clave)
        {
            Usuario? usuarioAutenticado = null;
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT IdUsuario, NombreUsuario, NombreCompleto, Clave FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioAutenticado = new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreUsuario = reader["NombreUsuario"].ToString()!,
                                NombreCompleto = reader["NombreCompleto"].ToString()!,
                                Clave = reader["Clave"].ToString()!
                            };
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
            return usuarioAutenticado;
        }

        // Método para Leer (SELECT)
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"SELECT IdUsuario, NombreUsuario, NombreCompleto, Clave FROM Usuario";

                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                NombreUsuario = reader["NombreUsuario"].ToString()!,
                                NombreCompleto = reader["NombreCompleto"].ToString()!,
                                Clave = reader["Clave"].ToString()!
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los usuarios: " + ex.Message);
                }
            }
            return lista;
        }

        // Método para Crear (INSERT)
        public bool Insertar(Usuario obj)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuario (NombreUsuario, NombreCompleto, Clave) VALUES (@NombreUsuario, @NombreCompleto, @Clave)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@Clave", obj.Clave);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch(Exception ex)
                {
                    throw new Exception("Error al insertar el usuario: " + ex.Message);
                }
            }
        }

        // Método para Actualizar (UPDATE)
        public bool Actualizar(Usuario obj)
        {
            using (SqlConnection conexion= ConexionDB.ObtenerConexion())
            {
                string query = @"UPDATE Usuario SET NombreUsuario = @NombreUsuario, NombreCompleto = @NombreCompleto, Clave = @Clave WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                cmd.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                cmd.Parameters.AddWithValue("@Clave", obj.Clave);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el usuario: " + ex.Message);
                }
            }
        }

        // Método para Eliminar (Borrado lógico - UPDATE Activo = 0)
        public bool Eliminar(int idUsuario)
        {
            using (SqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }
    }
}
