using Microsoft.EntityFrameworkCore;
using CuidadoRemoto.Dominio;

namespace CuidadoRemoto.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Bovino> Bovinos { get; set; }
        public DbSet<PropietarioBovino> Propietarios { get; set; }

        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<IndicacionCuidado> Indicaciones {get; set; }

        // configuracion de la base de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)// configuracion de la base de datos
            {
                optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoRemotoData");
            }

        }

    }

}