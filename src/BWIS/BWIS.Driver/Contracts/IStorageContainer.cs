using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Contracts
{
    public interface IStorageContainer
    {
        string Name { get; set; }
        string Description { get; set; }
        string Storage { get; set; }
        string Unit { get; set; }
        string Id { get; }
        int Ammount { get; set; }
        int AmmountToReorder { get; set; }
        DateTime ExpirationDate { get; set; }
        double Price { get; set; }
        double CombinedValue { get; }

        void Add(IStorageContainer item);

        IStorageContainer Get(int id);
        IStorageContainer Get(string name);

    }
}
