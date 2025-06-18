using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroAdopcionApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            // Validacion para iniciar sesion 
            if (usuario == "Elías" && contraseña == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Oculta el formulario de login
                FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal(usuario); // Crea una instancia del formulario principal
                menuPrincipal.Show(); // Muestra el formulario principal
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

    }
}

