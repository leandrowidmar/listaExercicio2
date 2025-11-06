using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    internal class Exercicio6
    {
        static void Main()
        {

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            string fraseMaiuscula = frase.ToUpper();
            int contadorVogais = 0;
            int contadorConsoantes = 0;


            foreach(char letra in fraseMaiuscula)
            {
                switch (letra)
                {
                    // 3. Empilhamos os casos. Se for A, E, I, O, ou U...
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        contadorVogais++; // ...aumenta o contador de vogais.
                        break; // (Importante!) Sai do switch e pega a próxima letra.

                    default:

                        if (letra >= 'A' && letra <= 'Z')
                        {
                            contadorConsoantes++;
                        }

                        break;
                }
            }

            Console.WriteLine($"A sua frase: {frase}");
            Console.WriteLine($"Tem {contadorVogais} vogais");
            Console.WriteLine($"Tem {contadorConsoantes} Consoantes");
        }
    }
}