using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Repository
{
    public interface IStudentRepository: IRepository<Student>
    {
        Task<Student?> GetStudentDetailsByIdAsync(int id);
    }
}
