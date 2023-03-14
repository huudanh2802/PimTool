using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pim_Tool.Dtos;
using Pim_Tool.Services;
using PIMToolCodeBase.Controllers;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Controllers {
    [Route("api/[controller]")]

    public class GroupController : BaseController {
        private readonly IMapper _mapper;
        private readonly IGroupService _groupService;

        public GroupController (IGroupService groupService,
            IMapper mapper) {
            _groupService = groupService;
            _mapper = mapper;
        }

        // GET: api/Group
        [HttpGet()]
        public async Task<IActionResult> GetAllProject () {

            var ListGroup = await _groupService.GetAllGroupAsync();
            return Ok(_mapper.Map<IEnumerable<Group>, IEnumerable<GroupDto>>(ListGroup));
        }

    }
}
