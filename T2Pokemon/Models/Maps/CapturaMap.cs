using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T2Pokemon.Models.Maps
{
    public class CapturaMap : IEntityTypeConfiguration<Captura>
    { 

        public void Configure(EntityTypeBuilder<Captura> builder)
        {
            builder.ToTable("UsuarioPokemon");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Pokemon).
                WithMany(o => o.Capturas).
                HasForeignKey(o => o.IdPokemon);

        }
    }
}
