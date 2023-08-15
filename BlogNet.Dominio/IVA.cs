using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Dominio
{
    public class IVA
    {
        public int IdIVA { get; set; }    
        public string Descripcion { get; set; }
        public float Tarifa { get; set; }
        public bool Activo { get; set; }
    }
}