using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using CentroAdopcionApp;

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
    }
   
}