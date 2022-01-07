using BWIS.Store.Contracts;
using BWIS.Store.Logic;
using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic
{
    public static class StorageTest
    {
        public static class Add 
        {
            [Fact]
            public static void IsImplemented() 
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() => 
                {
                    storage.Add();
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenNameIsNull()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new (() =>
                {
                    storage.Add(name: null);
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenNameIsEmpty()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(name: "");
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenDescriptionIsNull()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(description: null);
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenDescriptionIsEmpty()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(description: "");
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenStorageIsNull()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(storage: null);
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenStorageIsEmpty()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(storage: "");
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenUnitIsNull()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(unit: null);
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }

            [Fact]
            public static void ThrowsArgumentException_WhenUnitIsEmpty()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                Action action = new(() =>
                {
                    storage.Add(unit: "");
                });

                //assert
                Assert.Throws<ArgumentException>(action);
            }
        }

        public static class Remove 
        {
            [Fact]
            public static void IsImplementedWithId()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() => 
                {
                    storage.Remove(0);
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void IsImplementedWithName()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() =>
                {
                    storage.Remove("");
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void IsImplementedWithItem()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() =>
                {
                    storage.Remove(new Cabinet());
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }
        }

        public static class Replace 
        {
            [Fact]
            public static void IsImplementedWithId()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() =>
                {
                    storage.Replace(0, new Cabinet());
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }

            [Fact]
            public static void IsImplementedWithItem()
            {
                //arrange
                IStorage storage = new Storage();

                //act
                var exception = Record.Exception(() =>
                {
                    storage.Replace("", new Cabinet());
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
            }
        }
    }
}
