using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POSCafeteria.DAL;

namespace POSCafeteria
{
    public partial class FormCrédito : Form
    {
        public FormCrédito()
        {
            InitializeComponent();
        }

        private void FormCrédito_Load(object sender, EventArgs e)
        {
            CargarCreditos();
            CargarClientes();
            CargarProductos();
        }

        private void CargarCreditos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {

                    con.Open();
                    string sql = "SELECT c.IdCredito, cl.Nombre AS Cliente, p.Nombre AS Producto, dv.Cant AS Cantidad, dv.Precio_Venta AS Precio, c.Fecha " +
                    "FROM Credito c " +
                    "INNER JOIN Cliente cl ON c.IdCliente = cl.IdCliente " +
                    "INNER JOIN Detalle_Venta dv ON c.IdCredito = dv.IdCredito " +
                    "INNER JOIN Producto p ON dv.IdProducto = p.IdProducto";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvcrédito.DataSource = dt;

                    dtvcrédito.Columns["IdCredito"].HeaderText = "ID";
                    dtvcrédito.Columns["Cliente"].HeaderText = "Cliente";
                    dtvcrédito.Columns["Producto"].HeaderText = "Producto";
                    dtvcrédito.Columns["Cantidad"].HeaderText = "Cantidad";
                    dtvcrédito.Columns["Precio"].HeaderText = "Precio (C$)";
                    dtvcrédito.Columns["Fecha"].HeaderText = "Fecha";

                    dtvcrédito.Columns["IdCredito"].Visible = false;
                    dtvcrédito.AutoResizeColumns();
                    dtvcrédito.ReadOnly = true;
                    dtvcrédito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar créditos:\n" + ex.Message);
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdCliente, Nombre FROM Cliente";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    cmbClienteventa.Items.Clear();
                    while (dr.Read())
                    {
                        cmbClienteventa.Items.Add(dr["IdCliente"] + " - " + dr["Nombre"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdProducto, Nombre, Precio FROM Producto";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    cmbProductoventa.Items.Clear();
                    while (dr.Read())
                    {
                        cmbProductoventa.Items.Add(dr["IdProducto"] + " - " + dr["Nombre"] + " (C$ " + dr["Precio"] + ")");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message);
            }
        }

        private void dtvcrédito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvcrédito.Rows[e.RowIndex];
                cmbClienteventa.Text = fila.Cells["Cliente"].Value?.ToString() ?? "";
                cmbProductoventa.Text = fila.Cells["Producto"].Value?.ToString() ?? "";
                txtCantidadventa.Text = fila.Cells["Cantidad"].Value?.ToString() ?? "";
                txtPrecioventa.Text = fila.Cells["Precio"].Value?.ToString() ?? "";
            }
        }

        private void btnguardarcrédito_Click(object sender, EventArgs e)
        {
            if (cmbClienteventa.SelectedItem == null ||
                cmbProductoventa.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCantidadventa.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioventa.Text))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.");
                return;
            }

            if (!int.TryParse(txtCantidadventa.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                return;
            }

            if (!decimal.TryParse(txtPrecioventa.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número, por ejemplo: 1500.00");
                return;
            }


            int idCliente = Convert.ToInt32(cmbClienteventa.SelectedItem.ToString().Split('-')[0].Trim());
            int idProducto = Convert.ToInt32(cmbProductoventa.SelectedItem.ToString().Split('-')[0].Trim());

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();


                    string sqlCredito = "INSERT INTO Credito (Fecha, IdCliente, IdUsuario) OUTPUT INSERTED.IdCredito VALUES (@fecha, @idcliente, 1)";
                    SqlCommand cmdCredito = new SqlCommand(sqlCredito, con);
                    cmdCredito.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmdCredito.Parameters.AddWithValue("@idcliente", idCliente);
                    int nuevoIdCredito = Convert.ToInt32(cmdCredito.ExecuteScalar());


                    string sqlDetalle = "INSERT INTO Detalle_Venta (Cant, Precio_Venta, IdCredito, IdProducto) VALUES (@cant, @precio, @idcredito, @idproducto)";
                    SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, con);
                    cmdDetalle.Parameters.AddWithValue("@cant", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", precio);
                    cmdDetalle.Parameters.AddWithValue("@idcredito", nuevoIdCredito);
                    cmdDetalle.Parameters.AddWithValue("@idproducto", idProducto);
                    cmdDetalle.ExecuteNonQuery();

                    MessageBox.Show("Crédito guardado correctamente.");
                }

                cmbClienteventa.SelectedIndex = -1;
                cmbProductoventa.SelectedIndex = -1;
                txtCantidadventa.Clear();
                txtPrecioventa.Clear();
                CargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btneliminarcrédito_Click(object sender, EventArgs e)
        {
            if (dtvcrédito.CurrentRow == null ||
                dtvcrédito.CurrentRow.Cells["IdCredito"].Value == null)
            {
                MessageBox.Show("Seleccione un crédito de la lista para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar este crédito?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvcrédito.CurrentRow.Cells["IdCredito"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    string sqlDetalle = "DELETE FROM Detalle_Venta WHERE IdCredito = @id";
                    SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, con);
                    cmdDetalle.Parameters.AddWithValue("@id", id);
                    cmdDetalle.ExecuteNonQuery();

                    string sqlCredito = "DELETE FROM Credito WHERE IdCredito = @id";
                    SqlCommand cmdCredito = new SqlCommand(sqlCredito, con);
                    cmdCredito.Parameters.AddWithValue("@id", id);
                    cmdCredito.ExecuteNonQuery();
                }

                MessageBox.Show("Crédito eliminado.");
                cmbClienteventa.SelectedIndex = -1;
                cmbProductoventa.SelectedIndex = -1;
                txtCantidadventa.Clear();
                txtPrecioventa.Clear();
                CargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms["FormPrincipal"].Show();
            this.Close();
        }

        
        private void btnguardarcrédito_Click_1(object sender, EventArgs e)
        {
            if (cmbClienteventa.SelectedItem == null ||
                cmbProductoventa.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtCantidadventa.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioventa.Text))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.");
                return;
            }

            if (!int.TryParse(txtCantidadventa.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                return;
            }

            if (!decimal.TryParse(txtPrecioventa.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número, por ejemplo: 1500.00");
                return;
            }

            int idCliente = Convert.ToInt32(cmbClienteventa.SelectedItem.ToString().Split('-')[0].Trim());
            int idProducto = Convert.ToInt32(cmbProductoventa.SelectedItem.ToString().Split('-')[0].Trim());

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    string sqlCredito = "INSERT INTO Credito (Fecha, IdCliente, IdUsuario) OUTPUT INSERTED.IdCredito VALUES (@fecha, @idcliente, 1)";
                    SqlCommand cmdCredito = new SqlCommand(sqlCredito, con);
                    cmdCredito.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmdCredito.Parameters.AddWithValue("@idcliente", idCliente);
                    int nuevoIdCredito = Convert.ToInt32(cmdCredito.ExecuteScalar());

                    string sqlDetalle = "INSERT INTO Detalle_Venta (Cant, Precio_Venta, IdCredito, IdProducto) VALUES (@cant, @precio, @idcredito, @idproducto)";
                    SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, con);
                    cmdDetalle.Parameters.AddWithValue("@cant", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", precio);
                    cmdDetalle.Parameters.AddWithValue("@idcredito", nuevoIdCredito);
                    cmdDetalle.Parameters.AddWithValue("@idproducto", idProducto);
                    cmdDetalle.ExecuteNonQuery();

                    MessageBox.Show("Crédito guardado correctamente.");
                }

                cmbClienteventa.SelectedIndex = -1;
                cmbProductoventa.SelectedIndex = -1;
                txtCantidadventa.Clear();
                txtPrecioventa.Clear();
                CargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btneliminarcrédito_Click_1(object sender, EventArgs e)
        {
            if (dtvcrédito.CurrentRow == null ||
                dtvcrédito.CurrentRow.Cells["IdCredito"].Value == null)
            {
                MessageBox.Show("Seleccione un crédito de la lista para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar este crédito?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvcrédito.CurrentRow.Cells["IdCredito"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    // Primero eliminar el detalle, luego el crédito
                    string sqlDetalle = "DELETE FROM Detalle_Venta WHERE IdCredito = @id";
                    SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, con);
                    cmdDetalle.Parameters.AddWithValue("@id", id);
                    cmdDetalle.ExecuteNonQuery();

                    string sqlCredito = "DELETE FROM Credito WHERE IdCredito = @id";
                    SqlCommand cmdCredito = new SqlCommand(sqlCredito, con);
                    cmdCredito.Parameters.AddWithValue("@id", id);
                    cmdCredito.ExecuteNonQuery();
                }

                MessageBox.Show("Crédito eliminado.");
                cmbClienteventa.SelectedIndex = -1;
                cmbProductoventa.SelectedIndex = -1;
                txtCantidadventa.Clear();
                txtPrecioventa.Clear();
                CargarCreditos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

       
        
    }
}