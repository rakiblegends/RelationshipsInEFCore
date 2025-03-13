namespace RelationshipsInEFCore.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public StudentProfile? Profile { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = [];
    }
}
