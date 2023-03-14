namespace PIMToolCodeBase.Domain.Entities {
    public class Project_Employee : BaseEntity {
        public decimal ProjectId { get; set; }
        public decimal EmployeeId { get; set; }
        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
