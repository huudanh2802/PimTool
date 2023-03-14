using System.ComponentModel.DataAnnotations;

namespace Pim_Tool.Dtos {
    public class DeleteProjectDto {
        [Required]
        public decimal[] Ids { get; set; }
    }
}
