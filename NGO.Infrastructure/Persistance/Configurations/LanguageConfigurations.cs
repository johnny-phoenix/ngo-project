using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NGO.Domain;

namespace NGO.Infrastructure.Persistance.Configurations
{
    public class LanguageConfigurations : IEntityTypeConfiguration<Language>
    {
        void IEntityTypeConfiguration<Language>.Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(x => x.Id)
                .IsClustered();
            builder.Property(x => x.LanguageName)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength(true);
            
            
        }

        
    }
}
