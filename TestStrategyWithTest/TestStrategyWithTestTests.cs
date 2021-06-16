using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TestStrategyWithTest
{
    [TestFixture]
    class TestStrategyWithTestTests
    {
        [Test]
        public void EmptyArgymentInReadClass()
        {
            User user = new User();

            Read read = new Read();

            string name = read.DoRead(user.name);
            
            Assert()
        }
    }
}
