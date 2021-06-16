using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStrategyWithTest
{
    class Work
    {
        public string DoWork(IActioWork actWork)
        {
            return actWork.DoJob();
        }
    }
}
