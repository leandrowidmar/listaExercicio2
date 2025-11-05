using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 12)
            {
                Console.WriteLine("Classificação: Criança ");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Classificação: Adolescente ");
            }
            else if(idade <= 59)
            {
                Console.WriteLine("Classificação: Adulto");
            }
            else if(idade >= 60)
            {
                Console.WriteLine("Classificação: Idoso");
            }


        }
    }
}
