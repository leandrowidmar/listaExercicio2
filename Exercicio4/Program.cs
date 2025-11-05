using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
            Console.WriteLine("Domingo");
                        break;
                case 2:
            Console.WriteLine("Segunda Feira");
                    break; 
                case 3:
            Console.WriteLine("Terça Feira");
                    break;
                case 4:
            Console.WriteLine("Quarta Feira");
                    break;
                case 5:
            Console.WriteLine("Quinta Feira");
                     break;
                case 6:
            Console.WriteLine("Sexta Feira");
                     break;
                case 7:
            Console.WriteLine("SABADO");
                    break;
                    
                Console.ReadLine();

            }



            // TODO: Use switch para exibir o dia da semana
            // 1 = Domingo, 2 = Segunda, ..., 7 = Sábado

            // TODO: Informe também se é dia útil ou final de semana
        }
    }
}
