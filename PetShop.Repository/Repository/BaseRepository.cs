using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Base;
using PetShop.Repository.Context;

namespace PetShop.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
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
            _mysqlContext.Entry(entity).State = EntityState.Modified;
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

            // ✅ CORREÇÃO: Usar reflexão para acessar a propriedade Id
            return query.AsEnumerable()
                .FirstOrDefault(e =>
                {
                    var idProperty = e.GetType().GetProperty("Id");
                    if (idProperty == null) return false;
                    var entityId = idProperty.GetValue(e);
                    return entityId != null && entityId.Equals(id);
                });
        }
    }
}