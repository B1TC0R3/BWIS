using BWIS.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic
{
    public abstract class StorageContainer : IStorageContainer
    {
        internal List<IStorageContainer> StorageElements { get; set; }
        
        private string _name;
        public string Name 
        {
            get => _name;
            set 
            {
                if (value.Length < 3)
                    throw new FormatException("The name of an item must at least be 3 characters long.");

                _name = value;
            }
        }
        
        private string _storage;
        public string Storage 
        {
            get => _storage;
            set
            {
                if (value.Length < 3)
                    throw new FormatException("The storage name of an item must at least be 3 characters long.");

                _storage = value;
            }
        }

        public string Description { get; set; }
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

        public abstract void Add(IStorageContainer item);

        public abstract IStorageContainer Get(int id);

        public abstract IStorageContainer Get(string name);
    }
}
