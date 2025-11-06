

namespace PetShop.Domain.Base
{
    public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
    {
        void CleanChangeTracker();
        void AttachObject(object obj);

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        IList<TEntity> Select(IList<string>? includes = null);
        TEntity? SelectById<TId>(TId id, IList<string>? includes = null);
    }
}
