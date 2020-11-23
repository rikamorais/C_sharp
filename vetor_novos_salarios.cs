using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_novos_salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um algoritmo que leia um vetor de salários de 8 posições, calcule e imprima
             o vetor com os novos salários, reajustados em 12% (aumento de 12%)*/

            double i;
            double[] v = new double[8];

            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("|--------- Reajuste de salários ---------|");
            Console.WriteLine("|----------------------------------------|\n");

            Console.WriteLine("Digite os elementos do vetor: ");

            for (i = 0; i < 8; i++)
            {
                Console.Write("v[" + i + "]:");
                v[i] = Convert.ToDouble(Console.ReadLine());
            }// fim do for

            Console.Clear();

            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Salário atual: R$ " + v[i] + "| Novo salário: R$ " + v[i] * 1.12);
            }

            Console.ReadKey();
        }// fim da classe principal
    }// fim da classe
}// fim do algoritmo
