using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_menu_lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------- E X E R C Í C I O ----------------

            // Uma lanchonete possuiu vários produtos. Cada produto possui um código
            // e um preço. Você deve fazer um programa para ler o código e a quantidade
            // comprada de um produto (suponha um código válido), e daí informar qual
            // o valor a ser pago, com duas casas decimais, conforme tabela de produtos.

            //TABELA
            //
            // Código do produto  |  Preço do produto
            // 1 - Cheeseburger   |     R$ 5.00
            // 2 - Hamburger      |     R$ 4.50
            // 3 - Batata frita   |     R$ 4.80
            // 4 - Pastel         |     R$ 4.00
            // 5 - Mandioca frita |     R$ 4.50

            /* ----------- V A R I Á V E I S ------------*/
            int op;
            double quant, total=0;

            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|----------- Menu de Lanchonete -----------|");
            Console.WriteLine("|------------------------------------------|\n");

            Console.WriteLine("(1) Cheeseburger --- R$ 5,00");
            Console.WriteLine("(2) Hamburger ------ R$ 4,50");
            Console.WriteLine("(3) Batata frita --- R$ 4,80");
            Console.WriteLine("(4) Pastel --------- R$ 4,00");
            Console.WriteLine("(5) Mandioca frita - R$ 4,50\n");

            Console.WriteLine("Faça seu pedido:");
            op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade:");
            quant = Convert.ToInt32(Console.ReadLine());

            switch (op) {
                case 1:
                    total = Math.Round(quant * 5, 2);
                    break;
                case 2:
                    total = Math.Round(quant * 4.5, 2);
                    break;
                case 3:
                    total = Math.Round (quant * 4.8, 2);
                    break;
                case 4:
                    total = Math.Round(quant * 4, 2);
                    break;
                case 5:
                    total = Math.Round(quant * 4.5, 2);
                    break;
                default:
                    Console.WriteLine("Escolha entre 1 e 5.");
                    break;
            }// fim do switch

            Console.WriteLine("\nTotal a pagar: R$" + Math.Round(quant * total, 2));

            Console.ReadKey();

        }// fim da classe principal
    }// fim da classe
}// fim do algoritmo
