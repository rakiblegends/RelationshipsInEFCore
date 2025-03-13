using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);

            // One to One with StudentProfile
            builder.HasOne(s => s.Profile)
                .WithOne(p => p.Student)
                .HasForeignKey<StudentProfile>(p => p.Id) //Shared Primary Key
                .OnDelete(DeleteBehavior.Cascade);


            //One to Many with Enrollment
            builder.HasMany(s => s.Enrollments)
                .WithOne(p => p.Student)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
