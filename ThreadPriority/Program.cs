using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
   
    internal class Program
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
                count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)
                count2 += 1;
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(IncrementCount1);
            Thread t2=new Thread(IncrementCount2);

            t1.Priority = System.Threading.ThreadPriority.Lowest;
            t2.Priority= System.Threading.ThreadPriority.Highest;

            t1.Start();t2.Start();

            
            Console.WriteLine("Main Sleep..");
            Thread.Sleep(10000);
            Console.WriteLine("Woke up");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine(count1);
            Console.WriteLine(count2);
        }
    }
}
