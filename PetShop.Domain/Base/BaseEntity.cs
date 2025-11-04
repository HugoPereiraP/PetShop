

using PetShop.Domain.Base;

namespace PetShot.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        public BaseEntity()
        {

        }
        public TId Id { get; private set; }

        public BaseEntity(TId id) => Id = id;


    }
}