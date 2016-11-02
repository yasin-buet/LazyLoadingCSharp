using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            //Console.WriteLine("Press 1 for even numbers \n " +
            //                  "Press 2 for fibonacci numbers \n +" +
            //                  "Press 3 for prime nimbers \n ");
            //int optionSelected = Console.Read();

            IList<long> even = new List<long>(ListGenerator.EvenNumbers(0, 10));
            IList<long> fib = new List<long>(ListGenerator.Fibonaccinumbers(10));
            IList<long> prime = new List<long>(ListGenerator.PrimeNumbers(10));
            watch.Stop();
            Console.WriteLine("Time took for execution {0}",  watch.Elapsed);
            Console.ReadKey();
        }
    }
}
