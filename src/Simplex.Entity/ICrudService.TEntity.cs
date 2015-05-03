using System;
using System.Linq;
using Simplex.Transaction;

namespace Simplex.Entity
{
    public interface ICrudService<TEntity>
    {
        TEntity Create();

        void Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IQueryable<TEntity> Query();

        ITransaction StartTransaction();

        void RollBackTransaction();
    }
}
