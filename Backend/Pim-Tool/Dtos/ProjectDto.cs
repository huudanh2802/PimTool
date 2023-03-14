namespace Pim_Tool.Dtos {
    public interface ProjectDto {
        public decimal ProjectNumber { get; }
        public decimal GroupId { get; set; }
        public string[]? Visas { get; set; }

    }
}
