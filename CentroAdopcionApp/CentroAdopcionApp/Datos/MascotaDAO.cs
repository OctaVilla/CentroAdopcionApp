
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;

namespace CentroAdopcionApp.Datos
{
    public class MascotaDAO
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=CentroAdopcionDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Mascota> ObtenerMascotas()
        {
            List<Mascota> lista = new List<Mascota>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Mascotas";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Mascota m = new Mascota
                        {
                            IdMascota = (int)reader["IdMascota"],
                            Nombre = reader["Nombre"].ToString(),
                            Edad = (int)reader["Edad"],
                            Tipo = reader["Tipo"].ToString(),
                            Raza = reader["Raza"].ToString(),
                            Estado = reader["Estado"].ToString()
                        };
                        lista.Add(m);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener mascotas: " + ex.Message);
            }
            return lista;
        }

        public static bool AgregarMascota(Mascota m)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Mascotas (Nombre, Edad, Tipo, Raza, Estado) VALUES (@Nombre, @Edad, @Tipo, @Raza, @Estado)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", m.Edad);
                    cmd.Parameters.AddWithValue("@Tipo", m.Tipo);
                    cmd.Parameters.AddWithValue("@Raza", m.Raza);
                    cmd.Parameters.AddWithValue("@Estado", m.Estado);
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar mascota: " + ex.Message);
            }
            return resultado;
        }

        public static bool ActualizarMascota(Mascota m)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Mascotas SET Nombre=@Nombre, Edad=@Edad, Tipo=@Tipo, Raza=@Raza, Estado=@Estado WHERE IdMascota=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", m.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", m.Edad);
                    cmd.Parameters.AddWithValue("@Tipo", m.Tipo);
                    cmd.Parameters.AddWithValue("@Raza", m.Raza);
                    cmd.Parameters.AddWithValue("@Estado", m.Estado);
                    cmd.Parameters.AddWithValue("@Id", m.IdMascota);
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar mascota: " + ex.Message);
            }
            return resultado;
        }

        public static bool EliminarMascota(int id)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Mascotas WHERE IdMascota=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar mascota: " + ex.Message);
            }
            return resultado;
        }
    }
}
