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
    public partial class frmAdopciones : Form
    {
        // Formulario para gestionar adopciones de mascotas en el centro de adopción
        int idSeleccionado = -1;
        List<Mascota> mascotasDisponibles;
        List<Adoptante> adoptantes;
        public frmAdopciones()
        {
            InitializeComponent();
        }

        private void frmAdopciones_Load(object sender, EventArgs e)
        {
            CargarMascotas();
            CargarAdoptantes();
            CargarAdopciones();

        }
        //Creamos los metodos para cargar los datos necesarios en el formulario
        private void CargarMascotas()
        {
            mascotasDisponibles = MascotaDAO.ObtenerMascotasDisponibles();
            cboAnimal.DataSource = mascotasDisponibles;
            cboAnimal.DisplayMember = "Nombre";
            cboAnimal.ValueMember = "IdMascota";
        }
        // Cargamos los adoptantes desde la base de datos
        private void CargarAdoptantes()
        {
            adoptantes = AdoptantesDAO.ObtenerAdoptantes();
            cboAdoptante.DataSource = adoptantes;
            cboAdoptante.DisplayMember = "NombreCompleto";
            cboAdoptante.ValueMember = "IdAdoptante";
        }
        // Cargamos las adopciones desde la base de datos y las mostramos en el DataGridView
        private void CargarAdopciones()
        {
            dgvAdopciones.DataSource = AdopcionDAO.ObtenerAdopciones();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != -1)
            {
                if (AdopcionDAO.EliminarAdopcion(idSeleccionado))
                {
                    MessageBox.Show("Adopción eliminada");
                    CargarAdopciones();
                    Limpiar();
                }
            }

        }

      

        private void cboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAnimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboAnimal.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una mascota disponible");
                return;
            }

            int idMascota = (int)cboAnimal.SelectedValue;
            int idAdoptante = 1; // Temporal, ajustá según tu selector real

            Adopcion a = new Adopcion
            {
                IdAdoptante = idAdoptante,
                IdMascota = idMascota,
                FechaAdopcion = dtpFecha.Value,
                Observacion = txtObservacion.Text
            };

            if (AdopcionDAO.AgregarAdopcion(a))
            {
                MascotaDAO.MarcarComoAdoptado(idMascota);
                MessageBox.Show("Adopción registrada con éxito");
                CargarMascotas();
                CargarAdopciones();
                Limpiar();
            }

        }
        private void Limpiar()
        {
            txtObservacion.Clear();
            cboAnimal.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            idSeleccionado = -1;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Adopciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAdopciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdopciones.CurrentRow != null)
            {
                idSeleccionado = (int)dgvAdopciones.CurrentRow.Cells["IdAdopcion"].Value;
                dtpFecha.Value = (DateTime)dgvAdopciones.CurrentRow.Cells["FechaAdopcion"].Value;
                txtObservacion.Text = dgvAdopciones.CurrentRow.Cells["Observacion"].Value.ToString();
            }
        }

        private void cboAdoptante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
