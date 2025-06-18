using System.Data.SqlClient;

namespace CentroAdopcionApp.Datos
{
    public class AccesoDatos
    {
        private static string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CentroAdopcionDB;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
