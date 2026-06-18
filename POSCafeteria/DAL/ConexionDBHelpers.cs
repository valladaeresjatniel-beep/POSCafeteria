using Microsoft.Data.SqlClient;

namespace POSCafeteria.DAL
{
    internal static class ConexionDBHelpers
    {
        public static string CadenaConexion = "Server=PSYCHOPOMP;Database=VentasCreditoDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}