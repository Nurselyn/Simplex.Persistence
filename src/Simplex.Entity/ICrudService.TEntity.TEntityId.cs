using System;

namespace Simplex.Entity
{
    public interface ICrudService<TEntity, TEntityId>: ICrudService<TEntity>
        where TEntity : IEntity<TEntityId>
    {
        TEntity Create(TEntityId entityId);

        TEntity Get(TEntityId entityId);

        TEntity Load(TEntityId entityId);

        void Delete(TEntityId entityId);
    }
}
