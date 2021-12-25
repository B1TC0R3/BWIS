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
    public static class StorageItemContainer
    {
        [Fact]
        public static void IsImplemented() 
        {
            //arrange
            IStorageContainer item;

            //act
            var exception = Record.Exception(() => 
            {
                item = new StorageContainer();
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
                IStorageContainer item = new StorageContainer();

                //act
                var exception = Record.Exception(() => 
                {
                    double combinedValue = item.CombinedValue;
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void GetsCorrectValue_WhenExpectedValuesAreSet()
            {
                //arrange
                IStorageContainer item = new StorageContainer();
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
                IStorageContainer item = new StorageContainer();
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
                IStorageContainer item = new StorageContainer();
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
                IStorageContainer item = new StorageContainer();

                //act
                var exception = Record.Exception(() => 
                {
                    item.Add(new StorageContainer());
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }
        }

        public static class Get 
        {
            [Fact]
            public static void IsImplementedWithId() 
            {
                //arrange
                IStorageContainer item = new StorageContainer();

                //act
                var exception = Record.Exception(() => 
                {
                    item.Get(0);
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void IsImplementedWithName()
            {
                //arrange
                IStorageContainer item = new StorageContainer();

                //act
                var exception = Record.Exception(() =>
                {
                    item.Get("");
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }
        }
    }
}
