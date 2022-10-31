using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NGO.Domain;

namespace NGO.Infrastructure.Persistance.Configurations
{
    public class PersonalStoriyConfigurations : IEntityTypeConfiguration<PersonalStory>
    {
        void IEntityTypeConfiguration<PersonalStory>.Configure(EntityTypeBuilder<PersonalStory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode();
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode();
            builder.Property(x => x.StoryContent)
                .IsRequired()
                .IsUnicode();
            builder.Property(x => x.MainImage)
                .HasDefaultValue(null)
                .HasMaxLength(200);
            builder.HasOne(x => x.Language)
                .WithMany(x => x.PersonalStories)
                .HasForeignKey(x => x.LanguageId)
                .IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(x => x.PersonalStories)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
            builder.Property(x => x.CreatedDate)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
            //throw new NotImplementedException();
        }
    }
}
