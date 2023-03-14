namespace PIMToolCodeBase.Domain.Entities {
    /// <summary>
    ///     Base entity of all entities
    /// </summary>
    public abstract class BaseEntity {
        /// <summary>
        ///     Identifier of entity
        /// </summary>
        public decimal Id { get; set; }
        public decimal Version { get; set; }

    }
}