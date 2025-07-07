using CentroAdopcionApp;
using CentroAdopcionApp.Datos;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
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


        private void btnAnimales_Click(object sender, EventArgs e)
        {

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
    }
   
}