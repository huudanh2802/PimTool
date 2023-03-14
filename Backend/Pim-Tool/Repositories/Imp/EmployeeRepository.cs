using Microsoft.EntityFrameworkCore;
using PIMToolCodeBase.Database;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Repositories.Imp;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Pim_Tool.Repositories.Imp {
    /// <summary>
    ///     The implementation of project repository
    /// </summary>
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository {
        public EmployeeRepository (PimContext pimContext) : base(pimContext) {
        }
        public async Task<Employee> GetEmployeeByVisaAsync (string Visa) {
            return await Get().AsQueryable().SingleOrDefaultAsync(e => e.Visa == Visa);
        }
        public Task<bool> AnyEmployeeByVisaAsync (string Visa) {
            return Set.AnyAsync(x => x.Visa == Visa);
        }
        public async Task<IEnumerable<decimal>> GetAllEmployeesIdsByVisaAsync (string[] visas) {
            return await Set.Where(x => visas.Contains(x.Visa)).Select(e => e.Id).ToListAsync();
        }


    }
}
