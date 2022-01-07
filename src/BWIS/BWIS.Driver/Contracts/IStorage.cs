using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Contracts
{
    public interface IStorage
    {
        void Add(string name = "-Unnamed-",
                 string description = "-/-",
                 string storage = "-/-",
                 string unit = "-/-",
                 int ammount = 0,
                 int ammountToReorder = 0,
                 DateTime expirationDate = new DateTime(),
                 double price = 0.0);

        void Remove(int id);

        void Remove(IStorageContainer item);

        void Remove(string name);

        void Replace(int id, IStorageContainer newItem);

        void Replace(string name, IStorageContainer newItem);
    }
}
