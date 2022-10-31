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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(60);
            builder.Property(x => x.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(60);
            builder.Property(x => x.Email)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            builder.Property(x => x.Phone)
                .HasDefaultValue(null)
                .HasMaxLength(12);
            builder.Property(x => x.Login)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            builder.Property(x => x.Passwd)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);
            builder.Property(x => x.IsAdmin)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(x => x.CanDownloadSpecialFiles)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(x => x.IsNewsEditor)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(x => x.IsLibraryeditor)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(x => x.IsPersonalStoryesEditor)
                .HasDefaultValue(false)
                .IsRequired();
            builder.Property(x => x.DateCreated)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            builder.Property(x => x.DateUpdated)
                .HasDefaultValue(null);


            //throw new NotImplementedException();
        }
    }
}
