using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("Press 1 to start stopwatch and 2 to stop it.");
            var input = Convert.ToInt16(Console.ReadLine());
            
                if (input == 1)
                    stopwatch.Start();

                if (input != 2) continue;
                stopwatch.Stop();
                Console.WriteLine("Duration:" + stopwatch.GetInterval());
            }
            
        }
    }
}
