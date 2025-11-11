namespace CentroAdopcionApp
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBuscarMascota = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMascotasMenu = new System.Windows.Forms.DataGridView();
            this.txtBuscarMascota = new System.Windows.Forms.TextBox();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalirprograma = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMascotas = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoluntarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdopciones = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdoptantes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAcercadelPrograma = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotasMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnBuscarMascota);
            this.guna2Panel2.Controls.Add(this.dgvMascotasMenu);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.txtBuscarMascota);
            this.guna2Panel2.Controls.Add(this.guna2Button8);
            this.guna2Panel2.Controls.Add(this.btnSalirprograma);
            this.guna2Panel2.Controls.Add(this.guna2Button7);
            this.guna2Panel2.Controls.Add(this.btnMascotas);
            this.guna2Panel2.Controls.Add(this.btnVoluntarios);
            this.guna2Panel2.Controls.Add(this.btnAdopciones);
            this.guna2Panel2.Controls.Add(this.btnAdoptantes);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1410, 716);
            this.guna2Panel2.TabIndex = 0;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnBuscarMascota
            // 
            this.btnBuscarMascota.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnBuscarMascota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMascota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMascota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMascota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMascota.FillColor = System.Drawing.Color.Gray;
            this.btnBuscarMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarMascota.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMascota.Location = new System.Drawing.Point(687, 107);
            this.btnBuscarMascota.Name = "btnBuscarMascota";
            this.btnBuscarMascota.Size = new System.Drawing.Size(134, 31);
            this.btnBuscarMascota.TabIndex = 9;
            this.btnBuscarMascota.Text = "Buscar Mascota";
            this.btnBuscarMascota.Click += new System.EventHandler(this.guna2Button9_Click_1);
            // 
            // dgvMascotasMenu
            // 
            this.dgvMascotasMenu.AllowUserToOrderColumns = true;
            this.dgvMascotasMenu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMascotasMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMascotasMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotasMenu.Location = new System.Drawing.Point(293, 178);
            this.dgvMascotasMenu.Name = "dgvMascotasMenu";
            this.dgvMascotasMenu.RowHeadersWidth = 51;
            this.dgvMascotasMenu.RowTemplate.Height = 24;
            this.dgvMascotasMenu.Size = new System.Drawing.Size(771, 249);
            this.dgvMascotasMenu.TabIndex = 8;
            this.dgvMascotasMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBuscarMascota
            // 
            this.txtBuscarMascota.Location = new System.Drawing.Point(293, 116);
            this.txtBuscarMascota.Name = "txtBuscarMascota";
            this.txtBuscarMascota.Size = new System.Drawing.Size(352, 22);
            this.txtBuscarMascota.TabIndex = 7;
            this.txtBuscarMascota.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // guna2Button8
            // 
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Gray;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(24, 522);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(180, 45);
            this.guna2Button8.TabIndex = 6;
            this.guna2Button8.Text = "Veterinarios";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // btnSalirprograma
            // 
            this.btnSalirprograma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirprograma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalirprograma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalirprograma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalirprograma.FillColor = System.Drawing.Color.Gray;
            this.btnSalirprograma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalirprograma.ForeColor = System.Drawing.Color.White;
            this.btnSalirprograma.Location = new System.Drawing.Point(1065, 624);
            this.btnSalirprograma.Name = "btnSalirprograma";
            this.btnSalirprograma.Size = new System.Drawing.Size(94, 45);
            this.btnSalirprograma.TabIndex = 3;
            this.btnSalirprograma.Text = "Salir";
            this.btnSalirprograma.Click += new System.EventHandler(this.btnSalirprograma_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Gray;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Location = new System.Drawing.Point(24, 624);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(180, 45);
            this.guna2Button7.TabIndex = 5;
            this.guna2Button7.Text = "Acerca del programa";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMascotas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMascotas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMascotas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMascotas.FillColor = System.Drawing.Color.Gray;
            this.btnMascotas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMascotas.ForeColor = System.Drawing.Color.White;
            this.btnMascotas.Location = new System.Drawing.Point(24, 111);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(180, 45);
            this.btnMascotas.TabIndex = 3;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnVoluntarios
            // 
            this.btnVoluntarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoluntarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoluntarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoluntarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoluntarios.FillColor = System.Drawing.Color.Gray;
            this.btnVoluntarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoluntarios.ForeColor = System.Drawing.Color.White;
            this.btnVoluntarios.Location = new System.Drawing.Point(24, 315);
            this.btnVoluntarios.Name = "btnVoluntarios";
            this.btnVoluntarios.Size = new System.Drawing.Size(180, 45);
            this.btnVoluntarios.TabIndex = 3;
            this.btnVoluntarios.Text = "Voluntarios";
            this.btnVoluntarios.Click += new System.EventHandler(this.btnVoluntarios_Click);
            // 
            // btnAdopciones
            // 
            this.btnAdopciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdopciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdopciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdopciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdopciones.FillColor = System.Drawing.Color.Gray;
            this.btnAdopciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdopciones.ForeColor = System.Drawing.Color.White;
            this.btnAdopciones.Location = new System.Drawing.Point(24, 417);
            this.btnAdopciones.Name = "btnAdopciones";
            this.btnAdopciones.Size = new System.Drawing.Size(180, 45);
            this.btnAdopciones.TabIndex = 3;
            this.btnAdopciones.Text = "Adopciones";
            this.btnAdopciones.Click += new System.EventHandler(this.btnAdopciones_Click);
            // 
            // btnAdoptantes
            // 
            this.btnAdoptantes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdoptantes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdoptantes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdoptantes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdoptantes.FillColor = System.Drawing.Color.Gray;
            this.btnAdoptantes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdoptantes.ForeColor = System.Drawing.Color.White;
            this.btnAdoptantes.Location = new System.Drawing.Point(24, 215);
            this.btnAdoptantes.Name = "btnAdoptantes";
            this.btnAdoptantes.Size = new System.Drawing.Size(180, 45);
            this.btnAdoptantes.TabIndex = 4;
            this.btnAdoptantes.Text = "Adoptantes";
            this.btnAdoptantes.Click += new System.EventHandler(this.btnAdoptantes_Click);
            // 
            // btnAcercadelPrograma
            // 
            this.btnAcercadelPrograma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAcercadelPrograma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAcercadelPrograma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAcercadelPrograma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAcercadelPrograma.FillColor = System.Drawing.Color.Gray;
            this.btnAcercadelPrograma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcercadelPrograma.ForeColor = System.Drawing.Color.White;
            this.btnAcercadelPrograma.Location = new System.Drawing.Point(324, 806);
            this.btnAcercadelPrograma.Name = "btnAcercadelPrograma";
            this.btnAcercadelPrograma.Size = new System.Drawing.Size(180, 45);
            this.btnAcercadelPrograma.TabIndex = 3;
            this.btnAcercadelPrograma.Text = "Acerca del Programa";
            this.btnAcercadelPrograma.Click += new System.EventHandler(this.btnAcercadelPrograma_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(277, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(177, 31);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "CentroAdopcion";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(924, 40);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 22);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Usuario";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1188, 716);
            this.Controls.Add(this.btnAcercadelPrograma);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotasMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdopciones;
        private Guna.UI2.WinForms.Guna2Button btnAdoptantes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnVoluntarios;
        private Guna.UI2.WinForms.Guna2Button btnSalirprograma;
        private Guna.UI2.WinForms.Guna2Button btnAcercadelPrograma;
        private Guna.UI2.WinForms.Guna2Button btnMascotas;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private System.Windows.Forms.DataGridView dgvMascotasMenu;
        private Guna.UI2.WinForms.Guna2Button btnBuscarMascota;
        public System.Windows.Forms.TextBox txtBuscarMascota;
    }
}