using System;
using System.Collections.Generic;
using System.Text;

namespace POSCafeteria.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
    }
}
