using System;
using System.Collections.Generic;

namespace PIMToolCodeBase.Domain.Entities {
    public class Employee : BaseEntity {
        public string Visa { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Group? GroupLed { get; set; }
        public ICollection<Project_Employee>? ProjectEmployees { get; set; } = new HashSet<Project_Employee>();
    }
}