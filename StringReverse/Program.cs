﻿using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnimi
            //programm kuvab kasutajanime tagurpidi

            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine();

            for (int i = firstname.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(firstname[i]);
            }
        }
    }
}
