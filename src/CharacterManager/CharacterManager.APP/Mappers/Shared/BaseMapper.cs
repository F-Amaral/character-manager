using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterManager.APP.Mappers.Shared
{

    public abstract class BaseMapper<TEntry, TResponse>
         where TEntry : class
         where TResponse : class
    {
        public abstract TResponse Map(TEntry entry);

        public virtual IEnumerable<TResponse> Map(IEnumerable<TEntry> entries)
        {
            foreach (var entry in entries ?? new List<TEntry>())
                yield return Map(entry);
        }
    }
}
