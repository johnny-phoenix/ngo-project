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
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(300);
            builder.Property(x => x.PageDonationTitle)
                .HasMaxLength(300)
                .IsUnicode();
            builder.Property(x => x.PageDonationAccount)
                .HasMaxLength(20)
                .IsUnicode();
            builder.Property(x => x.CollectDonation)
                .HasDefaultValue(false)
                .IsRequired();
            builder.HasOne(x => x.Languages)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.LanguageId);
            builder.Property(x => x.Url)
                .IsRequired(true)
                .HasMaxLength(200)
                .IsUnicode(true);
            builder.Property(x => x.ShortDescription)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(300);
            builder.Property(x => x.Currency)
                .IsRequired()
                .IsUnicode()
                .HasDefaultValue("Euro");
            builder.Property(x => x.AmountOfBudget)
                .IsRequired()
                .HasDefaultValue(0);
            builder.HasOne(x => x.Regions)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Property(x => x.ProjectDonors)
                .IsUnicode();
            builder.Property(x => x.ProjectImplementors)
                .IsUnicode();
            builder.Property(x => x.Aims)
                .IsUnicode();
            builder.Property(x => x.Results)
                .IsUnicode();
            builder.Property(x => x.IsActive)
                .IsRequired();
            builder.Property(x => x.StartDate)
                .IsRequired();
            builder.Property(x => x.EndDate)
                .IsRequired();
            builder.HasOne(x => x.Users)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
                
        }
    }
}
