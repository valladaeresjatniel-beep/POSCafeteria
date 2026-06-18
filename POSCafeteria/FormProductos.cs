
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POSCafeteria.DAL;

namespace POSCafeteria
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdProducto, Nombre, Marca, Precio, Descripcion FROM Producto";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvProductos.DataSource = dt;

                    
                    dtvProductos.Columns["Nombre"].HeaderText = "Nombre";
                    dtvProductos.Columns["Marca"].HeaderText = "Marca";
                    dtvProductos.Columns["Precio"].HeaderText = "Precio (C$)";
                    dtvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                    dtvProductos.Columns["IdProducto"].Visible = true;

                    dtvProductos.AutoResizeColumns();
                    dtvProductos.ReadOnly = true;
                    dtvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message);
            }
        }

        private void dtvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvProductos.Rows[e.RowIndex];
                txtNombreproducto.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtMarcaproducto.Text = fila.Cells["Marca"].Value?.ToString() ?? "";
                txtPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? "";
                txtDescripción.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";
            }
        }

        private void btnGuardarproducto_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreproducto.Text) ||
                string.IsNullOrWhiteSpace(txtMarcaproducto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Complete Nombre, Marca y Precio antes de guardar.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número, por ejemplo: 1500.00");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "INSERT INTO Producto (Nombre, Marca, Precio, Descripcion) VALUES (@nombre, @marca, @precio, @desc)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreproducto.Text);
                    cmd.Parameters.AddWithValue("@marca", txtMarcaproducto.Text);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@desc", txtDescripción.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado.");
                }

                txtNombreproducto.Clear();
                txtMarcaproducto.Clear();
                txtPrecio.Clear();
                txtDescripción.Clear();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btnEliminarproducto_Click_1(object sender, EventArgs e)
        {
            if (dtvProductos.CurrentRow == null ||
                dtvProductos.CurrentRow.Cells["IdProducto"].Value == null)
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.");
                return;
            }

            string nombre = dtvProductos.CurrentRow.Cells["Nombre"].Value?.ToString();
            DialogResult respuesta = MessageBox.Show("¿Eliminar el producto \"" + nombre + "\"?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvProductos.CurrentRow.Cells["IdProducto"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Producto WHERE IdProducto = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto eliminado.");
                txtNombreproducto.Clear();
                txtMarcaproducto.Clear();
                txtPrecio.Clear();
                txtDescripción.Clear();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnvolverproducto_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormPrincipal"].Show();
            this.Close();
        }

   
        
    }
}
