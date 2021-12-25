using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Contracts
{
    public interface IStorageItem
    {
        string Name { get; set; }
        string Description { get; set; }
        string Storage { get; set; }
        string Unit { get; set; }
        int Id { get; set; }
        int Ammount { get; set; }
        int AmmountToReorder { get; set; }
        DateTime ExpirationDate { get; set; }
        double Price { get; set; }
        double CombinedValue { get; }

        void Add(IStorageItem item);
    }
}
