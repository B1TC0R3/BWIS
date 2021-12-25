using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//TEST CLASS

namespace BWIS.Test.Store.Contracts
{
    public class IStorage
    {
        [Fact]
        public static void CanBeReferenced() 
        {
            //arrange
            IStorage? storage = null;

            //act

            //assert
            Assert.Null(storage);  
        }
    }
}
