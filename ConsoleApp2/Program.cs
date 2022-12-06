using System;
using System.Linq;

namespace Aufgabe1
{
    class Program
    {
        //Program
        static void Main(string[] args)
        {
            var input = Data.input;

            for (int i = 0; i <= input.Length; i++)
            {
                string marker = input.Substring(i, 14);
                int uniqueLetters = marker.Distinct().Count();

                if (uniqueLetters == 14)
                {
                    Console.WriteLine(i + 14);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
    