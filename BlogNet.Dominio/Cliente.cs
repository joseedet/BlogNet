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
        public required string RazonSocial{ get; set; }
        public required string NombreContacto { get; set; }
        public required string ApellidosContactos { get; set; }
        public required string Direccion { get; set; }
        public required string CodPostal { get; set; }
        public required string Poblacion { get; set; }
        public required string Provincia { get; set; }
        public  string ? Telefono { get; set; } 
        public required string Movil { get; set; }
        public required string Correo { get; set; }
        public string ?Imagen { get; set; }
        public bool Activo { get; set; }

    }
}
