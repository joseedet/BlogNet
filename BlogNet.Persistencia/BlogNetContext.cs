using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogNet.Persistencia
{
    public class BlogNetContext
    {
        public class BlogNetContext:DbContext
    {
        public BlogNetContext(DbContextOptions options):base(options)
        {
             
        }      
        public DbSet <Alamacen> { get; set; }
        public DbSet <Cliente> { get; set; }
        public DbSet <Departamento> { get; set; }
        public DbSet  <IVA> { get; set; }
        public DbSet  <Medida>{ get; set; }
        public DbSet <Proveedor>{ get; set; }
        public DbSet  <TipoDocumento> { get; set; }
        
    }
    }
}