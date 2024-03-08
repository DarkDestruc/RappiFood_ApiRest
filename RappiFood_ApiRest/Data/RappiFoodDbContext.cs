using Microsoft.EntityFrameworkCore;
using RappiFood_ApiRest.Models;

namespace RappiFood_ApiRest.Data
{
    public class RappiFoodDbContext:DbContext
    {
        public RappiFoodDbContext(DbContextOptions<RappiFoodDbContext> options)
        : base(options)
        { 
        }

        public DbSet<MenuRappiFood> MenuRappiFoods { get; set; }
        public object MenuRappiFood { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuRappiFood>().HasData(
                new MenuRappiFood { Id = 1, NameFood = "Encebollado", Description = "Caldo de vegetales con albacora", Price = 2.50m },
                new MenuRappiFood { Id= 2, NameFood = "Cebiche de Pescado", Description = "Caldo frio con pescado curtido", Price = 3.50m },
                new MenuRappiFood { Id = 3, NameFood = "Bollo de Pescado", Description = "Verde cocinado en hoja relleno de pescado", Price = 1.50m }
                );



            base.OnModelCreating(modelBuilder);
        }

    }
}
