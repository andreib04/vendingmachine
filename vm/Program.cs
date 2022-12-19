using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int produs = 20;

            int credit = 0;

            while (true)
            {
                Console.WriteLine($"In acest moment in aparat sunt {credit} centi");

                Console.WriteLine($"Introduceti o moneda (nickel = 5, dime = 10, quarter = 25):");

                int moneda = int.Parse(Console.ReadLine());

                if(moneda != 5 && moneda != 10 && moneda != 25)
                {
                    Console.WriteLine("Moneda nu este acceptata, incercati alta");
                    continue;
                }

                credit += moneda;

                if(credit >= produs)
                {
                    int rest = credit - produs;

                    Console.WriteLine("Produsul a fost eliberat cu succes!\n");

                    Console.WriteLine($"Restul este: {rest} centi");

                    credit = 0;

                    Console.WriteLine("Va multumim!\n");
                }
            }
        }
    }
}
