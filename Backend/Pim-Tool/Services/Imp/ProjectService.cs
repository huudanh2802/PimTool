using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pim_Tool.Dtos;
using Pim_Tool.Exceptions;
using Pim_Tool.Repositories;
using PIMToolCodeBase.Domain.Entities;
using PIMToolCodeBase.Domain.Objects;
using PIMToolCodeBase.Services;
using PIMToolCodeBase.Services.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Pim_Tool.Enums.Enums;

namespace Pim_Tool.Services.Imp {
    public class ProjectService : BaseService, IProjectService {
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectEmployeeRepository _projectEmployeeRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly IMapper _mapper;

        public ProjectService (IProjectRepository projectRepository
            , IGroupRepository groupRepository
            , IEmployeeRepository employeeRepository
            , IProjectEmployeeRepository projectEmployeeRepository
            , IMapper mapper) {

            _projectRepository = projectRepository;
            _groupRepository = groupRepository;
            _projectEmployeeRepository = projectEmployeeRepository;
            _employeeRepository = employeeRepository;

            _mapper = mapper;

        }

        public Task<IEnumerable<Project>> GetAllProjectAsync (Filter filter) {
            return _projectRepository.GetAllWithEmployeesAsync(filter);
        }

        public Task<Project> GetAsync (decimal id) {
            return _projectRepository.GetAsync(id);
        }

        public Task<Project> GetWithEmployeeAsync (decimal id) {
            return _projectRepository.GetWithEmployeeAsync(id);

        }
        public async Task<Project> AddProject (AddProjectDto projectDto) {
            var project = _mapper.Map<Project>(projectDto);
            await ValidateDtoField(projectDto);

            if (await _projectRepository.AnyAsync(projectDto.ProjectNumber)) {
                throw new BadRequestException($"ProjectNumber already existed", nameof(projectDto.ProjectNumber));
            }
            _projectRepository.Add(project);
            if (projectDto.Visas!=null) {
                var employeeIds = await _employeeRepository.GetAllEmployeesIdsByVisaAsync(projectDto.Visas);
                var ListProjectEmployess = employeeIds.Select(employeeId =>
                    new Project_Employee { Project = project, EmployeeId = employeeId }
                );

                _projectEmployeeRepository.Add(ListProjectEmployess.ToArray());
            }
            _projectEmployeeRepository.SaveChange();
            return _projectRepository.Get().LastOrDefault();
        }

        public async Task ValidateDtoField (ProjectDto projectDto) {
            // Check Group
            if (await _groupRepository.AnyAsync(projectDto.GroupId) != true) {
                throw new BadRequestException($"Can't find group {projectDto.GroupId}", nameof(projectDto.GroupId));
            }

            // Check Visas
            if (projectDto.Visas!=null) {
                var invalidVisas = new List<string>();
                foreach (var visa in projectDto.Visas) {
                    if (await _employeeRepository.AnyEmployeeByVisaAsync(visa) == false) {
                        invalidVisas.Add(visa);
                    }
                }
                if (invalidVisas.Any()) {
                    string visaList = string.Join(",", invalidVisas);
                    throw new BadRequestException($"The following visas do not exist: {visaList}.", nameof(projectDto.Visas));
                }
            }

        }

        public async Task<ViewProjectDto> UpdateProject (ViewProjectDto updatedProjectDto) {
            //Validate Fields
            await ValidateDtoField(updatedProjectDto);

            var project = await _projectRepository.GetWithEmployeeAsync(updatedProjectDto.Id);

            var oldProjectDto = _mapper.Map<ViewProjectDto>(project);
            //Check if ProjectNumber has been changed
            if (updatedProjectDto.ProjectNumber != oldProjectDto.ProjectNumber) {
                throw new BadRequestException("ProjectNumber cannot be changed",nameof(project.ProjectNumber));
            }
            //Modify ProjectEmployee Relationship
            //Clear all ProjectEmployees
            if (oldProjectDto.Visas!=null) {
                var oldEmployeeIds = await _employeeRepository.GetAllEmployeesIdsByVisaAsync(oldProjectDto.Visas);
                var oldProjectEmployee = oldEmployeeIds.Select(oldEmployeeId =>
                    new Project_Employee { ProjectId = project.Id, EmployeeId = oldEmployeeId }
                );
                project.ProjectEmployees.Clear();
                _projectEmployeeRepository.Delete(oldProjectEmployee.ToArray());
            }
            //Add the valid ProjectEmployees
            if (updatedProjectDto.Visas!=null) {
                var newEmployeeIds = await _employeeRepository.GetAllEmployeesIdsByVisaAsync(updatedProjectDto.Visas);
                var newProjectEmployee = newEmployeeIds.Select(newEmployeeId =>
                new Project_Employee { EmployeeId = newEmployeeId, ProjectId = project.Id }
                );
                _projectEmployeeRepository.Add(newProjectEmployee.ToArray());
            }
            //Update database
            project = _mapper.Map<Project>(updatedProjectDto);

            _projectRepository.Update(project);
            try {
                _projectRepository.SaveChange();
            }
            catch (DbUpdateConcurrencyException ex) {
                throw new ConflictException("Database has been updated, please check and update your Project again");
            }
            return updatedProjectDto;
        }

        public async Task Delete (DeleteProjectDto deleteProjectDto) {
            foreach (var id in deleteProjectDto.Ids) {
                var project = await GetAsync(id);
                // Project cannot be found
                if (project == null) {
                    throw new BadRequestException
                        ($"Selected projects cannot be deleted because they cannot be found {id}",nameof(project.GroupId));
                }
                else {
                    // Project status are not new
                    if (!project.Status.Equals(ProjectStatus.NEW)) {
                        throw new BadRequestException
                            ($"Selected projects cannot be deleted because their status are not {ProjectStatus.NEW}", nameof(project.GroupId));
                    }
                }
            }
            _projectEmployeeRepository.DeleteWithProjectId(deleteProjectDto.Ids);
            _projectRepository.Delete(deleteProjectDto.Ids);
            _projectRepository.SaveChange();
        }
        public Task<Project> GetProjectByProjectNumberAsync (decimal project_Number) {
            return _projectRepository.GetProjectByProjectNumberAsync(project_Number);
        }
    }
}
