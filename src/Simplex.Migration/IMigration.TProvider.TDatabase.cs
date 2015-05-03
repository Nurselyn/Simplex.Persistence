using System;
using Simplex.Database;

namespace Simplex.Migration
{
    public interface IMigration<TProvider, TDatabase>
        where TProvider : IMigrationProvider<TDatabase>
        where TDatabase : IDatabase
    {
        void Migrate(TProvider provider);
    }
}