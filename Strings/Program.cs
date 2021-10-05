using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(firstname);
            Console.WriteLine(firstname[0]);

            int firstNameLength = firstname.Length;
            Console.WriteLine($"Teie nimi on {firstNameLength} sümbolit pikk");

            //viimase tähe indeks = firstNameLength - 1
            Console.WriteLine(firstname[firstNameLength-1]);

        }
    }
}
