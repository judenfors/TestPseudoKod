using System;

namespace TestPseudoKod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int tal = int.Parse(Console.ReadLine());

            if(tal >= 18)
            {
                Console.WriteLine("Du är myndig");
            }

            else{
                Console.WriteLine("Du är inte myndig");
            }

        }
    }
}

