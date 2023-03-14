using System;
using System.Collections.Generic;
using static Pim_Tool.Enums.Enums;

namespace PIMToolCodeBase.Domain.Entities {
    public class Project : BaseEntity {
        public decimal ProjectNumber { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public ProjectStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal GroupId { get; set; }

        public Group Group { get; set; }
        public ICollection<Project_Employee>? ProjectEmployees { get; set; } = new HashSet<Project_Employee>();
    }
}
