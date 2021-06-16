using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStrategyWithTest
{
    class FootWork : IActionWork
    {
        public string DoJob()
        {
            return "Выполнился метод класса FootWork";
        }
    }
}
