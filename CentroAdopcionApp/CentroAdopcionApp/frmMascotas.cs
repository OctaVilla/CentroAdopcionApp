using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CentroAdopcionApp.Entidad;
using CentroAdopcionApp.Datos;



namespace CentroAdopcionApp.Datos

{
    
    public partial class frmMascotas : Form
    {
        int idSeleccionado = -1;
        public frmMascotas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtRaza.Clear();
            cboTipo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            idSeleccionado = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
                Tipo = cboTipo.Text,
                Raza = txtRaza.Text,
                Estado = cboEstado.Text
            };

            if (idSeleccionado == -1)
            {
                if (MascotaDAO.AgregarMascota(m))
                    MessageBox.Show("Mascota agregada");
            }
            else
            {
                m.IdMascota = idSeleccionado;
                if (MascotaDAO.ActualizarMascota(m))
                    MessageBox.Show("Mascota actualizada");
            }
           
            CargarMascotas();


        }

        private void frmMascotas_Load(object sender, EventArgs e)
        {
            cboTipo.Items.AddRange(new string[] { "Perro", "Gato", "Otro" });
            cboEstado.Items.AddRange(new string[] { "Disponible", "Adoptado", "En proceso de adopción" });
            
            CargarMascotas();


        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {

        }

        List<Mascota> todasLasMascotas = new List<Mascota>();

        private void CargarMascotas()
        {
            todasLasMascotas = MascotaDAO.ObtenerMascotas();
            dgvMascotas.DataSource = todasLasMascotas;
        }
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMascotas.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(row.Cells["IdMascota"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtEdad.Text = row.Cells["Edad"].Value.ToString();
                cboTipo.SelectedItem = row.Cells["Tipo"].Value.ToString();
                txtRaza.Text = row.Cells["Raza"].Value.ToString();
                cboEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
