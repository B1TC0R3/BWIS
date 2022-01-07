using BWIS.Store.Contracts;
using BWIS.Store.Logic;
using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//Notice:
//Using objects of type "Cabinet" because "StorageContainer"
//is abstract and could not be tested otherwise

namespace BWIS.Test.Store.Logic
{
    public static class StorageContainerTest
    {
        [Fact]
        public static void IsImplemented() 
        {
            //arrange
            IStorageContainer item;

            //act
            var exception = Record.Exception(() => 
            {
                item = new Cabinet();
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
                IStorageContainer item = new Cabinet();


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
                IStorageContainer item = new Cabinet
                {
                    Price = 2.50,
                    Ammount = 3
                };

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
                IStorageContainer item = new Cabinet
                {
                    Price = 2.50,
                    Ammount = 0
                };

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
                IStorageContainer item = new Cabinet
                {
                    Price = 0,
                    Ammount = 3
                };

                double expectation = 0.0;

                //act
                double result = item.CombinedValue;

                //assert
                Assert.Equal(expectation, result);
            }
        }

        public static class Name 
        {
            [Fact]
            public static void IsImplemented()
            {
                //arrange
                IStorageContainer item = new Cabinet();


                //act
                var exception = Record.Exception(() =>
                {
                    item.Name = "Cabinet A";
                    string name = item.Name;
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void ThrowsFormatException_WhenLengthLessThen3()
            {
                //arrange
                IStorageContainer item = new Cabinet();

                //act
                Action action = new (() =>
                {
                    item.Name = "A";
                });

                //assert
                Assert.Throws<FormatException>(action);
            }
        }

        public static class Storage
        {
            [Fact]
            public static void IsImplemented()
            {
                //arrange
                IStorageContainer item = new Cabinet();


                //act
                var exception = Record.Exception(() =>
                {
                    item.Storage = "Storage A";
                    string storage = item.Storage;
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void ThrowsFormatException_WhenLengthLessThen3()
            {
                //arrange
                IStorageContainer item = new Cabinet();

                //act
                Action action = new(() =>
                {
                    item.Storage = "A";
                });

                //assert
                Assert.Throws<FormatException>(action);
            }
        }
    }
}
