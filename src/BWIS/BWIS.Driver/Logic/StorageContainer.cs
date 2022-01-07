using BWIS.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic
{
    public class StorageContainer : IStorageContainer
    {
        internal List<IStorageContainer> StorageElements { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Storage { get; set; }
        public string Unit { get; set; }
        public int Ammount { get; set; }
        public int AmmountToReorder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }
        public double CombinedValue 
        { 
            get 
            {
                double combinedValue = Price * Ammount;
                return Math.Round(combinedValue, 2);    
            }
        }

        public string Id 
        {
            get 
            {
                if (Name.Length > 3
                    && Storage.Length > 3)
                    return Name.Substring(0, 3) +
                           Storage.Substring(0, 3);
                throw new FormatException(message: "The length of either the name or storage of the item is too short");
            } 
        }

        public void Add(IStorageContainer item)
        {
            throw new NotImplementedException();
        }

        public IStorageContainer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IStorageContainer Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}
