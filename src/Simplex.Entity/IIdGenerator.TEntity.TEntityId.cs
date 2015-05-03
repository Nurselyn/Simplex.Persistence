using System;

namespace Simplex.Entity
{
    public interface IIdGenerator<TEntity, TEntityId>
        where TEntity : IEntity<TEntityId>
    {
    }
}
