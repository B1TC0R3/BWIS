using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Contracts
{
    public interface IStorage
    {
        void Add(IStorageContainer item, string directory);

        void Remove(int id);

        void Remove(IStorageContainer item);

        void Remove(string name);

        void Replace(int id, IStorageContainer newItem);

        void Replace(string name, IStorageContainer newItem);
    }
}
