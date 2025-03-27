namespace JobTracker.API.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
    }
}
