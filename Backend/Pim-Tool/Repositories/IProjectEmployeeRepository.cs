using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Repositories;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories {
    public interface IProjectEmployeeRepository : IRepository<Project_Employee> {

        /// <summary>
        ///     Get specific entity by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Project_Employee> GetAsync (decimal ProjectId, decimal Employee_Id);

        /// <summary>
        ///     Delete entities based on their ProjectId
        /// </summary>
        /// <param name="ProjectIds"></param>
        void DeleteWithProjectId (params decimal[] ProjectIds);

    }
}
