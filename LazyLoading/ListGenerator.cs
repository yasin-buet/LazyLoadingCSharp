using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class ListGenerator:IList
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsReadOnly { get; }
        public bool IsFixedSize { get; }

        public static List<long> Fibonaccinumbers(int howMany)
        {
            List<long> fibList = new List<long>();
            int num_1 = 0;
            int num_2 = 1;
            int sum = 1;
            int addedNumberCount = 1;
            Console.WriteLine(num_1);
            fibList.Add(num_1);
            
            while (addedNumberCount < howMany)
            {
                Console.WriteLine(num_2);
                fibList.Add(num_2);
                addedNumberCount++;
                sum = num_1 + num_2;
                num_1 = num_2;
                num_2 = sum;

            }
            return fibList;
            // throw new NotImplementedException();
        }

        public static List<long> EvenNumbers( int start , int end)
        {
            List<long> evnNumberList = new List<long>();
            int i = 0;
            for (i = 0; i < end; i++)
            {
                if (i%2 == 0)
                {
                    evnNumberList.Add(i);
                    //Console.WriteLine("list of Even Numbers printing ");
                    //Console.WriteLine(evnNumberList);
                }
            }
            foreach (var l in evnNumberList)
            {
                    Console.WriteLine(l);
            }
            //Console.WriteLine();
            return evnNumberList;
        }

        public static List<long> PrimeNumbers( int howMany)
        {
            List<long> primeList = new List<long>();
            bool isPrime = true;
           // long uptoNumber = 50;
            int i = 0;
            int j = 0;
            int addedNumberCount = 0;
            while (addedNumberCount< howMany)
            {
                for (j= 2; j < Math.Sqrt(addedNumberCount); j++)
                {
                    if (i% j  == 0)
                    {
                        isPrime = false;
                        j++;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(addedNumberCount);
                   // var i1 = addedNumberCount++;
                    //Console.WriteLine(primeList.ToString());
                    //Console.ReadKey();

                }
                addedNumberCount++;
            }

            foreach (var prm in primeList)
            {
                Console.WriteLine(prm);
            }

            Console.WriteLine("\n");
            return primeList;
            //throw new NotImplementedException();
        }

        public void ShowList(List<long> toBePrinted)
        {
            foreach (var tbp in toBePrinted)
            {
                Console.WriteLine(toBePrinted);
            }
            
        }
    }
}
