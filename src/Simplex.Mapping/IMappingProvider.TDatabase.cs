using System;
using Simplex.Database;

namespace Simplex.Mapping
{
    public interface IMappingProvider<TDatabase>
        where TDatabase : IDatabase
    {
    }
}
