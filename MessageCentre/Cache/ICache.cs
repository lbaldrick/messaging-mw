using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageCentre.Cache
{
    public interface ICache<T, K>
    {
        T GetEntry(K key);
        void InsertEntry(T entry);
        int Count();
        bool DeleteEntry(K key);
    }
}
