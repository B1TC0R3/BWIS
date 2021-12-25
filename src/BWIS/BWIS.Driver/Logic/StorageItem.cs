using BWIS.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic
{
    public class StorageItem : IStorageItem
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Storage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Unit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ammount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AmmountToReorder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ExpirationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CombinedValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(IStorageItem item)
        {
            throw new NotImplementedException();
        }
    }
}
