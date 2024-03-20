using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main started..");
            Method1();
            Console.WriteLine("Main ended..");
            Console.ReadKey();
        }
        public static async  void Method1()
        {
            Console.WriteLine("Method1 started..");
            //Thread.Sleep(5000);
            // await Task.Delay(TimeSpan.FromSeconds(5));
           await method2();
            Console.WriteLine("Method1 Ended..");
        }
        public static async Task method2()
        {
            Console.WriteLine("method2 started");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Method2 ended");
        }
    }
}
