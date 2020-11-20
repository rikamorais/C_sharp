using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ------------ E X E R C Í C I O -------------------
            Crie um algoritmo que leia vários números positivos inteiros e imprima
            a média dos múltiplos de 3. Se não houver múltiplos de 3, mostre uma mensagem
            na tela ( O programa para quando for digitado zero ou um número negativo. */

            int cont_n=0, acumula_n=0, n;
            double media;

            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|---------- Números múltiplos de 3 ----------|");
            Console.WriteLine("|--------------------------------------------|\n");

            Console.WriteLine("Digite um número positivo ou 0 para terminar:");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {   
                if (n % 3 == 0) {
                    cont_n++;
                acumula_n += n;
                }//fim do if

                Console.WriteLine("Digite um número positivo ou 0 para terminar:");
                n = Convert.ToInt32(Console.ReadLine());

            }// fim do while

            //---------------- S A Í D A -----------------
            if (cont_n > 0)
            {                
                media = (acumula_n / cont_n);
                Console.WriteLine("Foram digitados " + cont_n + " números múltiplos de 3.");
                Console.WriteLine("MÉDIA dos números múltiplos de 3: " + Math.Round(media,2));
            }
            else 
            {
                Console.WriteLine("\nNão foram digitados números múltiplos de 3.");
            }//fim else
            
        

            Console.ReadKey();


        }// fim da classe principal
    }// fim da classe
}
