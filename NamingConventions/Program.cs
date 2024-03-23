using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NamingConventions
{

    //Naming Conventions
    //    PascalCase
    //    CamelCase
    //    UPPERCASE
    //    Prefixes
    //    Plurals
    //    Verb-Noun

    class MyClass // Class-PascalCase
    {
        public string MyProperty {  get; set; } // Property-PascalCase

        private int myAge; //Private Variable-CamelCase

        public MyClass(string propertyValue) 
        {
            MyProperty= propertyValue;
        }
        public void Print(string contextText) // Parameter- CamelCase
        {
            string myText = ""; //Local Variable-CamelCase
    i        Console.WriteLine(myText);
        }
        public static int AddNumbers(int a,int b)  // Method-PascalCase
        {
            return a + b;
        }

        interface IPrintImplements // interface- Prefixes
        {
            void Print(string contextText);
        }
        List<string> fruits = new List<string>(); // List-Plural

        public void OnClick()  // Method- Verb-Noun
        {

        }
        public string GetResults(int input)
        {
            int result = input * 2;
            return result + " ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
