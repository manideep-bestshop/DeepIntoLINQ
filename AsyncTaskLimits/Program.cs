using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTaskLimits
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }

        public static List<CreditCard> GenerateCards(int number)
        {
            List<CreditCard> cards = new List<CreditCard>();
            for (int i = 1; i <= number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "10000" + i,
                    Name = "Cards" + i
                };
                cards.Add(card);
            }
            return cards;
        }
    }
    internal class Program
    {
       public static SemaphoreSlim sema=new SemaphoreSlim(5);
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method started..");
            List<CreditCard> cards = CreditCard.GenerateCards(10);

            ProcessCreditCards(cards);
            Console.WriteLine("Main method ended..");
            Console.ReadKey();
        }
        public static async void ProcessCreditCards(List<CreditCard> cards)
        {
            var sw = new Stopwatch();
            sw.Start();

            var tasks = new List<Task<string>>();
            tasks=cards.Select(async card =>
            {
                await sema.WaitAsync();
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    return sema.Release();
                }
            }).ToList();
            
            //await Task.Run(() => {
            //    foreach (var card in cards)
            //    {
            //        var result = ProcessCard(card);
            //        tasks.Add(result);
            //    }
            //});

          String[] result= await Task.WhenAll(tasks);
            foreach(var task in result)
            {
                Console.WriteLine(task);
            }
            sw.Stop();
            Console.WriteLine($"Process done in {sw.ElapsedMilliseconds / 1000} second(s)");
        }
        public static async Task<string> ProcessCard(CreditCard card)
        {
            await Task.Delay(1000);
            string message = $"CardNumber:{card.CardNumber},Name:{card.Name}";
            return message;
        }
    }
}
