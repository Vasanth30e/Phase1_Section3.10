using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        public static void doApp()
        {
            string mary = "Mary had a little lamb.";
            Console.WriteLine("Original String =  " + mary);
            Console.WriteLine("Clone of a string = " + mary.Clone());
            Console.WriteLine("Compare two strings = " + mary.CompareTo("Mary had a big lamb"));
            Console.WriteLine("Characters in  a string = " + mary.Contains("r"));
            Console.WriteLine("String ending with = " + mary.EndsWith("lamb."));
            Console.WriteLine("All Lowercase = " + mary.ToLower());
            Console.WriteLine("All UpperCase = " + mary.ToUpper());
            Console.WriteLine("Insert String with a string = " + mary.Insert(4, " and Jack "));
            Console.WriteLine("Splitting string into words: ");
            string[] parts =  mary.Split(' ');

            foreach (string part in parts) 
            {
                Console.WriteLine(part);
            }

            StringBuilder sb = new StringBuilder("");
            for(int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
