using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroAdopcionApp.Datos;  
using CentroAdopcionApp.Entidad;


namespace CentroAdopcionApp
{
    public partial class frmVeterinarios : Form
    {

        int idSeleccionado = -1;
        // Constructor de la clase frmVeterinarios
        public frmVeterinarios()
        {
            InitializeComponent();
        }

        private void frmGatos_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();

        }
        private void CargarVeterinarios()
        {
            dgvVeterinarios.DataSource = VeterinarioDAO.ObtenerVeterinarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {

        }

      
    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Veterinario v = new Veterinario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Especialidad = txtEspecialidad.Text
            };

            if (idSeleccionado == -1)
            {
                if (VeterinarioDAO.AgregarVeterinario(v))
                    MessageBox.Show("Veterinario agregado correctamente");
            }
            else
            {
                v.IdVeterinario = idSeleccionado;
                if (VeterinarioDAO.ActualizarVeterinario(v))
                    MessageBox.Show("Veterinario actualizado correctamente");
            }

            Limpiar();
            CargarVeterinarios();

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                if (VeterinarioDAO.EliminarVeterinario(idSeleccionado))
                {
                    MessageBox.Show("Veterinario eliminado");
                    Limpiar();
                    CargarVeterinarios();
                }
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtEspecialidad.Clear();
            idSeleccionado = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvVeterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVeterinarios.CurrentRow != null)
            {
                idSeleccionado = (int)dgvVeterinarios.CurrentRow.Cells["IdVeterinario"].Value;
                txtNombre.Text = dgvVeterinarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvVeterinarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvVeterinarios.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvVeterinarios.CurrentRow.Cells["Correo"].Value.ToString();
                txtEspecialidad.Text = dgvVeterinarios.CurrentRow.Cells["Especialidad"].Value.ToString();
            }
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
