using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Exercicio1
    {
        static void Main()
        {

            bool continuarRodando = true;
            while (continuarRodando)
            {


                Console.WriteLine("escolha uma das opções de calculo");
                Console.WriteLine("SOMA + ', 1");
                Console.WriteLine("SUBTRAÇÃO - ', 2");
                Console.WriteLine("MULTIPLICAÇÃO *', 3");
                Console.WriteLine("DIVISÃO /', 4");
                Console.WriteLine("Sair, 5");

                // Agora, pegamos a UMA resposta do usuário e guardamos:
                string respostaMenu = Console.ReadLine();


                if (respostaMenu == "1")
                {
                    Console.WriteLine("Digite o Primeiro número: ");
                    string numeroUmTexto = Console.ReadLine();
                    int numeroUm = Convert.ToInt16(numeroUmTexto);
                    Console.WriteLine("Digite o Segundo número: ");
                    string numeroDoisTexto = Console.ReadLine();
                    int numeroDois = Convert.ToInt16(numeroDoisTexto);

                    int soma = numeroUm + numeroDois;
                    Console.WriteLine("Seu resultado é: " + soma + "  Digite enter para volar ao menu!");

                }
                else if (respostaMenu == "2")
                {
                    Console.WriteLine("Digite o Primeiro número: ");
                    string numeroUmTexto = Console.ReadLine();
                    int numeroUm = Convert.ToInt16(numeroUmTexto);
                    Console.WriteLine("Digite o Segundo número: ");
                    string numeroDoisTexto = Console.ReadLine();
                    int numeroDois = Convert.ToInt16(numeroDoisTexto);

                    int subtracao = numeroUm - numeroDois;

                    Console.WriteLine("Seu resultado é: " + subtracao + "  Digite enter para volar ao menu!");
                }
                else if (respostaMenu == "3")
                {

                    Console.WriteLine("Digite o Primeiro número: ");
                    string numeroUmTexto = Console.ReadLine();
                    int numeroUm = Convert.ToInt16(numeroUmTexto);
                    Console.WriteLine("Digite o Segundo número: ");
                    string numeroDoisTexto = Console.ReadLine();
                    int numeroDois = Convert.ToInt16(numeroDoisTexto);

                    int multiplicacao = numeroUm * numeroDois;

                    Console.WriteLine("Seu resultado é: " + multiplicacao + "  Digite enter para volar ao menu!");
                }
                else if (respostaMenu == "4")
                {

                    Console.WriteLine("Digite o Primeiro número: ");
                    string numeroUmTexto = Console.ReadLine();
                    int numeroUm = Convert.ToInt16(numeroUmTexto);
                    Console.WriteLine("Digite o Segundo número: ");
                    string numeroDoisTexto = Console.ReadLine();
                    int numeroDois = Convert.ToInt16(numeroDoisTexto);

                    int divisao = numeroUm / numeroDois;

                    Console.WriteLine("Seu resultado é: " + divisao + "  Digite enter para volar ao menu!");

                }
                else if (respostaMenu == "5")
                {
                    Console.WriteLine("Obrigado por usar a calculadora! Até a próxima...");
                    continuarRodando = false;
                }




                else
                {
                    Console.WriteLine("Opção inalida!!! Digite enter para tentar de novo.");
                }

                Console.ReadLine();

            }
        }


    }
}