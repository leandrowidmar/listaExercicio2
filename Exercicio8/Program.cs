using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Exercicio8
    {
        static void Main()
        {


            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);  // 1 a 100
            int tentativas = 0;
            int palpite;

            Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
            Console.WriteLine("Adivinhe o número entre 1 e 100");

            do
            {
                Console.WriteLine("Qual seu palpite? "); 

                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite > numeroSecreto)
                {
                    int distanciaCima = palpite - numeroSecreto; 
                    if (distanciaCima > 15) 
                    {
                        Console.WriteLine("Está MUITO longe, mais pro baixo!");
                    }
                    else
                    {
                        Console.WriteLine("Está perto, POUCO mais baixo.");
                    }
                }
                else if (palpite < numeroSecreto)
                {
                    int distanciaBaixo = numeroSecreto - palpite;
                    if (distanciaBaixo > 15)
                    {
                        Console.WriteLine("Está MUITO longe, mais pra alto!");
                    }
                    else
                    {
                        Console.WriteLine("Está perto POUCO mais alto.");
                    }
                }

            } while (palpite != numeroSecreto);

            Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas!");
        }
    }
}