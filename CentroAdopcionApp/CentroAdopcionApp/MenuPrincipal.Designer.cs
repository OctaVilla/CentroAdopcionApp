namespace CentroAdopcionApp
{
    partial class frmMenuPrincipal
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
            this.btnPerros = new System.Windows.Forms.Button();
            this.btnGatos = new System.Windows.Forms.Button();
            this.btnAdoptantes = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnAdopciones = new System.Windows.Forms.Button();
            this.btnColaboradores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerros
            // 
            this.btnPerros.Location = new System.Drawing.Point(18, 47);
            this.btnPerros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerros.Name = "btnPerros";
            this.btnPerros.Size = new System.Drawing.Size(171, 36);
            this.btnPerros.TabIndex = 0;
            this.btnPerros.Text = "Perros";
            this.btnPerros.UseVisualStyleBackColor = true;
            this.btnPerros.Click += new System.EventHandler(this.btnPerros_Click);
            // 
            // btnGatos
            // 
            this.btnGatos.Location = new System.Drawing.Point(18, 124);
            this.btnGatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGatos.Name = "btnGatos";
            this.btnGatos.Size = new System.Drawing.Size(171, 36);
            this.btnGatos.TabIndex = 1;
            this.btnGatos.Text = "Gatos";
            this.btnGatos.UseVisualStyleBackColor = true;
            // 
            // btnAdoptantes
            // 
            this.btnAdoptantes.Location = new System.Drawing.Point(18, 326);
            this.btnAdoptantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdoptantes.Name = "btnAdoptantes";
            this.btnAdoptantes.Size = new System.Drawing.Size(171, 36);
            this.btnAdoptantes.TabIndex = 2;
            this.btnAdoptantes.Text = "Adoptantes";
            this.btnAdoptantes.UseVisualStyleBackColor = true;
            // 
            // btnOtros
            // 
            this.btnOtros.Location = new System.Drawing.Point(18, 195);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(171, 36);
            this.btnOtros.TabIndex = 3;
            this.btnOtros.Text = "Otros";
            this.btnOtros.UseVisualStyleBackColor = true;
            // 
            // btnAdopciones
            // 
            this.btnAdopciones.Location = new System.Drawing.Point(18, 263);
            this.btnAdopciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdopciones.Name = "btnAdopciones";
            this.btnAdopciones.Size = new System.Drawing.Size(171, 36);
            this.btnAdopciones.TabIndex = 4;
            this.btnAdopciones.Text = "Adopciones";
            this.btnAdopciones.UseVisualStyleBackColor = true;
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.Location = new System.Drawing.Point(18, 389);
            this.btnColaboradores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(171, 36);
            this.btnColaboradores.TabIndex = 5;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(778, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnColaboradores);
            this.Controls.Add(this.btnAdopciones);
            this.Controls.Add(this.btnOtros);
            this.Controls.Add(this.btnAdoptantes);
            this.Controls.Add(this.btnGatos);
            this.Controls.Add(this.btnPerros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerros;
        private System.Windows.Forms.Button btnGatos;
        private System.Windows.Forms.Button btnAdoptantes;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Button btnAdopciones;
        private System.Windows.Forms.Button btnColaboradores;
        private System.Windows.Forms.Button btnSalir;
    }
}