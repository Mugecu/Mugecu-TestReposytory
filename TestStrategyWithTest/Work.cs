﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStrategyWithTest
{
    class Work
    {
        public string DoWork(IActionWork actWork)
        {
            return actWork.DoJob();
        }
    }
}
