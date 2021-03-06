﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varios_numeros_varias_operacoes
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------- E X E R C Í C I O ------------------
             * Crie um algoritmo que leia vários números, calcule e mostre:
             - a soma dos números digitados;
            - a quantidade de números digitados;
            - a média dos números digitados;
            - o maior número digitado;
            - o menor número digitado;
            - a média dos números pares, dentre os números digitados;
            - a porcentagem dos números ímpares entre todos os números digitados*/

            int n, soma=0, soma_par=0, maior, menor, cont=0, cont_par=0, cont_impar=0;
            double media, media_par=0, porcent_impar;

            Console.WriteLine("|------------------------------------------------------|");
            Console.WriteLine("|---------- Vários números, várias operações ----------|");
            Console.WriteLine("|------------------------------------------------------|\n");

            Console.WriteLine("Digite um número inteiro positivo ou 0 para terminar:");
            n = Convert.ToInt32(Console.ReadLine());

            maior = n;
            menor = n;
            
            while (n > 0)
            {

                soma += n;
      //----------- M A I O R NÚMERO ---------------

                if(n > maior)
                {
                    maior = n;
                } // fim do if
         
       //---------- M E N O R NÚMERO --------------
                if (n < menor && n > 0)
                {
                    menor = n;
                }// fim do if

      // ---------- NÚMEROS PARES e ÍMPARES ---------------

                if (n % 2 == 0)
                {
                    cont_par++;
                    soma_par += n;
                }
                else
                {
                    cont_impar++;
                }

              
                cont++;
                
                Console.WriteLine("Digite um número inteiro positivo ou 0 para terminar:");
                n = Convert.ToInt32(Console.ReadLine());
            }// fim do while

            // --------------- MÉDIAS --------------

            media_par = soma_par/(cont_par);
            media = (soma/cont);
            porcent_impar = (cont_impar * 100) / cont;

            //------------- Saída de dados --------------

            Console.WriteLine("SOMA dos números digitados: " + soma);
            Console.WriteLine("QUANTIDADE de números digitados: " + cont);
            Console.WriteLine("MÉDIA dos números digitados: " + media);
            Console.WriteLine("MAIOR número digitado: " + maior);
            Console.WriteLine("MENOR número digitado: " + menor);
            Console.WriteLine("MÉDIA dos números PARES: " + media_par);
            Console.WriteLine("PORCENTAGEM de números ímpares: " + Math.Round(porcent_impar,2) + "%");

            Console.ReadKey();

        }// fim da classe principal
    }// fim da classe
}
