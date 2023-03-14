using Pim_Tool.Dtos;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PIMToolCodeBase.Services {
    /// <summary>
    ///     Example of sample service
    /// </summary>
    public interface IProjectService {
        public Task<IEnumerable<Project>> GetAllProjectAsync (Filter filter);

        public Task<Project> GetAsync (decimal id);

        public Task<Project> AddProject (AddProjectDto projectDTO);

        public Task<ViewProjectDto> UpdateProject (ViewProjectDto projectDto);

        public Task Delete (DeleteProjectDto ProjectsDelete);
        public Task<Project> GetWithEmployeeAsync (decimal id);
        public Task<Project> GetProjectByProjectNumberAsync (decimal project_Number);
    }
}