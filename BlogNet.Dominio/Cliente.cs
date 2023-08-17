using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdTipoDocumento { get; set; }
        public string RazonSocial{ get; set; }
        public string NombreContacto { get; set; }
        public string ApellidosContactos { get; set; }
        public string Direccion { get; set; }
        public string CodPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; } 
        public string Movil { get; set; }
        public string Correo { get; set; }
        public string Imagen { get; set; }
        public bool Activo { get; set; }

    }
}
