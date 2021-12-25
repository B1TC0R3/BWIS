using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//TEST CLASS

namespace BWIS.Test.Store.Contracts
{
    public class IStorageTest
    {
        [Fact]
        public static void CanBeReferenced() 
        {
            //arrange
            IStorageTest? storage = null;

            //act

            //assert
            Assert.Null(storage);  
        }
    }
}
