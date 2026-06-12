using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSCafeteria.DAL
{
    public static class ConexionDB
    {
        private const string CadenaConexionBase = "Server=LAPTOP-HLMON4R3;Database=VentasCreditoDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static string CadenaConexion = CadenaConexionBase;
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
