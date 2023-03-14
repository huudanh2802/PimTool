using AutoMapper;
using Pim_Tool.Dtos;
using PIMToolCodeBase.Domain.Entities;
using System.Linq;

namespace Pim_Tool.MappingProfiles {

    public class ProjectMappingProfile : Profile {
        public ProjectMappingProfile () : base(nameof(ProjectMappingProfile)) {

            CreateMap<AddProjectDto, Project>().ReverseMap()
                .ForMember(dto => dto.Visas,
                conf =>
                conf.MapFrom(p => p.ProjectEmployees.Select(pe => pe.Employee.Visa))
                ); ;

            CreateMap<ViewProjectDto, Project>().ReverseMap()
                .ForMember(dto => dto.Visas,
                conf =>
                conf.MapFrom(p => p.ProjectEmployees.Select(pe => pe.Employee.Visa))
                ); ;

            CreateMap<GroupDto, Group>().ReverseMap();
        }
    }
}
