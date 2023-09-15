using System;

namespace uppgift_2_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i längdhopp, svara i meter?...");
            String x = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma i längdhopp, svara i meter?...");   
            String y = Console.ReadLine();

            double hopp1 = double.Parse(x);
            double hopp2 = double.Parse(y);
            double sum = hopp1 - hopp2;
            Console.WriteLine("Elin hoppade "+ sum +" meter längre än Alma.");
            Console.ReadKey();
        }
    }
}
