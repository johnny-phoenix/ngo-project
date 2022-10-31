using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NGO.Domain;

namespace NGO.Infrastructure.Persistance.Configurations
{
    public class LibraryConfigurations : IEntityTypeConfiguration<Library>
    {
        void IEntityTypeConfiguration<Library>.Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode();
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(700)
                .IsUnicode();
            builder.Property(x => x.CoverImageUri)
                .IsRequired()
                .HasMaxLength(250);
            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(250);
            builder.HasOne(x => x.Language)
                .WithMany(x => x.Libraries)
                .HasForeignKey(x => x.LanguageId)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.Libraries)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
            builder.Property(x => x.AddedDate)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            
            //throw new NotImplementedException();
        }
    }
}
