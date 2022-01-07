using BWIS.Store.Contracts;
using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic
{
    public class Storage : IStorage
    {
        private readonly List<IStorageContainer> cabinets;

        public string Name { get; set; }

        public Storage(string name = "Unnamed Storage") 
        {
            Name = name;
            cabinets = new List<IStorageContainer>();
        }

        public void Add(string name = "-Unnamed-",
                        string description = "-/-",
                        string storage = "-/-",
                        string unit = "-/-",
                        int ammount = 0,
                        int ammountToReorder = 0,
                        DateTime expirationDate = new DateTime(),
                        double price = 0.0)
        {
            #region NULL-Check
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException($"'{nameof(description)}' cannot be null or empty.", nameof(description));
            }

            if (string.IsNullOrEmpty(storage))
            {
                throw new ArgumentException($"'{nameof(storage)}' cannot be null or empty.", nameof(storage));
            }

            if (string.IsNullOrEmpty(unit))
            {
                throw new ArgumentException($"'{nameof(unit)}' cannot be null or empty.", nameof(unit));
            }
            #endregion

            Cabinet cabinet = new Cabinet(name,
                                          description,
                                          storage,
                                          unit,
                                          ammount,
                                          ammountToReorder,
                                          expirationDate);
            cabinets.Add(cabinet);
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IStorageContainer item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string name)
        {
            throw new NotImplementedException();
        }

        public void Replace(int id, IStorageContainer newItem)
        {
            throw new NotImplementedException();
        }

        public void Replace(string name, IStorageContainer newItem)
        {
            throw new NotImplementedException();
        }
    }
}
