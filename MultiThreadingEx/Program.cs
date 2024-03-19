using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace MultiThreadingEx
{
    internal class Program
    {
        // Multi-Threading:
        // Process: Multi Threading
        //-Time sharing
        //-Advantage of using maximum of CPU Resources

        static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("From Test1 : " + i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("From Test2 : "+i);
                if (i == 50)
                {
                    Console.WriteLine("Program will sleep for 5 seconds..");

                    Thread.Sleep(10000);

                    Console.WriteLine("Program woke up..");

                }
            }
        }
        static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("From Test3 : " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start(); t2.Start(); t3.Start();
        }
    }
}
