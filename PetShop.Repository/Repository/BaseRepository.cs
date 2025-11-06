using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Base;




namespace PetShop.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly PetShopContext _mysqlContext;

        public BaseRepository(PetShopContext mysqlContext)
        {
            _mysqlContext = mysqlContext;
        }

        public void CleanChangeTracker()
        {
            _mysqlContext.ChangeTracker.Clear();
        }

        public void AttachObject(object obj)
        {
            _mysqlContext.Attach(obj);
        }

        public void Insert(TEntity entity)
        {
            _mysqlContext.Set<TEntity>().Add(entity);
            _mysqlContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _mysqlContext.Set<TEntity>().Update(entity);
            _mysqlContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _mysqlContext.Set<TEntity>().Remove(entity);
            _mysqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            IQueryable<TEntity> query = _mysqlContext.Set<TEntity>();

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query.ToList();
        }

        public TEntity? SelectById<TId>(TId id, IList<string>? includes = null)
        {
            IQueryable<TEntity> query = _mysqlContext.Set<TEntity>();

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query.FirstOrDefault(e => e.Id!.Equals(id));
        }
    }
}
