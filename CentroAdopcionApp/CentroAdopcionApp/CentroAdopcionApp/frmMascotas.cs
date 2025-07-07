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
        private void CargarMascotas()
        {
            Lista.DataSource = MascotaDAO.ObtenerMascotas();
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
    }
}
