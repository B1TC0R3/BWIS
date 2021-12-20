using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BWIS.Test.Storage.Contracts
{
    public class IStorageItem
    {
        [Fact]
        public static void CanBeReferenced()
        {
            //arrange
            IStorageItem? storage = null;

            //act

            //assert
            Assert.Null(storage);
        }
    }
}
