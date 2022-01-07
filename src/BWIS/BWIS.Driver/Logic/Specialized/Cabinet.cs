using BWIS.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic.Specialized
{
    public class Cabinet : StorageContainer
    {
        private new List<IStorageContainer> StorageElements;

        public Cabinet(string name = "-Unnamed-", 
                       string description = "-/-", 
                       string storage = "-/-", 
                       string unit = "-/-", 
                       int ammount = 0, 
                       int ammountToReorder = 0,
                       DateTime expirationDate = new DateTime(),
                       double price = 0.0) 
        {
            Name = name;
            Description = description;
            Storage = storage;
            Unit = unit;
            Ammount = ammount;
            AmmountToReorder = ammountToReorder;
            ExpirationDate = expirationDate;
            Price = price;

            StorageElements = new List<IStorageContainer>();
        }

        public override void Add(IStorageContainer item)
        {
            throw new NotImplementedException();
        }

        public override IStorageContainer Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IStorageContainer Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}
