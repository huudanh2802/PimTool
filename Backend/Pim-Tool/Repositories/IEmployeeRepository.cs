using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories {
    public interface IEmployeeRepository : IRepository<Employee> {
        public Task<Employee> GetEmployeeByVisaAsync (string Visa);
        public Task<bool> AnyEmployeeByVisaAsync (string Visa);
        public Task<IEnumerable<decimal>> GetAllEmployeesIdsByVisaAsync (string[] visas);

    }
}
