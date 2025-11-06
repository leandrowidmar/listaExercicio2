
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Exercicio5
    {
        static void Main()
        {

            Console.Write("Digite um número (1-10): ");
            int numero = int.Parse(Console.ReadLine());
            // Exemplo básico: 0 a 9

            Console.WriteLine($"\nTabuada do {numero}:");

            // Loop de 1 a 10 para calcular e exibir a tabuada
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}