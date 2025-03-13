namespace RelationshipsInEFCore.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }
        public string Bio { get; set; } = string.Empty;
        public Student? Student { get; set; }
    }
}
