﻿using BWIS.Store.Contracts;
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
        public int Id { get; set; }
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