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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnPerros_Click(object sender, EventArgs e)
        {
            frmPerros perros = new frmPerros();
            perros.Show();
            this.Hide();
        }

        private void btnGatos_Click(object sender, EventArgs e)
        {
            frmGatos gatos = new frmGatos();
            gatos.Show();
            this.Hide();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            frmOtros otros = new frmOtros();
            otros.Show();
            this.Hide();
        }
        private void btnAdopciones_Click(object sender, EventArgs e)
        {
            frmAdopciones adopciones = new frmAdopciones();
            adopciones.Show();
            this.Hide();
        }

        private void btnAdoptantes_Click(object sender, EventArgs e)
        {
            frmAdoptantes adoptantes = new frmAdoptantes();
            adoptantes.Show();
            this.Hide();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradores colaboradores = new frmColaboradores();
            colaboradores.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
