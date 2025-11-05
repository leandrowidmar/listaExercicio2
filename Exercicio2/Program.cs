using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());


            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par.");
            }
            else
            {
                Console.WriteLine($"{numero} é ímpar.");
            }
            Console.ReadLine();

            // TODO: Leia um número do usuário
            // TODO: Verifique se é par ou ímpar usando %
            // TODO: Exiba o resultado 
        
        }
    }
}
