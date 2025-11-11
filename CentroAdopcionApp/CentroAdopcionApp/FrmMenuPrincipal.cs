using CentroAdopcionApp;
using CentroAdopcionApp.Datos;
using CentroAdopcionApp.Entidad;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CentroAdopcionApp
{
    public partial class FrmMenuPrincipal : Form
    {
        private string nombreUsuario;
        public FrmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            guna2HtmlLabel1.Text = $"Bienvenido !!, {nombreUsuario}";
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {




        }
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            frmMascotas ventana = new frmMascotas();
            ventana.ShowDialog(); //Para llamar al formulario de mascotas
        }
        private void btnAdoptantes_Click(object sender, EventArgs e)
        {
            frmAdoptantes frmAdoptantes = new frmAdoptantes();  
            frmAdoptantes.ShowDialog(); //Para llamar al formulario de adoptantes
        }

        private void btnAdopciones_Click(object sender, EventArgs e)
        {
            frmAdopciones frmAdopciones = new frmAdopciones();  
            frmAdopciones.ShowDialog(); //Para llamar al formulario de adopciones
        }

        private void btnVoluntarios_Click(object sender, EventArgs e)
        {
            frmVoluntarios frmVoluntarios = new frmVoluntarios();   
            frmVoluntarios.ShowDialog(); //Para llamar al formulario de voluntarios
        }


        
        private void btnSalirprograma_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra todo el programa

        }

        private void btnAcercadelPrograma_Click(object sender, EventArgs e)
        {
            FrmAcercadelprograma frmAcercadelprograma = new FrmAcercadelprograma();
            frmAcercadelprograma.ShowDialog(); //Para llamar al formulario Acerca del programa
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            frmVeterinarios frmVeterinarios = new frmVeterinarios();
            frmVeterinarios.ShowDialog(); //Para llamar al formulario de veterinarios
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            FrmAcercadelprograma frmAcercadelprograma = new FrmAcercadelprograma();
            frmAcercadelprograma.ShowDialog(); //Para llamar al formulario Acerca del programa
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarMascota.Text;

            List<Mascota> lista = MascotaDAO.ObtenerMascotas();

            var filtradas = lista
                .Where(m => m.Nombre.ToLower().Contains(filtro) || m.Raza.ToLower().Contains(filtro))
                .ToList();

            dgvMascotasMenu.DataSource = filtradas;
        }

        
      
                   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            string filtro = txtBuscarMascota.Text.ToLower();

            List<Mascota> lista = MascotaDAO.ObtenerMascotas();

            var filtradas = lista
                .Where(m => m.Nombre.ToLower().Contains(filtro) || m.Raza.ToLower().Contains(filtro))
                .ToList();

            dgvMascotasMenu.DataSource = filtradas;
        }
    }
   
}