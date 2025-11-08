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


            string nome;
            int idade;
            string email;
            
            while (true)
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                if (nome.Length >= 3) 
                {
                }
                else
                {
                    Console.WriteLine("Seu nome é invalido, tente novamente");
                }
                break;
                // TODO: Valide o nome
                // Se válido: break
                // Se inválido: mostre erro e tente novamente
            }
            while (true)
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                if(idade > 0 || idade < 120)
                { 

                }
                else
                {
                    Console.WriteLine("Sua idade é invalida, tente novamente (0-120)");
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("Digite seu Email: ");
                email = Console.ReadLine();

                if (email.Contains("@") && email.Contains("."))
                {

                }
                else
                {
                    Console.WriteLine("Seu email é invalido, ele deve conter @ e .");
                }

                break;
            }
            Console.WriteLine("\nDados válidos:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Email: {email}");
        }
    }
}