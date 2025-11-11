using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;

namespace CentroAdopcionApp.Datos
{
    public class VeterinarioDAO
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CentroAdopcionDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Veterinario> ObtenerVeterinarios()
        {
            List<Veterinario> lista = new List<Veterinario>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Veterinarios";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veterinario v = new Veterinario
                    {
                        IdVeterinario = (int)reader["IdVeterinario"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Especialidad = reader["Especialidad"].ToString()
                    };
                    lista.Add(v);
                }
            }
            return lista;
        }

        public static bool AgregarVeterinario(Veterinario v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Veterinarios (Nombre, Apellido, Telefono, Correo, Especialidad) VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Especialidad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", v.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", v.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@Correo", v.Correo);
                cmd.Parameters.AddWithValue("@Especialidad", v.Especialidad);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarVeterinario(Veterinario v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Veterinarios SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo = @Correo, Especialidad = @Especialidad WHERE IdVeterinario = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", v.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", v.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", v.Telefono);
                cmd.Parameters.AddWithValue("@Correo", v.Correo);
                cmd.Parameters.AddWithValue("@Especialidad", v.Especialidad);
                cmd.Parameters.AddWithValue("@Id", v.IdVeterinario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarVeterinario(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Veterinarios WHERE IdVeterinario = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
