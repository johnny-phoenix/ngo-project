using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NGO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        void IEntityTypeConfiguration<Region>.Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(x => x.Id).IsClustered();
            builder.Property(x => x.NameRO)
                .HasMaxLength(50)
                .IsUnicode(true);
            builder.Property(x => x.NameEN)
                .HasMaxLength(50)
                .IsUnicode(true);
            /*
            builder.HasMany(x => x.News)
                .WithMany(x => x.Regions)
                .UsingEntity(x => x.ToTable("RegionsNews"));
            builder.HasMany(x => x.Projects)
                .WithMany(x => x.Regions)
                .UsingEntity(x => x.ToTable("RegionsProjects"));
            */
            
        }
    }
}
