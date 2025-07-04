using Domain.Contracts;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly AppDbContext _dbContext;
        public GenericRepository(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
      

        public async Task AddAsync(TEntity entity) => _dbContext.Set<TEntity>().AddAsync(entity);

        public void Delete(TEntity entity) => _dbContext.Set<TEntity>().Remove(entity);


        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbContext.Set<TEntity>().ToListAsync();


        public async Task<TEntity?> GetByIdAsync(TKey id) => await _dbContext.Set<TEntity>().FindAsync(id);


        public void Update(TEntity entity) => _dbContext.Set<TEntity>().Update(entity);

    }
}
