using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POSCafeteria.DAL;

namespace POSCafeteria
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdCliente, Nombre, Direccion, Telefono FROM Cliente ORDER BY IdCliente ASC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvClientes.DataSource = dt;

                    dtvClientes.Columns["IdCliente"].HeaderText = "ID";
                    dtvClientes.Columns["Nombre"].HeaderText = "Nombre";
                    dtvClientes.Columns["Direccion"].HeaderText = "Dirección";
                    dtvClientes.Columns["Telefono"].HeaderText = "Teléfono";

                    dtvClientes.Columns["IdCliente"].Visible = true;
                    dtvClientes.AutoResizeColumns();
                    dtvClientes.ReadOnly = true;
                    dtvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message);
            }
        }

        private void dtvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvClientes.Rows[e.RowIndex];
                txtNombreclientes.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtDirección.Text = fila.Cells["Direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
            }
        }

        private void btnGuardarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreclientes.Text) ||
                string.IsNullOrWhiteSpace(txtDirección.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    if (dtvClientes.CurrentRow != null &&
                        dtvClientes.CurrentRow.Cells["IdCliente"].Value != null)
                    {

                        int id = Convert.ToInt32(dtvClientes.CurrentRow.Cells["IdCliente"].Value);
                        string sql = "UPDATE Cliente SET Nombre = @nombre, Direccion = @dir, Telefono = @tel WHERE IdCliente = @id";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@nombre", txtNombreclientes.Text);
                        cmd.Parameters.AddWithValue("@dir", txtDirección.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente actualizado.");
                    }
                    else
                    {

                        string sql = "INSERT INTO Cliente (Nombre, Direccion, Telefono) VALUES (@nombre, @dir, @tel)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@nombre", txtNombreclientes.Text);
                        cmd.Parameters.AddWithValue("@dir", txtDirección.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente guardado.");
                    }
                }

                txtNombreclientes.Clear();
                txtDirección.Clear();
                txtTelefono.Clear();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            if (dtvClientes.CurrentRow == null ||
                dtvClientes.CurrentRow.Cells["IdCliente"].Value == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista para eliminar.");
                return;
            }

            string nombre = dtvClientes.CurrentRow.Cells["Nombre"].Value?.ToString();
            DialogResult respuesta = MessageBox.Show("¿Eliminar al cliente \"" + nombre + "\"?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvClientes.CurrentRow.Cells["IdCliente"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Cliente WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente eliminado.");
                txtNombreclientes.Clear();
                txtDirección.Clear();
                txtTelefono.Clear();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnVolverclientes_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormPrincipal"].Show();
            this.Close();
        }

        private void btnEliminarClientes_Click_1(object sender, EventArgs e)
        {
            if (dtvClientes.CurrentRow == null ||
                dtvClientes.CurrentRow.Cells["IdCliente"].Value == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista para eliminar.");
                return;
            }

            string nombre = dtvClientes.CurrentRow.Cells["Nombre"].Value?.ToString();
            DialogResult respuesta = MessageBox.Show("¿Eliminar al cliente \"" + nombre + "\"?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvClientes.CurrentRow.Cells["IdCliente"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Cliente WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente eliminado.");
                txtNombreclientes.Clear();
                txtDirección.Clear();
                txtTelefono.Clear();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnGuardarClientes_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreclientes.Text) ||
                string.IsNullOrWhiteSpace(txtDirección.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "INSERT INTO Cliente (Nombre, Direccion, Telefono) VALUES (@nombre, @dir, @tel)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreclientes.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDirección.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado.");
                }

                txtNombreclientes.Clear();
                txtDirección.Clear();
                txtTelefono.Clear();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void dtvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}