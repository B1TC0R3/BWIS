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
                    storage.Add(new Cabinet(), "");
                });

                //assert
                Assert.IsNotType<NotImplementedException>(exception);
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
