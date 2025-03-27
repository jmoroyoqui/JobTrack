
namespace JobTracker.API.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        protected readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context; 
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
