﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    /* E X E R C Í C I O
     * 
     * Crie um algoritmo que leia um número inteiro e apresente o fatorial desse número. */


    class Program
    {
        static void Main(string[] args)
        {
            double n, i, fat=1;
            
            Console.WriteLine ("|-------------------------------------|");
            Console.WriteLine ("|---------- F A T O R I A L ----------|");
            Console.WriteLine ("|-------------------------------------|\n");
            Console.WriteLine ("Pragrama para calcular números fatoriais.\n");

            Console.WriteLine("Digite um número: ");
            n = Convert.ToDouble(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                fat *= i; //fat = fat * i;
            }
            Console.WriteLine(n + "! = " + fat);
            Console.ReadKey();
        }
    }
}
