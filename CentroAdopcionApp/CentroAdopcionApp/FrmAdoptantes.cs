using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentroAdopcionApp.Entidad;// Importar la capa de entidad para trabajar con los datos de adoptantes
using CentroAdopcionApp.Datos; // Importar la capa de datos para interactuar con la base de datos


namespace CentroAdopcionApp
{
    public partial class frmAdoptantes : Form
    {
        // Variable para almacenar el ID del adoptante seleccionado
        private int idSeleccionado = -1;

        public frmAdoptantes()
        {
            InitializeComponent();
        }

        private void frmAdoptantes_Load(object sender, EventArgs e)
        {
            // Cargar la lista de adoptantes al iniciar el formulario
            CargarAdoptantes();

        }
        private void CargarAdoptantes()
        {
            dgvAdoptantes.DataSource = AdoptantesDAO.ObtenerAdoptantes();

        }
     


        //Programación de eventos para los botones y campos de texto
        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

         private void Limpiar()
        {
            // Limpiar los campos de texto y restablecer el ID seleccionado
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            numTelefono.Value = 0;
            txtCorreo.Clear();
            idSeleccionado = -1;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que querés eliminar este adoptante?", "Confirmar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (AdoptantesDAO.EliminarAdoptante(idSeleccionado))
                    {
                        MessageBox.Show("Adoptante eliminado correctamente");
                        Limpiar();
                        CargarAdoptantes();
                    }
                }
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTelefono_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo objeto Adoptante con los datos ingresados
            Adoptante a = new Adoptante
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = numTelefono.Value.ToString(),
                Correo = txtCorreo.Text
            };
            // Verificar si se está editando un adoptante existente o creando uno nuevo
            if (idSeleccionado == -1)
            {
                // Agregar un nuevo adoptante
                if (AdoptantesDAO.AgregarAdoptante(a))
                {
                    MessageBox.Show("Adoptante agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el adoptante.");
                }
            }
            else
            {
                // Actualizar un adoptante existente
                a.IdAdoptante = idSeleccionado;
                if (AdoptantesDAO.ActualizarAdoptante(a))
                {
                    MessageBox.Show("Adoptante actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el adoptante.");
                }
            }
            // Limpiar los campos después de guardar
            Limpiar();
            CargarAdoptantes(); // Recargar la lista de adoptantes

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cancelar la operación y limpiar los campos
            Limpiar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdoptantes.CurrentRow != null && dgvAdoptantes.CurrentRow.DataBoundItem is Adoptante adoptante)
            {
                idSeleccionado = adoptante.IdAdoptante;
                txtNombre.Text = adoptante.Nombre;
                txtApellido.Text = adoptante.Apellido;
                txtDireccion.Text = adoptante.Direccion;
                numTelefono.Value = decimal.TryParse(adoptante.Telefono, out var tel) ? tel : 0;
                txtCorreo.Text = adoptante.Correo;
            }
        }
        

    }
}
