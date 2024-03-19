using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace ThreadingsEx
{
    internal class Program
    {
       // -Every application by default contains one thread to execute the program and that is known as 
       //   Main Threading, so every program is by default single threaded model.


        static void Test1()
        {
            for(int i = 0; i <=100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i<= 100; i++)
            {
                Console.WriteLine(i);
                if(i==50)
                {
                    Console.WriteLine("Program will sleep for 5 seconds..");

                    Thread.Sleep(5000);

                    Console.WriteLine("Program woke up..");

                }
            }
        }
        static void Test3()
        {
            for (int i = 0; i <=100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
        }
    }
}
