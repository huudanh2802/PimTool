using Microsoft.EntityFrameworkCore;
using PIMToolCodeBase.Database;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using PIMToolCodeBase.Repositories.Imp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories.Imp {
    /// <summary>
    ///     The implementation of project repository
    /// </summary>
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository {
        public ProjectRepository (PimContext pimContext) : base(pimContext) {
        }

        public async Task<Project> GetWithEmployeeAsync (decimal id) {
            return await Set.Include(p => p.ProjectEmployees).ThenInclude(pe => pe.Employee).AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<Project>> GetAllWithEmployeesAsync (Filter filter) {
            return await Set.Include(p => p.ProjectEmployees).ThenInclude(pe => pe.Employee)
                .Where(p =>
                filter.Name == null || p.Name == filter.Name
                &&
                filter.Customer == null || p.Customer == filter.Customer
                &&
                filter.Number == null || p.ProjectNumber == filter.Number
                &&
                filter.Status == null || nameof(p.Status) == filter.Status)
                .AsNoTracking().ToListAsync();

        }

        public async Task<Project> GetProjectByProjectNumberAsync (decimal project_Number) {
            return await Set.AsNoTracking().SingleOrDefaultAsync(p => p.ProjectNumber == project_Number);
        }
    }
}
