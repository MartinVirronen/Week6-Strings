using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";

            //programm kuvab konsoolis sõne esimest tähte ja viimast tähte.

            Console.WriteLine(helloworld[0]);

            int helloworldLength = helloworld.Length;
            Console.WriteLine(helloworld[helloworldLength - 1]);
        }
    }
}
