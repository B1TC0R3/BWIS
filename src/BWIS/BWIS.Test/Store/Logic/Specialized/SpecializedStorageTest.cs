using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic.Specialized
{
    public static class SpecializedStorageTest
    {
        [Fact]
        public static void IsImplemented() 
        {
            //arrange
            SpecializedStorage specStorage;

            //act
            var exception = Record.Exception(() => 
            {
                specStorage = new SpecializedStorage();
            });

            //assert
            Assert.Null(exception);
        }
    }
}
