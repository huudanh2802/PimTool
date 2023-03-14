
using PIMToolCodeBase.Database;
using PIMToolCodeBase.Domain.Entities;

using PIMToolCodeBase.Repositories.Imp;


namespace Pim_Tool.Repositories.Imp {

    public class GroupRepository : BaseRepository<Group>, IGroupRepository {
        public GroupRepository (PimContext pimContext) : base(pimContext) {

        }
    }
}
