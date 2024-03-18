using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableIEnumeratorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //non-generic collection

            ArrayList itemList = new ArrayList();
            itemList.Add(1);
            itemList.Add(2);
            itemList.Add(3);
            itemList.Add(4);
            itemList.Add(5);

            //interface
            //only iterator to process each element in the non generic collection-Type is not Specified
            //System.Collection
            //for collection for namespace
            //parents object can point child class object memory

            IEnumerator itemsie=itemList.GetEnumerator();

            while(itemsie.MoveNext())
            {
                // var x=itemsie.Current;
                object x=itemsie.Current;
                Console.WriteLine(x);
            }

            // generic Collection
            List<Product> plist = new List<Product>()
            {

                new Product(){Id=1,Name="Chair",Units="5",Price=1500},
                  new Product(){Id=2,Name="Cots",Units="2",Price=3000},
                    new Product(){Id=3,Name="Bench",Units="6",Price=2000}
            };

            IEnumerator<Product> plistie=plist.GetEnumerator();

            while(plistie.MoveNext())
            {
                Product p = plistie.Current;
                Console.WriteLine(p.Id+" "+p.Name+" "+p.Units+" "+p.Price);
            }

            Console.WriteLine("------------------");
            UserOne(plist.GetEnumerator());
            Console.WriteLine("------------------");
            UserTwo(plist);

            Console.WriteLine("After calling userTwo method");

            IEnumerator<Product> plistie2 = plist.GetEnumerator();

            while (plistie2.MoveNext())
            {
                Product p = plistie2.Current;
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Units + " " + p.Price);
            }

            PrintOne(plist.GetEnumerator());

        }

        public static void UserOne(IEnumerator<Product> ienumrproduct)  // only navigation
        {
            while (ienumrproduct.MoveNext())
            {
                Product p = ienumrproduct.Current;
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Units + " " + p.Price);
            }
        }
        public static void UserTwo(List<Product> products)
        {
            //add-delete-update-display
            products.Add(new Product() { Id = 4, Name = "Knife",Units="1",Price=80});

            products.RemoveAt(1);
            Product x=(from p in products where p.Id == 1 select p).FirstOrDefault();

            x.Price = 2500;

            foreach(Product p in products)
            {
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Units + " " + p.Price);
            }
            
        }
        public static void PrintOne(IEnumerator<Product> ienumrproduct)  
        {
            while (ienumrproduct.MoveNext())
            {
                Product p = ienumrproduct.Current;
                Console.WriteLine("PrintOne :"+p.Id + " " + p.Name + " " + p.Units + " " + p.Price);
                if(p.Name=="Bench")
                {
                    PrintTwo(ienumrproduct);// at this instance of time --Bench
                }
            }
        }
        public static void PrintTwo(IEnumerator<Product> ienumrproduct)  // only navigation
        {
            while (ienumrproduct.MoveNext())// starts from Bench
            {
                Product p = ienumrproduct.Current;
                Console.WriteLine("Print Two :"+p.Id + " " + p.Name + " " + p.Units + " " + p.Price);
            }
        }
    }
}
