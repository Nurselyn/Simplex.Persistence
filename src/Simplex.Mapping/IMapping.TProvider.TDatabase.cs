using System;
using Simplex.Database;

namespace Simplex.Mapping
{
    public interface IMapping<TProvider, TDatabase>
        where TProvider : IMappingProvider<TDatabase>
        where TDatabase : IDatabase
    {
        void Map(TProvider provider);
    }
}