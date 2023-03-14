using Microsoft.EntityFrameworkCore;
using PIMToolCodeBase.Database;
using PIMToolCodeBase.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIMToolCodeBase.Repositories.Imp {
    /// <summary>
    ///     Base of all repositories
    /// </summary>
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity {
        private readonly PimContext _pimContext;
        protected readonly DbSet<T> Set;

        protected BaseRepository (PimContext pimContext) {
            _pimContext = pimContext;
            Set = _pimContext.Set<T>();
        }

        public IEnumerable<T> Get () {
            return Set.AsNoTracking();
        }

        public T Get (decimal id) {
            return Set.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public void Add (params T[] entities) {
            Set.AddRange(entities);
        }

        public void Delete (params decimal[] ids) {
            Set.RemoveRange(Set.AsNoTracking().Where(x => ids.Contains(x.Id)));
        }

        public void Delete (params T[] entities) {
            Set.RemoveRange(entities);
        }

        public Task<T> GetAsync (decimal id) {
            return Set.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }
        public void SaveChange () {
            _pimContext.SaveChanges();
        }
        public void Update (params T[] entities) {
            Set.UpdateRange(entities);
        }

        public Task<bool> AnyAsync (decimal id) {
            return Set.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAllAsync () {
            return await Set.AsNoTracking().ToListAsync();
        }
    }
}