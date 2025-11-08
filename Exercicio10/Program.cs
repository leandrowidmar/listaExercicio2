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

                bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do aluno: ");
                        nomes[totalAlunos] = Console.ReadLine();


                        Console.WriteLine("Digite a nota 1 (0-10): ");
                        nota1[totalAlunos] = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Digite a nota 2 (0-10): ");
                        nota2[totalAlunos] = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a nota 3 (0-10): ");
                        nota3[totalAlunos] = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Aluno adicionado com sucesso!!!");

                        totalAlunos++;

                        break;

                    case 2:
                        if(totalAlunos == 0)
                        {
                            Console.WriteLine("Nenhum aluno cadastrado");
                        }
                        else 
                        {
                            for(int i = 0; i < totalAlunos ; i++)
                            {
                                double media = (nota1[i] + nota2[i] + nota3[i]) /3;
                                Console.WriteLine($"{nomes[i]}: {media:f2} ");                                
                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Situação dos Alunos");

                        for (int i = 0; i < totalAlunos; i++)
                        {
                            double media = (nota1[i] + nota2[i] + nota3[i]) / 3;

                            if (media >= 7)
                            {
                                Console.WriteLine($"{nomes[i]}: Aprovado!!!");
                            }
                            else if (media >= 5)
                            {
                                Console.WriteLine($"{nomes[i]}: Recuperação!!!");
                            }
                            else if (media < 5)
                            {
                                Console.WriteLine($"{nomes[i]}: Reprovado!!!");
                            }
                        }
                        break;

                    case 4:

                        Console.WriteLine("Estátisticas da turma");
                        if (totalAlunos == 0) 
                        {
                            Console.WriteLine("Nenhum aluno cadastrado");   
                        }
                        else
                        {
                            double somaGeralMedias = 0;
                            double maiorNota = double.MinValue;
                            double menorNota = double.MaxValue;
                            int aprovados = 0;
                            string nomeMaiorNota = "";
                            string nomeMenorNota = "";

                            for(int i =0; i < totalAlunos; i++)
                            {
                                double media = (nota1[i] + nota2[i] + nota3[i]) / 3;
                                somaGeralMedias += media;

                                if (media >= 7);
                                {
                                    aprovados++;
                                }

                                if (nota1[i] > maiorNota) { maiorNota = nota1[i]; nomeMaiorNota = nomes[i]; }
                                if (nota2[i] > maiorNota) { maiorNota = nota2[i]; nomeMaiorNota = nomes[i]; }
                                if (nota3[i] > maiorNota) { maiorNota = nota3[i]; nomeMaiorNota = nomes[i]; }

                                if (nota1[i] < menorNota) { menorNota = nota1[i]; nomeMenorNota = nomes[i]; }
                                if (nota2[i] < menorNota) { menorNota = nota2[i]; nomeMenorNota = nomes[i]; }
                                if (nota3[i] < menorNota) { menorNota = nota3[i]; nomeMenorNota = nomes[i]; }
                            }
                            double mediaGeral = somaGeralMedias / totalAlunos;
                            double taxaAprovacao = ((double)aprovados / totalAlunos) * 100;

                            Console.WriteLine("═══════════════════════════════════");
                            Console.WriteLine($"Total de alunos: {totalAlunos}");
                            Console.WriteLine($"Média geral: {mediaGeral:F2}");
                            Console.WriteLine($"Maior nota: {maiorNota:F1} (Aluno: {nomeMaiorNota})");
                            Console.WriteLine($"Menor nota: {menorNota:F1} (Aluno: {nomeMenorNota})");
                            Console.WriteLine($"Taxa de aprovação: {taxaAprovacao:F1}%");
                            Console.WriteLine("═══════════════════════════════════");
                        }
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

    }

}