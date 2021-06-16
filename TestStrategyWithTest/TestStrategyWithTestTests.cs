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
        public void IsNotEmptyInHandWorkClass ()
        {
            Work work = new Work();

            string act = work.DoWork(new HandWork());

            Assert.IsNotEmpty(act);
        }
        [Test]
        public void IsNotEmptyInFootWorkClass()
        {
            Work work = new Work();

            string act = work.DoWork(new FootWork());

            Assert.IsNotEmpty(act);
        }
    }
}
