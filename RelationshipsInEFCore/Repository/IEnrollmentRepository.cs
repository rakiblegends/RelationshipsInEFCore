using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Repository
{
    public interface IEnrollmentRepository: IRepository<Enrollment>
    {
        Task<IEnumerable<Enrollment>> GetCourseEnrollmentsAsync(int courseId);
    }
}
