using Microsoft.AspNetCore.Mvc;

namespace PIMToolCodeBase.Domain.Objects {
    /// <summary>
    ///     The filter of query
    /// </summary>
    public class Filter {
        [FromQuery(Name = "Name")]
        public string? Name { get; set; }
        [FromQuery(Name = "Number")]
        public decimal? Number { get; set; }
        [FromQuery(Name = "Customer")]
        public string? Customer { get; set; }
        [FromQuery(Name = "Status")]
        public string? Status { get; set; }
    }
}