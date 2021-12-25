using BWIS.Store.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWIS.Store.Logic
{
    public class Storage : IStorage
    {
        public void Add(IStorageContainer item)
        {
            throw new NotImplementedException();
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
