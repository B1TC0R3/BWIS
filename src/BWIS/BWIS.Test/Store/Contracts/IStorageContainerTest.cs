using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Store.Contracts
{
    public class IStorageContainerTest
    {
        [Fact]
        public static void CanBeReferenced()
        {
            //arrange
            IStorageContainerTest? storage = null;

            //act

            //assert
            Assert.Null(storage);
        }
    }
}
