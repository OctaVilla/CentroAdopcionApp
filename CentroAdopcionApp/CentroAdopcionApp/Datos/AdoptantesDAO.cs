using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;

namespace CentroAdopcionApp.Datos
{
    public class AdoptantesDAO
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CentroAdopcion;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Adoptante> ObtenerAdoptantes()
        {
            List<Adoptante> lista = new List<Adoptante>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Adoptantes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Adoptante a = new Adoptante
                    {
                        IdAdoptante = (int)reader["IdAdoptante"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Correo = reader["Correo"].ToString()
                    };
                    lista.Add(a);
                }
            }

            return lista;
        }

        public static bool AgregarAdoptante(Adoptante a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Adoptantes (Nombre, Apellido, Direccion, Telefono, Correo) VALUES (@Nombre, @Apellido, @Direccion, @Telefono, @Correo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", a.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", a.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", a.Telefono);
                cmd.Parameters.AddWithValue("@Correo", a.Correo);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarAdoptante(Adoptante a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Adoptantes SET Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Telefono=@Telefono, Correo=@Correo WHERE IdAdoptante=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", a.Apellido);
                cmd.Parameters.AddWithValue("@Direccion", a.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", a.Telefono);
                cmd.Parameters.AddWithValue("@Correo", a.Correo);
                cmd.Parameters.AddWithValue("@Id", a.IdAdoptante);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarAdoptante(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Adoptantes WHERE IdAdoptante=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
