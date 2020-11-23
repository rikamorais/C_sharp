using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_pares_impares
{
    class Program
    {
        static void Main(string[] args)
        {/*Faça um programa que carregue um vetor de seis elementos inteiros, calcule e mostre
          - a quantidade de números pares
          - quais os números pares
          - a quantidade de números ímpares
          - quais os números ímpares*/

        int i, cont_par=0, cont_impar=0;
        int[] v = new int[6];

        Console.WriteLine("|-----------------------------------------|");
        Console.WriteLine("|--- Vetor - elementos pares e ímpares ---|");
        Console.WriteLine("|-----------------------------------------|\n");
        Console.WriteLine("Digite os elementos do vetor:");
        for (i=0; i<6; i++)
            {
                Console.WriteLine("Digite v[" + i + "]:");
                v[i] = Convert.ToInt32(Console.ReadLine());

                if (v[i] % 2 == 0)
                {
                    cont_par++;
                }
                else
                {
                    cont_impar++;
                }
            }// fim do for
         
        Console.WriteLine("Foram digitados " + cont_par + " números pares:");

            // ------------------------- PARES ------------------------        
            if (cont_par > 0)
            {
                for (i=0; i<6; i++)
                {
                    if (v[i] % 2 == 0)
                    {
                        Console.Write(v[i] + "\t");
                    }

                }
            }
            else
            {
                Console.WriteLine("Não foram digitados números pares.");
            }
            // ----------------------- IMPARES --------------------

            Console.Write("\n\nForam digitados " + cont_impar + " números ímpares:");
            if (cont_impar > 0)
            {
                for (i=0; i<6; i++)
                {
                    if (v[i] % 2 != 0) {
                        Console.WriteLine(v[i] + "\t");
                    }
                }

            }
            else
            {
                Console.WriteLine("Não foram digitados números ímpares.");
            }
     

            Console.ReadKey();

        }// fima da classe principal
    }
}
