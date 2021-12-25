using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Storage.Contracts
{
    public interface IStorage
    {
        void Add(IStorageItem item);

        void Remove(int id);

        void Remove(IStorageItem item);

        void Remove(string name);

        void Replace(int id, IStorageItem newItem);

        void Replace(string name, IStorageItem newItem);
    }
}
