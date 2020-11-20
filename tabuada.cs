﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{

    // Crie um algoritmo que leia um número inteiro positivo n e deixe escolher qual a tabuada
    // de multiplicar que deve ser impressa na tela.

    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|---------- T A B U A D A ----------|");
            Console.WriteLine("|-----------------------------------|\n");

            Console.WriteLine("Digite o número que deseja ver a tabuada:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine ("\nTABUADA do " + n + "\n");

            for (i = 1; i <= 10; i++) {
             
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            Console.ReadKey();

        }
    }
}
