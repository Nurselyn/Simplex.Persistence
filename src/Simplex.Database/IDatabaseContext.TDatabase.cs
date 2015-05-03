using System;
using Simplex.Entity;
using Simplex.Transaction;

namespace Simplex.Database
{
    public interface IDatabaseContext<TDatabase>
        where TDatabase : IDatabase
    {
        ITransaction StartTransaction();

        void RollBackTransaction();

        ICrudService<TEntity> GetEntityCrudService<TEntity>();

        ICrudService<TEntity, TEntityId> GetEntityCrudService<TEntity, TEntityId>()
            where TEntity : class, IEntity<TEntityId>;

        IIdGenerator<TEntity, TEntityId> GetEntityIdGenerator<TEntity, TEntityId>()
            where TEntity : class, IEntity<TEntityId>;
    }
}
