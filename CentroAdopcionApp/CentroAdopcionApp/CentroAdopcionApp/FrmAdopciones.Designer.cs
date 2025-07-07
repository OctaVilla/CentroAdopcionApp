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
            this.txtAdoptante = new System.Windows.Forms.TextBox();
            this.txtNombreAnimal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adopciones
            // 
            this.Adopciones.FormattingEnabled = true;
            this.Adopciones.ItemHeight = 16;
            this.Adopciones.Location = new System.Drawing.Point(13, 13);
            this.Adopciones.Name = "Adopciones";
            this.Adopciones.Size = new System.Drawing.Size(775, 180);
            this.Adopciones.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 210);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(713, 210);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
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
            this.lblAnimalAdoptado.Location = new System.Drawing.Point(12, 298);
            this.lblAnimalAdoptado.Name = "lblAnimalAdoptado";
            this.lblAnimalAdoptado.Size = new System.Drawing.Size(110, 16);
            this.lblAnimalAdoptado.TabIndex = 4;
            this.lblAnimalAdoptado.Text = "Animal adoptado";
            // 
            // lblNombreAnimal
            // 
            this.lblNombreAnimal.AutoSize = true;
            this.lblNombreAnimal.Location = new System.Drawing.Point(13, 339);
            this.lblNombreAnimal.Name = "lblNombreAnimal";
            this.lblNombreAnimal.Size = new System.Drawing.Size(122, 16);
            this.lblNombreAnimal.TabIndex = 5;
            this.lblNombreAnimal.Text = "Nombre del Animal";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 382);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(125, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Adopción";
            // 
            // txtAdoptante
            // 
            this.txtAdoptante.Location = new System.Drawing.Point(426, 249);
            this.txtAdoptante.Name = "txtAdoptante";
            this.txtAdoptante.Size = new System.Drawing.Size(362, 22);
            this.txtAdoptante.TabIndex = 7;
            // 
            // txtNombreAnimal
            // 
            this.txtNombreAnimal.Location = new System.Drawing.Point(426, 333);
            this.txtNombreAnimal.Name = "txtNombreAnimal";
            this.txtNombreAnimal.Size = new System.Drawing.Size(362, 22);
            this.txtNombreAnimal.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(426, 382);
            this.dtpFecha.MinDate = new System.DateTime(2025, 7, 5, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(362, 22);
            this.dtpFecha.TabIndex = 9;
            // 
            // cboAnimal
            // 
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(426, 289);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(362, 24);
            this.cboAnimal.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 479);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmAdopciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNombreAnimal);
            this.Controls.Add(this.txtAdoptante);
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
        private System.Windows.Forms.TextBox txtAdoptante;
        private System.Windows.Forms.TextBox txtNombreAnimal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}