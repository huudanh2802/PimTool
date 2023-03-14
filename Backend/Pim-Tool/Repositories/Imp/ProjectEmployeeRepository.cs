using Microsoft.EntityFrameworkCore;
using PIMToolCodeBase.Database;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Repositories.Imp;
using System.Linq;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories.Imp {
    /// <summary>
    ///     The implementation of project repository
    /// </summary>
    public class ProjectEmployeeRepository : BaseRepository<Project_Employee>, IProjectEmployeeRepository {

        public ProjectEmployeeRepository (PimContext pimContext) : base(pimContext) {

        }

        public async Task<Project_Employee> GetAsync (decimal ProjectId, decimal Employee_Id) {
            return await Set.AsNoTracking().SingleOrDefaultAsync(x =>
                x.ProjectId == ProjectId &&
                x.EmployeeId == Employee_Id
                );

        }


        public void DeleteWithProjectId (params decimal[] project_ids) {
            Set.RemoveRange(Set.AsNoTracking().Where(x => project_ids.Contains(x.ProjectId)));
        }


    }
}
