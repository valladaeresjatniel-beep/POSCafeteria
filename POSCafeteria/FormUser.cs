using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POSCafeteria.DAL;

namespace POSCafeteria
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void btnguardaruser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñaactual.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñanueva.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarcontraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (txtContraseñanueva.Text != txtConfirmarcontraseña.Text)
            {
                MessageBox.Show("La contraseña nueva y la confirmación no coinciden.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    
                    string sqlVerificar = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario AND Clave = @claveactual";
                    SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, con);
                    cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmdVerificar.Parameters.AddWithValue("@claveactual", txtContraseñaactual.Text);
                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("El usuario o la contraseña actual son incorrectos.");
                        return;
                    }

                    
                    string sqlActualizar = "UPDATE Usuario SET Clave = @claveNueva WHERE NombreUsuario = @usuario";
                    SqlCommand cmdActualizar = new SqlCommand(sqlActualizar, con);
                    cmdActualizar.Parameters.AddWithValue("@claveNueva", txtContraseñanueva.Text);
                    cmdActualizar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmdActualizar.ExecuteNonQuery();

                    MessageBox.Show("Contraseña actualizada correctamente.");
                }

                txtUsuario.Clear();
                txtContraseñaactual.Clear();
                txtContraseñanueva.Clear();
                txtConfirmarcontraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message);
            }
        }

        private void btnEliminaruser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Escriba el nombre de usuario que desea eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar al usuario \"" + txtUsuario.Text + "\"?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Usuario WHERE NombreUsuario = @usuario";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario eliminado.");
                txtUsuario.Clear();
                txtContraseñaactual.Clear();
                txtContraseñanueva.Clear();
                txtConfirmarcontraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnVolveruser_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormPrincipal"].Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnguardaruser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñaactual.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñanueva.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarcontraseña.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (txtContraseñanueva.Text != txtConfirmarcontraseña.Text)
            {
                MessageBox.Show("La contraseña nueva y la confirmación no coinciden.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    string sqlVerificar = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario AND Clave = @claveactual";
                    SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, con);
                    cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmdVerificar.Parameters.AddWithValue("@claveactual", txtContraseñaactual.Text);
                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (existe == 0)
                    {
                        MessageBox.Show("El usuario o la contraseña actual son incorrectos.");
                        return;
                    }

                    string sqlActualizar = "UPDATE Usuario SET Clave = @claveNueva WHERE NombreUsuario = @usuario";
                    SqlCommand cmdActualizar = new SqlCommand(sqlActualizar, con);
                    cmdActualizar.Parameters.AddWithValue("@claveNueva", txtContraseñanueva.Text);
                    cmdActualizar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmdActualizar.ExecuteNonQuery();

                    MessageBox.Show("Contraseña actualizada correctamente.");
                }

                txtUsuario.Clear();
                txtContraseñaactual.Clear();
                txtContraseñanueva.Clear();
                txtConfirmarcontraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message);
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}