
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using POSCafeteria.DAL;

namespace POSCafeteria
{
    public partial class FormAbono : Form
    {
        public FormAbono()
        {
            InitializeComponent();
        }

        private void FormAbono_Load(object sender, EventArgs e)
        {
            CargarAbonos();
            CargarCreditos();
        }

        private void CargarAbonos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdAbono, IdCredito, Monto_Pagado, Fecha_Pago FROM Abono";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvabono.DataSource = dt;

                    dtvabono.Columns["IdAbono"].HeaderText = "ID Abono";
                    dtvabono.Columns["IdCredito"].HeaderText = "ID Crédito";
                    dtvabono.Columns["Monto_Pagado"].HeaderText = "Monto (C$)";
                    dtvabono.Columns["Fecha_Pago"].HeaderText = "Fecha";

                    dtvabono.Columns["IdAbono"].Visible = false;
                    dtvabono.AutoResizeColumns();
                    dtvabono.ReadOnly = true;
                    dtvabono.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar abonos:\n" + ex.Message);
            }
        }

        private void CargarCreditos()
        {
            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT IdCredito FROM Credito";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    cmbcréditoabono.Items.Clear();
                    while (dr.Read())
                    {
                        cmbcréditoabono.Items.Add(dr["IdCredito"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar créditos:\n" + ex.Message);
            }
        }

        private void dtvabono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtvabono.Rows[e.RowIndex];
                txtmontoabono.Text = fila.Cells["Monto_Pagado"].Value?.ToString() ?? "";
                cmbcréditoabono.Text = fila.Cells["IdCredito"].Value?.ToString() ?? "";
            }
        }

        private void btnguardarAbono_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmontoabono.Text) ||
                cmbcréditoabono.SelectedItem == null)
            {
                MessageBox.Show("Complete el monto y seleccione un crédito.");
                return;
            }

            if (!decimal.TryParse(txtmontoabono.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser un número, por ejemplo: 500.00");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    if (dtvabono.CurrentRow != null &&
                        dtvabono.CurrentRow.Cells["IdAbono"].Value != null)
                    {
                        // ACTUALIZAR
                        int id = Convert.ToInt32(dtvabono.CurrentRow.Cells["IdAbono"].Value);
                        string sql = "UPDATE Abono SET Monto_Pagado = @monto, IdCredito = @idcredito WHERE IdAbono = @id";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@idcredito", cmbcréditoabono.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Abono actualizado.");
                    }
                    else
                    {
                        // INSERTAR
                        string sql = "INSERT INTO Abono (Monto_Pagado, IdCredito, Fecha_Pago) VALUES (@monto, @idcredito, @fecha)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@idcredito", cmbcréditoabono.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Abono guardado.");
                    }
                }

                txtmontoabono.Clear();
                cmbcréditoabono.SelectedIndex = -1;
                CargarAbonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btneliminarAbono_Click(object sender, EventArgs e)
        {
            if (dtvabono.CurrentRow == null ||
                dtvabono.CurrentRow.Cells["IdAbono"].Value == null)
            {
                MessageBox.Show("Seleccione un abono de la lista para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar este abono?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvabono.CurrentRow.Cells["IdAbono"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Abono WHERE IdAbono = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Abono eliminado.");
                txtmontoabono.Clear();
                cmbcréditoabono.SelectedIndex = -1;
                CargarAbonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnvolverAbono_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormPrincipal"].Show();
            this.Close();
        }

        private void btnguardarAbono_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmontoabono.Text) ||
                cmbcréditoabono.SelectedItem == null)
            {
                MessageBox.Show("Complete el monto y seleccione un crédito.");
                return;
            }

            if (!decimal.TryParse(txtmontoabono.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser un número, por ejemplo: 500.00");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();

                    if (dtvabono.CurrentRow != null &&
                        dtvabono.CurrentRow.Cells["IdAbono"].Value != null)
                    {

                        int id = Convert.ToInt32(dtvabono.CurrentRow.Cells["IdAbono"].Value);
                        string sql = "UPDATE Abono SET Monto_Pagado = @monto, IdCredito = @idcredito WHERE IdAbono = @id";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@idcredito", cmbcréditoabono.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Abono actualizado.");
                    }
                    else
                    {

                        string sql = "INSERT INTO Abono (Monto_Pagado, IdCredito, Fecha_Pago) VALUES (@monto, @idcredito, @fecha)";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@idcredito", cmbcréditoabono.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Abono guardado.");
                    }
                }

                txtmontoabono.Clear();
                cmbcréditoabono.SelectedIndex = -1;
                CargarAbonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message);
            }
        }

        private void btneliminarAbono_Click_1(object sender, EventArgs e)
        {
            if (dtvabono.CurrentRow == null ||
                dtvabono.CurrentRow.Cells["IdAbono"].Value == null)
            {
                MessageBox.Show("Seleccione un abono de la lista para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Eliminar este abono?", "Confirmar", MessageBoxButtons.YesNo);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dtvabono.CurrentRow.Cells["IdAbono"].Value);
                using (SqlConnection con = ConexionDB.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM Abono WHERE IdAbono = @id";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Abono eliminado.");
                txtmontoabono.Clear();
                cmbcréditoabono.SelectedIndex = -1;
                CargarAbonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

     
            
        
    }
}