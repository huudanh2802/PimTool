using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using PIMToolCodeBase.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories {
    public interface IProjectRepository : IRepository<Project> {
        public Task<Project> GetWithEmployeeAsync (decimal id);
        public Task<IEnumerable<Project>> GetAllWithEmployeesAsync (Filter filter);
        public Task<Project> GetProjectByProjectNumberAsync (decimal project_Number);
    }
}
