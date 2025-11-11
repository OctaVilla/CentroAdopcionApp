using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroAdopcionApp
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text.Trim();
            string hash = HashPassword(contraseña);
            /*
            MessageBox.Show("Hash generado: " + hash);*/
        }
        
       
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();
            string hash = HashPassword(contraseña);

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CentroAdopcionDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE Username = @usuario";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@usuario", usuario);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("El usuario ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Usuarios (Username, PasswordHash, Rol) VALUES (@usuario, @hash, @rol)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@usuario", usuario);
                    insertCmd.Parameters.AddWithValue("@hash", hash);
                    insertCmd.Parameters.AddWithValue("@rol", rol);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cierra el formulario de registro
                }
            }
        }
        
        //Para Cargar los roles en el ComboBox al cargar el formulario
        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Usuario");
            cmbRol.Items.Add("Voluntario");
            cmbRol.SelectedIndex = 1; // Por defecto: Usuario
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close(); // Cierra el formulario de registro

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
