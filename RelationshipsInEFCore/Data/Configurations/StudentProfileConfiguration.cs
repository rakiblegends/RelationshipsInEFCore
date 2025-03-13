using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Data.Configurations
{
    public class StudentProfileConfiguration : IEntityTypeConfiguration<StudentProfile>
    {
        public void Configure(EntityTypeBuilder<StudentProfile> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Bio).HasMaxLength(500);
        }
    }
}
