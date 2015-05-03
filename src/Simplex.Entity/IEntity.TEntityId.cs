using System;

namespace Simplex.Entity
{
    public interface IEntity<TEntityId>
    {
        TEntityId Id { get; set; }
    }
}
