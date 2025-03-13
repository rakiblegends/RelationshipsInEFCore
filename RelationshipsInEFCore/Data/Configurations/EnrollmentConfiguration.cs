using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Data.Configurations
{
    public class EnrollmentConfiguration: IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => new {e.StudentId, e.CourseId}); //Composite Key
        }
    }
}
