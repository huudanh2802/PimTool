using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using static Pim_Tool.Enums.Enums;

namespace Pim_Tool.Dtos {
    [DataContract]
    public class ViewProjectDto : ProjectDto {
        [Key]
        public decimal Id { get; set; }
        [DataMember]
        [ReadOnly(true)]
        public decimal ProjectNumber { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        [DataMember]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Customer length can't be more than 50.")]
        [DataMember]
        public string Customer { get; set; }
        [Required]
        [EnumDataType(typeof(ProjectStatus), ErrorMessage = "Status can only be " + nameof(ProjectStatus.NEW) + " " + nameof(ProjectStatus.PLA) + "," + nameof(ProjectStatus.INP) + " " + nameof(ProjectStatus.FIN))]
        [DefaultValue(nameof(ProjectStatus.NEW))]
        public string Status { get; set; }
        [Required]
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime? EndDate { get; set; }
        [Required]
        [DataMember]
        public decimal GroupId { get; set; }
        [DataMember]
        public string[]? Visas { get; set; }
        [ConcurrencyCheck]
        [ReadOnly(true)]
        public decimal Version { get; set; }

        public IEnumerable<ValidationResult> Validate (ValidationContext validationContext) {
            if (EndDate < StartDate) {
                yield return new ValidationResult(
                    "End Date must be after Create Date"
                     );
            }
        }

    }
}
