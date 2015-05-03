using System;

namespace Simplex.Database
{
    public interface IDatabaseProvider<TContext, TDatabase>
        where TContext : IDatabaseContext<TDatabase>
        where TDatabase : IDatabase
    {
        TDatabase Database { get; }
    }
}
