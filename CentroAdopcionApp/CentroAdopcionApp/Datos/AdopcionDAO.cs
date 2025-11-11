using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;

namespace CentroAdopcionApp.Datos
{
    public class AdopcionDAO
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CentroAdopcionDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Adopcion> ObtenerAdopciones()
        {
            List<Adopcion> lista = new List<Adopcion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Adopciones";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Adopcion a = new Adopcion
                    {
                        IdAdopcion = (int)reader["IdAdopcion"],
                        IdAdoptante = (int)reader["IdAdoptante"],
                        IdMascota = (int)reader["IdMascota"],
                        FechaAdopcion = (DateTime)reader["FechaAdopcion"],
                        Observacion = reader["Observacion"].ToString()
                    };
                    lista.Add(a);
                }
            }
            return lista;
        }

        public static bool AgregarAdopcion(Adopcion a)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Adopciones (IdAdoptante, IdMascota, FechaAdopcion, Observacion) VALUES (@Adoptante, @Mascota, @Fecha, @Obs)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Adoptante", a.IdAdoptante);
                cmd.Parameters.AddWithValue("@Mascota", a.IdMascota);
                cmd.Parameters.AddWithValue("@Fecha", a.FechaAdopcion);
                cmd.Parameters.AddWithValue("@Obs", a.Observacion);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static bool EliminarAdopcion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Adopciones WHERE IdAdopcion = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
