using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pim_Tool.Attributes;
using Pim_Tool.Dtos;
using Pim_Tool.Exceptions;
using PIMToolCodeBase.Controllers;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using PIMToolCodeBase.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pim_Tool.Controllers {
    [Route("api/[controller]")]
    public class ProjectController : BaseController {
        private readonly IMapper _mapper;
        private readonly IProjectService _projectService;

        public ProjectController (IProjectService projectService,
            IMapper mapper) {
            _projectService = projectService;
            _mapper = mapper;
        }

        // GET: api/Project
        [HttpGet()]
        public async Task<IEnumerable<ViewProjectDto>> GetAllProject ([FromQuery] Filter filter) {

            var ListProject = await _projectService.GetAllProjectAsync(filter);
            return _mapper.Map<IEnumerable<Project>, IEnumerable<ViewProjectDto>>(ListProject);
        }

        // GET: api/Project/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById ([FromRoute] decimal id) {
            var getProject = await _projectService.GetWithEmployeeAsync(id);
            if (getProject == null) {
                throw new NotFoundException("Can't find the project", typeof(Project).Name);
            }
            else {
                return Ok(_mapper.Map<Project, ViewProjectDto>(getProject));
            }
        }

        // PUT: api/Project/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject ([FromBody] ViewProjectDto projectDTO) {
            if (ModelState.IsValid) {

                var project = await _projectService.GetAsync(projectDTO.Id);
                if (project == null) {
                    throw new NotFoundException("Record has been removed from database");
                }
                else {
                    var result = await _projectService.UpdateProject(projectDTO);
                    return Ok(result);
                }
            }
            else {
                return BadRequest();
            }
        }

        // POST: api/Project
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> AddProject ([FromBody] AddProjectDto projectDTO) {
            if (ModelState.IsValid) {
                var result = await _projectService.AddProject(projectDTO);
                _mapper.Map<AddProjectDto>(result);
                return Ok();
            }
            else {
                return BadRequest();
            }
        }

        // DELETE: api/Project
        [HttpDelete]
        [ValidateModel]
        public async Task<IActionResult> DeleteProject ([FromBody] DeleteProjectDto deleteProjectDto) {
            if (ModelState.IsValid) { 
                await _projectService.Delete(deleteProjectDto);
                return Ok();
            }
            else {
                return BadRequest();
            }
        }

    }
}
