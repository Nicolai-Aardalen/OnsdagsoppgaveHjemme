using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnsdagsoppgaveHjemme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            antallTallIEnInt();
        }
        static void antallTallIEnInt()
        {
            Console.Write("Write a multi-digit number: ");
            bool x = int.TryParse(Console.ReadLine(), out int number);
            int count = 0;
            if (!x)
            {
                return;
            }
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("\nThe number of numbers in this number is: " + count);
            Console.ReadLine();
        }
    }
}
