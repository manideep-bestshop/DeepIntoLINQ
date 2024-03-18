using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12,65,39,47,8,61,74,82,97,27,56,49,58,79,4,23,92};
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > 40)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);

            int[] brr = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[index] = arr[i];
                    index += 1;
                }
            }
            Array.Sort(brr);
            Array.Reverse(brr);
            for(int i = 0;i< brr.Length;i++)
            {
                Console.WriteLine(brr[i]);
            }

            //Using LINQ query

            var ar = from i in arr where i>40 orderby i descending select i;
            foreach(var i in ar)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();

            string[] names = { "Mani", "deep", "India", "Telangana","Hyderabad" };

            var a = from name in names where name.Contains("i") select name;

            foreach(var item in a)
            {
                Console.Write(" "+item);
            }
            Console.ReadLine();

            List<int> nums=new List<int>{ 1, 2, 3, 4, 5 };
            var res = nums.Where(i => i>2).ToList();
            foreach(var i in res)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine("Enumerables");
            var array = new int[] { 1,3,4,5};
            array.GetEnumerator();

            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
            var enumerator = array.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
