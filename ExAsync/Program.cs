using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAsync
{
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = await FryEggs(2);
            Console.WriteLine("eggs are ready");
        }
        private static async Task<Egg> FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
           await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }
        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
