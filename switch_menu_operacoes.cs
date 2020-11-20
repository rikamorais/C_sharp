using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_menu_operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double n1, n2, op=0;

            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|----- Menu de operações matemáticas -----|");
            Console.WriteLine("|-----------------------------------------|\n");

            
            Console.WriteLine("Escolha a operação matemática:\n");
            Console.WriteLine("(1) Somar dois números.");
            Console.WriteLine("(2) Subtrair dois números.");
            Console.WriteLine("(3) Multiplicar dois números.");
            Console.WriteLine("(4) Dividir dois números.");
            escolha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o primeiro número:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (escolha) {
                case 1:
                    op = n1 + n2;
                    break;
                case 2:
                    op = n1 - n2;
                    break;
                case 3:
                    op = n1 * n2;
                    break;
                case 4:
                    op = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
                
            }// fim do switch

            // ----------- S A Í D A de dados -------------

            Console.WriteLine("\nResultado: " + op);

            Console.ReadKey();
        }// fim da classe principal
    }//fim da classe
}//fim do algoritmo
