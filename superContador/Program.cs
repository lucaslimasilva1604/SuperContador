using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superContador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("=================");
                Console.WriteLine("|      MENU     |");
                Console.WriteLine("=================");

                Console.WriteLine("| [1] De 1 a 10 |");
                Console.WriteLine("| [2] De 10 a 1 |");
                Console.WriteLine("| [3] Sair      |");
                Console.WriteLine("=================");

                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($" {i}..");
                    }
                    Console.WriteLine();
                }
                else if (escolha == 2)
                {
                    for (int i = 10; i >= 1; i--)
                    {
                        Console.Write($" {i}..");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("SAINDO...");
                }

            } while (escolha < 3);
            Console.ReadLine();
        }
    }
}
