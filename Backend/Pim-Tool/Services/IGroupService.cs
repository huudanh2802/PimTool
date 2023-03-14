using PIMToolCodeBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Services {
    public interface IGroupService {
        public Task<IEnumerable<Group>> GetAllGroupAsync ();

    }
}
