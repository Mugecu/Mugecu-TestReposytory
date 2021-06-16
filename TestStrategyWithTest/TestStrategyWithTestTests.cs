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
        public void IsNotEmptyInWorkClass()
        {
            Work work = new Work();

            string act = work.DoWork(new HandJob());

            Assert.IsNotEmpty(act);
        }
    }
}
