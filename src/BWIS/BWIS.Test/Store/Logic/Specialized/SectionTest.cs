using BWIS.Store.Logic.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Logic.Specialized
{
    public class SectionTest
    {
        [Fact]
        public static void IsImplemented()
        {
            //arrange
            Section section;

            //act
            var exception = Record.Exception(() =>
            {
                section = new Section();
            });

            //assert
            Assert.Null(exception);
        }
    }
}
