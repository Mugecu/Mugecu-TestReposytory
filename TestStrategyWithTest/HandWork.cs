using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStrategyWithTest
{
    class HandWork : IActionWork
    {
        public string DoJob()
        {
            return "Выполнился метод из класса HandWork";
        }
    }
}
