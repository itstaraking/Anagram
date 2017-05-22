using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // give user instruction
            Console.WriteLine("Enter 2 words and I will tell you if they are anagrams");

            // get first statement from user
            Console.WriteLine("Enter the first word");
            string one = Console.ReadLine();

            // get the second statement from the user
            Console.WriteLine("Enter the second word");
            string two = Console.ReadLine();

            // convert input 1 into characters
            char[] charList1 = one.ToLower().ToCharArray();

            // convert input 2 to characters
            char[] charList2 = two.ToLower().ToCharArray();

            // sort the input character arrays
            Array.Sort(charList1);
            Array.Sort(charList2);

            // create new string objects for char arrays
            string inputArray1 = new string(charList1);
            string inputArray2 = new string(charList2);

            if (inputArray1 == inputArray2)
            {
                Console.WriteLine("This is an anagram!");
            }
            else
            {
                Console.WriteLine("This is not an anagram :(");
            }

            // hold the console screen open
            Console.ReadLine();

        }
    }
}
