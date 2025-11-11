namespace CentroAdopcionApp
{
    partial class frmAdopciones
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
            this.Adopciones = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblAdoptante = new System.Windows.Forms.Label();
            this.lblAnimalAdoptado = new System.Windows.Forms.Label();
            this.lblNombreAnimal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombreAnimal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvAdopciones = new System.Windows.Forms.DataGridView();
            this.cboAdoptante = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdopciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Adopciones
            // 
            this.Adopciones.FormattingEnabled = true;
            this.Adopciones.ItemHeight = 16;
            this.Adopciones.Location = new System.Drawing.Point(12, 12);
            this.Adopciones.Name = "Adopciones";
            this.Adopciones.Size = new System.Drawing.Size(1060, 180);
            this.Adopciones.TabIndex = 0;
            this.Adopciones.SelectedIndexChanged += new System.EventHandler(this.Adopciones_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 210);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(987, 210);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblAdoptante
            // 
            this.lblAdoptante.AutoSize = true;
            this.lblAdoptante.Location = new System.Drawing.Point(13, 256);
            this.lblAdoptante.Name = "lblAdoptante";
            this.lblAdoptante.Size = new System.Drawing.Size(69, 16);
            this.lblAdoptante.TabIndex = 3;
            this.lblAdoptante.Text = "Adoptante";
            // 
            // lblAnimalAdoptado
            // 
            this.lblAnimalAdoptado.AutoSize = true;
            this.lblAnimalAdoptado.Location = new System.Drawing.Point(12, 297);
            this.lblAnimalAdoptado.Name = "lblAnimalAdoptado";
            this.lblAnimalAdoptado.Size = new System.Drawing.Size(110, 16);
            this.lblAnimalAdoptado.TabIndex = 4;
            this.lblAnimalAdoptado.Text = "Animal adoptado";
            // 
            // lblNombreAnimal
            // 
            this.lblNombreAnimal.AutoSize = true;
            this.lblNombreAnimal.Location = new System.Drawing.Point(12, 339);
            this.lblNombreAnimal.Name = "lblNombreAnimal";
            this.lblNombreAnimal.Size = new System.Drawing.Size(122, 16);
            this.lblNombreAnimal.TabIndex = 5;
            this.lblNombreAnimal.Text = "Nombre del Animal";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 382);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(125, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Adopción";
            // 
            // txtNombreAnimal
            // 
            this.txtNombreAnimal.Location = new System.Drawing.Point(700, 339);
            this.txtNombreAnimal.Name = "txtNombreAnimal";
            this.txtNombreAnimal.Size = new System.Drawing.Size(362, 22);
            this.txtNombreAnimal.TabIndex = 8;
            this.txtNombreAnimal.TextChanged += new System.EventHandler(this.txtNombreAnimal_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(700, 382);
            this.dtpFecha.MinDate = new System.DateTime(2025, 7, 5, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(362, 22);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cboAnimal
            // 
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(700, 294);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(362, 24);
            this.cboAnimal.TabIndex = 10;
            this.cboAnimal.SelectedIndexChanged += new System.EventHandler(this.cboAnimal_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(987, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvAdopciones
            // 
            this.dgvAdopciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAdopciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdopciones.Location = new System.Drawing.Point(26, 30);
            this.dgvAdopciones.Name = "dgvAdopciones";
            this.dgvAdopciones.RowHeadersWidth = 51;
            this.dgvAdopciones.RowTemplate.Height = 24;
            this.dgvAdopciones.Size = new System.Drawing.Size(1036, 150);
            this.dgvAdopciones.TabIndex = 13;
            this.dgvAdopciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdopciones_CellContentClick);
            // 
            // cboAdoptante
            // 
            this.cboAdoptante.FormattingEnabled = true;
            this.cboAdoptante.Location = new System.Drawing.Point(700, 248);
            this.cboAdoptante.Name = "cboAdoptante";
            this.cboAdoptante.Size = new System.Drawing.Size(362, 24);
            this.cboAdoptante.TabIndex = 14;
            this.cboAdoptante.SelectedIndexChanged += new System.EventHandler(this.cboAdoptante_SelectedIndexChanged);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(526, 426);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(536, 22);
            this.txtObservacion.TabIndex = 15;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Observación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAdopciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1084, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.cboAdoptante);
            this.Controls.Add(this.dgvAdopciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNombreAnimal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombreAnimal);
            this.Controls.Add(this.lblAnimalAdoptado);
            this.Controls.Add(this.lblAdoptante);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Adopciones);
            this.Name = "frmAdopciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adopciones";
            this.Load += new System.EventHandler(this.frmAdopciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdopciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Adopciones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblAdoptante;
        private System.Windows.Forms.Label lblAnimalAdoptado;
        private System.Windows.Forms.Label lblNombreAnimal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombreAnimal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvAdopciones;
        private System.Windows.Forms.ComboBox cboAdoptante;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label1;
    }
}