using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forOrForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to continue testing!");
            do
            {
                TestEfficiency();
                Console.WriteLine("-------------------------------------------");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        static void TestEfficiency()
        {
            const int COUNT = 100000000;
            Stopwatch sw = new Stopwatch();
            //改集合类型 ToList()
            var list = Enumerable.Range(1, COUNT).ToArray();
            int temp = 0;
            sw.Start();
            for (int i = 0; i < COUNT; ++i) temp = 0 - list[i];
            sw.Stop();
            Console.WriteLine("for circulate elapsed time:{0}", sw.ElapsedMilliseconds);
            temp = 0;
            sw.Restart();
            foreach (var i in list) temp = 0 - i;
            Console.WriteLine("foreach circulate elapsed time:{0}", sw.ElapsedMilliseconds);
        }
    }
}
