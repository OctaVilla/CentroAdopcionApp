private void button1_Click(object sender, EventArgs e)
{
    string usuario = txtUsuario.Text.Trim();
    string contraseña = txtContraseña.Text.Trim();
    // Validación para iniciar sesión 
    if (usuario == "admin" && contraseña == "1234")
    {
        MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Hide(); // Oculta el formulario de login
        frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(); // Crea una instancia del formulario principal
        menuPrincipal.Show(); // Muestra el formulario principal
    }
    else
    {
        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
