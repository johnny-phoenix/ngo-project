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
    public class NewsConfigurations : IEntityTypeConfiguration<News>
    {
        public NewsConfigurations()
        {
        }

        public void Configure(EntityTypeBuilder<News> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(x => x.Id).IsClustered();
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(300);
            builder.Property(x => x.ShortDescription)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.NewsContent)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
            builder.HasOne(x => x.Languages)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.LanguagesId)
                .IsRequired();
            builder.HasOne(x => x.Projects)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.ProjectId);
            builder.HasOne(x => x.Regions)
                .WithMany(x => x.News)
                .HasForeignKey(x => x.RegionId);
            builder.Property(x => x.Url)
                .IsRequired(true);

        }
    }
}
