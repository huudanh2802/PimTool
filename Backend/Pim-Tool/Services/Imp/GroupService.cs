using Pim_Tool.Repositories;
using PIMToolCodeBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Services.Imp {
    public class GroupService : IGroupService {
        private readonly IGroupRepository _groupRepository;
        public GroupService (
     IGroupRepository groupRepository
    ) {
            _groupRepository = groupRepository;
        }

        public Task<IEnumerable<Group>> GetAllGroupAsync () {
            return _groupRepository.GetAllAsync();

        }
    }
}
