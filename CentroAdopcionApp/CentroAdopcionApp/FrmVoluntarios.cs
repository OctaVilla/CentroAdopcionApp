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
    public partial class frmVoluntarios : Form
    {
        // Variable para almacenar el ID del voluntario seleccionado
        int idSeleccionado = -1;
        // Esta variable se utiliza para identificar qué voluntario se está editando o eliminando
        // y se inicializa en -1 para indicar que no hay ningún voluntario seleccionado al inicio

        // Constructor de la clase frmVoluntarios
        // Este constructor inicializa los componentes del formulario y se ejecuta al cargar el formulario

        public frmVoluntarios()
        {
            InitializeComponent();
        }

        private void frmVoluntarios_Load(object sender, EventArgs e)
        {
            cboSucursal.Items.AddRange(new string[] { "Sucursal 1", "Sucursal 2", "Sucursal 3" });
            CargarVoluntarios();
        }
        //Metodo para cargar los voluntarios desde la base de datos y mostrarlos en el DataGridView
        private void CargarVoluntarios()
        {
            dgvVoluntarios.DataSource = VoluntarioDAO.ObtenerVoluntarios();
        }
        //Metodo para limpiar los campos del formulario
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            numTelefono.Value = 0;
            txtCorreo.Clear();
            cboSucursal.SelectedIndex = -1;
            idSeleccionado = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                if (VoluntarioDAO.EliminarVoluntario(idSeleccionado))
                {
                    MessageBox.Show("Voluntario eliminado");
                    CargarVoluntarios();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un voluntario para eliminar");
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

        private void cboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //metodo para manejar el evento de clic del botón "Guardar"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Voluntario v = new Voluntario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = numTelefono.Value.ToString(),
                Correo = txtCorreo.Text,
                Sucursal = cboSucursal.Text
            };

            if (idSeleccionado == -1)
            {
                if (VoluntarioDAO.AgregarVoluntario(v))
                    MessageBox.Show("Voluntario agregado");
            }
            else
            {
                v.IdVoluntario = idSeleccionado;
                if (VoluntarioDAO.ActualizarVoluntario(v))
                    MessageBox.Show("Voluntario actualizado");
            }

            CargarVoluntarios();
            Limpiar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Voluntarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVoluntarios.CurrentRow != null)
            {
                idSeleccionado = (int)dgvVoluntarios.CurrentRow.Cells["IdVoluntario"].Value;
                txtNombre.Text = dgvVoluntarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvVoluntarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = dgvVoluntarios.CurrentRow.Cells["Direccion"].Value.ToString();
                numTelefono.Value = Convert.ToDecimal(dgvVoluntarios.CurrentRow.Cells["Telefono"].Value);
                txtCorreo.Text = dgvVoluntarios.CurrentRow.Cells["Correo"].Value.ToString();
                cboSucursal.Text = dgvVoluntarios.CurrentRow.Cells["Sucursal"].Value.ToString();
            }

        }
    }
}
