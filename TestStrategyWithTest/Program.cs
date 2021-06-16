using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStrategyWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work;

            string footWork = work.DoWork(new FootWork());

            Console.WriteLine(footWork);

            string handJob = work.DoWork(new HandWork());

            Console.WriteLine(handJob);

            Console.ReadKey();
        }
    }
}
