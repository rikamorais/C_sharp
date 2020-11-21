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
            Console.WriteLine("(5) Raiz quadrada de um número.");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha) {
                case 1:
                    Console.WriteLine("\nDigite o primeiro número:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    op = n1 + n2;
                    Console.WriteLine(n1 + " + " + n2 + " = " + op);
                    break;
                case 2:
                    Console.WriteLine("\nDigite o primeiro número:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToInt32(Console.ReadLine()); 
                    op = n1 - n2;
                    Console.WriteLine(n1 + " - " + n2 + " = " + op);
                    break;
                case 3:
                    Console.WriteLine("\nDigite o primeiro número:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToInt32(Console.ReadLine()); 
                    op = n1 * n2;
                    Console.WriteLine(n1 + " * " + n2 + " = " + op);
                    break;
                case 4:
                    Console.WriteLine("\nDigite o primeiro número:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    n2 = Convert.ToInt32(Console.ReadLine()); 
                    
                    if (op == 0) {
                        Console.WriteLine("Não existe divisão por zero.");
                    }
                    else { 
                        op = n1 / n2;
                        Console.WriteLine(n1 + " / ", n2);
                    }

                    break;
                case 5:
                    Console.WriteLine("\nDigite o número:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    
                    if (n1 < 0) {
                        Console.WriteLine("Não existe raiz quadrada de número negativo."); 
                    }
                    else{
                        op = Math.Sqrt(n1);
                        Console.WriteLine("Raiz quadrada de " + n1 + " = " + Math.Sqrt(n1));
                    }

                    
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
                
            }// fim do switch

            // ----------- S A Í D A de dados -------------

            

            Console.ReadKey();
        }// fim da classe principal
    }//fim da classe
}//fim do algoritmo
