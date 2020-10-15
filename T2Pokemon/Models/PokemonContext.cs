using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2Pokemon.Models.Maps;

namespace T2Pokemon.Models
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemones { get; set; }
        public DbSet<Elemento> Elementos { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Captura> Capturas { get; set; }
        public PokemonContext(DbContextOptions<PokemonContext> options)
          : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PokemonMap());
            modelBuilder.ApplyConfiguration(new ElementoMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CapturaMap());
        }
    }
}
