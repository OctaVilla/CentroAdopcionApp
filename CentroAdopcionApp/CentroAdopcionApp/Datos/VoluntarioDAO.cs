using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;

namespace CentroAdopcionApp.Datos
{
    public class VoluntarioDAO
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CentroAdopcionDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Voluntario> ObtenerVoluntarios()
        {
            List<Voluntario> lista = new List<Voluntario>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Voluntarios";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Voluntario v = new Voluntario
                    {
                        IdVoluntario = (int)reader["IdVoluntario"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Sucursal = reader["Sucursal"].ToString()
                    };
                    lista.Add(v);
                }
            }
            return lista;
        }

        public static bool AgregarVoluntario(Voluntario v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Voluntarios (Nombre, Apellido, Direccion, Telefono, Correo, Sucursal) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Correo, @Sucursal)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", v.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", v.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", v.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@Correo", v.Correo);
                cmd.Parameters.AddWithValue("@Sucursal", v.Sucursal);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarVoluntario(Voluntario v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Voluntarios SET Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Telefono=@Telefono, Correo=@Correo, Sucursal=@Sucursal WHERE IdVoluntario=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", v.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", v.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", v.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@Correo", v.Correo);
                cmd.Parameters.AddWithValue("@Sucursal", v.Sucursal);
                cmd.Parameters.AddWithValue("@Id", v.IdVoluntario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarVoluntario(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Voluntarios WHERE IdVoluntario=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
