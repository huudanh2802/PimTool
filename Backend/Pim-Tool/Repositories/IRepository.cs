using PIMToolCodeBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PIMToolCodeBase.Repositories {
    public interface IRepository<T> where T : BaseEntity {
        /// <summary>
        ///     Get all entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get ();

        /// <summary>
        ///     Get specific entity by identifier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get (decimal id);

        /// <summary>
        ///     Add entity to set
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        void Add (params T[] entities);
        /// <summary>
        ///     Update entity to set
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        void Update (params T[] entities);
        /// <summary>
        ///     Delete entities by its ids
        /// </summary>
        /// <param name="ids"></param>
        void Delete (params decimal[] ids);

        /// <summary>
        ///     Delete entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete (params T[] entities);
        /// <summary>
        ///     Get all entities async with id
        /// </summary>
        /// <returns></returns>

        Task<T> GetAsync (decimal id);

        /// <summary>
        ///     Verify specific entity with condition in database async
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> AnyAsync (decimal id);
        /// <summary>
        ///     Get all entities async
        /// </summary>
        /// <returns></returns>

        Task<IEnumerable<T>> GetAllAsync ();

        /// <summary>
        ///     Save context to database
        /// </summary>
        /// 
        void SaveChange ();

    }
}