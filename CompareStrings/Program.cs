using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //progamm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Sisestage oma perekonna nimi:");
            string perekonnanimi = Console.ReadLine();
            
            if(eesnimi.Length < perekonnanimi.Length)
            {
                Console.WriteLine("Perekonnanimi on pigem kui eesnimi");

            }
            else if (eesnimi.Length > perekonnanimi.Length)


            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi");

            }
            else
            {
                Console.WriteLine("Eesnimi ja perekonnanimi on sama pikad");
            }


        }
    }
}
