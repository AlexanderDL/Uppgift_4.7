using System;
namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en text:");
            string text = Console.ReadLine();

            Console.WriteLine("Skriv in två tecken:");
            string tecken = Console.ReadLine();

            char tecken1 = tecken[0];
            char tecken2 = tecken[1];

            if (text.Contains(tecken1) && text.Contains(tecken2))
            {
                Console.WriteLine("Båda tecknen finns i texten!");
            }
            else
            {
                Console.WriteLine("Båda tecknen finns inte i texten.");
            }
        }
    }
}