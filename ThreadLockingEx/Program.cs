using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLockingEx
{
    internal class Program
    {
        public  void Display()
        {
            lock (this)
            {
                Console.Write("Hello");
                Thread.Sleep(5000);
                Console.WriteLine("World!!");
            }
            
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

         Thread t1=new Thread(obj.Display);
         Thread t2 = new Thread(obj.Display);
            t1.Start();t2.Start();
            
        }
    }
}
