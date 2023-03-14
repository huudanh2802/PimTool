using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Pim_Tool.Enums.Enums;

namespace Pim_Tool.Dtos {
    public class AddProjectDto : IValidatableObject, ProjectDto {
        [NotMapped]
        private decimal? Id { get; set; }
        [Required]
        public decimal ProjectNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer length can't be more than 50.")]
        public string Customer { get; set; }
        [Required]
        [EnumDataType(typeof(ProjectStatus), ErrorMessage = "Status can only be " + nameof(ProjectStatus.NEW) + " " + nameof(ProjectStatus.PLA) + "," + nameof(ProjectStatus.INP) + " " + nameof(ProjectStatus.FIN))]
        [DefaultValue(nameof(ProjectStatus.NEW))]
        public string Status { get; set; } = nameof(ProjectStatus.NEW);
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        [Required]
        public decimal GroupId { get; set; }
        [NotMapped]
        public string[]? Visas { get; set; }

        public IEnumerable<ValidationResult> Validate (ValidationContext validationContext) {
            if (EndDate < StartDate) {
                yield return new ValidationResult(
                    "End Date must be after Create Date"
                     );
            }
        }
    }
}
