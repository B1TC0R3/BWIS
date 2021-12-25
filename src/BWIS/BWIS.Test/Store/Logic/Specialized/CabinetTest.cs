using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic.Specialized
{
    public static class CabinetTest
    {
        [Fact]
        public static void IsImplemented()
        {
            //arrange
            Cabinet crate;

            //act
            var exception = Record.Exception(() =>
            {
                crate = new Cabinet();
            });

            //assert
            Assert.Null(exception);
        }
    }
}
