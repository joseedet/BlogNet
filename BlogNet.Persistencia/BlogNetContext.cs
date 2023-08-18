using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Persistencia
{
    public class BlogNetContext
    {
        public class BlogNetContext: DbContext
        {
        public BlogNetContext(DbContextOptions options):base(options)
        {
             
        }      
        public DbSet <Alamacen> Almacen { get; set; }
        public DbSet <Cliente> Cliente { get; set; }
        public DbSet <Departamento> Departamento { get; set; }
        public DbSet  <IVA> IVA { get; set; }
        public DbSet  <Medida> Medida { get; set; }
        public DbSet <Proveedor> Proveedor{ get; set; }
        public DbSet  <TipoDocumento> TipoDocumento{ get; set; }
        
    }
    }
}