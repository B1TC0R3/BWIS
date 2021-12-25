using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic.Specialized
{
    public static class ItemTest
    {
        [Fact]
        public static void IsImplemented() 
        {
            //arrange
            Item item;

            //act
            var exception = Record.Exception(() => 
            {
                item = new Item();
            });

            //assert
            Assert.Null(exception);
        }
    }
}
