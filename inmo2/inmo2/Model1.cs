namespace inmo2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using inmo2.Models;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=InmoDB")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<PropiedadesImagenes> PropiedadesImagenes { get; set; }
        public DbSet<Propiedades> Propiedades { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
