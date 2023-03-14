using System.Collections.Generic;

namespace PIMToolCodeBase.Domain.Entities {
    public class Group : BaseEntity {
        public decimal GroupLeaderId { get; set; }
        public Employee GroupLeader { get; set; }
        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}
