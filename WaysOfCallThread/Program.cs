using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading;
using System.Threading.Tasks;

namespace WaysOfCallThread
{
    internal class Program
    {
        //static void Test()
        //{
        //    for(int i=1;i<=100;i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //  ThreadStart obj = delegate { Test(); };
            //ThreadStart obj = () => Test();

            ParameterizedThreadStart obj=new ParameterizedThreadStart(Test);
            Thread t1 = new Thread(obj);
            t1.Start(50);

        }
    }
}
