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
        [Fact]
        public static void IsImplemented() 
        {
            //arrange
            IStorageItem item;

            //act
            var exception = Record.Exception(() => 
            {
                item = new StorageItem();
            });

            //assert
            Assert.Null(exception);
        }

        public static class CombinedValue 
        {
            [Fact]
            public static void IsImplemented() 
            {
                //arrange
                IStorageItem item = new StorageItem();

                //act
                var exception = Record.Exception(() => 
                {
                    double combinedValue = item.CombinedValue;
                });

                //assert
                Assert.Null(exception);
            }

            [Fact]
            public static void GetsCorrectValue_WhenExpectedValuesAreSet()
            {
                //arrange
                IStorageItem item = new StorageItem();
                item.Price = 2.50;
                item.Ammount = 3;

                double expectation = 7.50;

                //act
                double result = item.CombinedValue;

                //assert
                Assert.Equal(expectation, result);
            }

            [Fact]
            public static void GetsCorrectValue_WhenAmmountIsZero()
            {
                //arrange
                IStorageItem item = new StorageItem();
                item.Price = 2.50;
                item.Ammount = 0;

                double expectation = 0.0;

                //act
                double result = item.CombinedValue;

                //assert
                Assert.Equal(expectation, result);
            }

            [Fact]
            public static void GetsCorrectValue_WhenPriceIsZero()
            {
                //arrange
                IStorageItem item = new StorageItem();
                item.Price = 0;
                item.Ammount = 3;

                double expectation = 0.0;

                //act
                double result = item.CombinedValue;

                //assert
                Assert.Equal(expectation, result);
            }
        }
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
