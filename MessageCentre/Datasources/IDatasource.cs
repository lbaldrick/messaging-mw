using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageCentre.Datasources
{
    public interface IDatasource<T>
    {
        void Insert(T t);
        void Update(string id, T t);
        void Delete(string id);
        T Retrieve(string id);
    }
}
