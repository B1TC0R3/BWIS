using BWIS.Store.Contracts;
using BWIS.Store.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic
{
    public static class StorageItemTest
    {
        public static class Add 
        {
            [Fact]
            public static void IsImplementedWithId() 
            {
                //arrange
                IStorageItem item = new StorageItem();

                //act
                var exception = Record.Exception(() => 
                {
                    item.Add(new StorageItem());
                });

                //assert
                Assert.Null(exception);
            }
        }
    }
}
