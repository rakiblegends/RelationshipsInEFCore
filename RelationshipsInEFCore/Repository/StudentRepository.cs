using Microsoft.EntityFrameworkCore;
using RelationshipsInEFCore.Data;
using RelationshipsInEFCore.Models;

namespace RelationshipsInEFCore.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }
        public async Task<Student?> GetStudentDetailsByIdAsync(int id)
        {
            return await _dbSet
                .Include(s=>s.Profile)
                .Include(s=>s.Enrollments)
                .ThenInclude(e => e.Course)
                .FirstOrDefaultAsync(s => s.Id == id);
        }
        public override async Task<Student?> GetByIdAsync(int id)
        {
            return await _dbSet
                .Include(s => s.Profile)
                .FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
