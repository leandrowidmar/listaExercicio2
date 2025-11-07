using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays para armazenar dados (máximo 50 alunos)
            string[] nomes = new string[50];
            double[] nota1 = new double[50];
            double[] nota2 = new double[50];
            double[] nota3 = new double[50];

            int totalAlunos = 0;

            int opcao;

            do
            {
                Console.WriteLine("\n════════════════════════════════");
                Console.WriteLine("   SISTEMA DE GERENCIAMENTO");
                Console.WriteLine("         DE NOTAS");
                Console.WriteLine("════════════════════════════════");
                Console.WriteLine("1. Adicionar aluno");
                Console.WriteLine("2. Calcular médias");
                Console.WriteLine("3. Verificar aprovações");
                Console.WriteLine("4. Estatísticas da turma");
                Console.WriteLine("5. Sair");
                Console.WriteLine("════════════════════════════════");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do aluno: ");
                        nomes[0] = Console.ReadLine();


                        Console.WriteLine("Digite a nota 1 (0-10): ");
                        nota1[0] = Convert.ToDouble(Console.ReadLine());
                        

                        Console.WriteLine("Digite a nota 2 (0-10): ");
                        nota2[0] = Convert.ToDouble(Console.ReadLine());
                      
                        Console.WriteLine("Digite a nota 3 (0-10): ");
                        nota3[0] = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Aluno adicionado com sucesso!!!");
                        break;

                    case 2:
                        double notaMedia1 = calcularMedias(nota1, nota2, nota3);
                        Console.WriteLine($"Média dos alunos: {notaMedia1}");
                        break;
                    case 3:
                        notaMedia1 = calcularMedias(nota1, nota2, nota3);
                        if (notaMedia1 >= 7)
                        {
                            Console.WriteLine("Aprovado!!!");
                        }
                        else if (notaMedia1 >= 5)
                        {
                            Console.WriteLine("Recuperação!!!");
                        }
                        else if(notaMedia1 < 5)
                        {
                            Console.WriteLine("Reprovado!!!");
                        }
                        break;

                    case 4:
                       for(int i = 0; i < nomes.Length; i++)
                        {
                            if(nomes[i] == "" )
                            {

                            break;    
                            }
                            
                            Console.WriteLine($"{nomes[i] = ""}");
                        }

                       // STATÍSTICAS DA TURMA:
                        //Total de alunos: 3
                        //Média geral: 7.00
                        //Maior nota: 9.0(João Silva)
                        //Menor nota: 4.5(Pedro Costa)
                        //Taxa de aprovação: 66.7 %
                        break;
                        
                    case 5:
                        Console.WriteLine("Encerrando sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 5);
        }

        public static double calcularMedias(double[] nota1, double[] nota2, double[] nota3)
        {
           double notaMedia1 = (nota1[0] + nota2[0] + nota3[0]) / 3;

            nota1[1] = 10;

            return notaMedia1;
        }
    }

}
