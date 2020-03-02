using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercicio1();

            // Exercicio2();

            // Exercicio3();

            Exercicio4();
        }

        static void Exercicio1()
        {
            double[] coleta = new double[5];

            for (int i = 0; i < coleta.Length; i++)
            {
                Console.WriteLine("Insera o " + i + " valor: ");
                coleta[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Lista Original - Ordem Digitada: ");
            for (int i = 0; i < coleta.Length; i++)
            {
                Console.Write(coleta[i] + " - ");
            }

            Console.WriteLine();

            double[] ordemCrescente = coleta.OrderBy(x => x).ToArray();

            Console.WriteLine("ORDEM CRESCENTE");
            foreach (var item in ordemCrescente)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ORDEM DECRESCENTE");
            double[] ordemDecescente = coleta.OrderByDescending(x => x).ToArray();

            foreach (var item in ordemDecescente)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }

        static void Exercicio2()
        {
            Dictionary<string, string> site = new Dictionary<string, string>();
            do
            {
                Console.WriteLine("Digite o nome do Site: ");
                string nSite = Console.ReadLine();
                Console.WriteLine("Digite a url do site:");
                string uSite = Console.ReadLine();
                site.Add(nSite, uSite);
                Console.WriteLine();


            } while (site.Count < 2);

            double code = 0;
            do
            {
                Console.WriteLine("Escolha uma das opcoes abaixo: ");
                Console.WriteLine("1- Achar um site. \n2- Sair.");
                code = Convert.ToDouble(Console.ReadLine());

                switch (code)
                {
                    case 1:

                        Console.WriteLine("Qual o nome do site? ");
                        string nome = Console.ReadLine(); bool n = false;

                        foreach (var item in site)
                        {
                            if (item.Key == nome)
                            {
                                n = true;
                                Console.WriteLine(item.Value);
                                break;
                            }
                        }

                        if (n == false)
                            Console.WriteLine("Site não encontrado");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Finalizando o Programa...");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("OPCAO INVALIDA!");
                        Console.WriteLine();
                        break;

                }

            } while (code != 2);
        }

        static void Exercicio3()
        {
            Stack<double> value = new Stack<double>();
            double code = 0;

            do
            {
                Console.WriteLine("Escolha uma das opcoes abaixo: \n1- Inserir número" +
                    "\n2- Remover número \n3- Sair");
                code = Convert.ToDouble(Console.ReadLine());

                switch (code)
                {
                    case 1:
                        Console.Write("Informe um valor: ");
                        value.Push(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("Lista Atualizada!");

                        foreach (var item in value)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();

                        break;

                    case 2:
                        value.Pop();
                        Console.WriteLine("Item Removido\n");

                        Console.WriteLine("Lista Atualizada!");

                        foreach (var item in value)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();
                        break;



                    case 3:
                        Console.WriteLine("Finalizando o Programa...");
                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            } while (code != 0);
        }

        static void Exercicio4()
        {

            Queue<double> value = new Queue<double>();
            double code = 0;

            do
            {
                Console.WriteLine("Escolha uma das opcoes abaixo: \n1- Inserir número" +
                    "\n2- Remover número \n3- Sair");
                code = Convert.ToDouble(Console.ReadLine());

                switch (code)
                {
                    case 1:
                        Console.Write("Informe um valor: ");
                        value.Enqueue(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("Lista Atualizada!");

                        foreach (var item in value)
                        {
                            Console.Write(item + " ");
                        }

                        Console.WriteLine();

                        break;

                    case 2:
                        value.Dequeue();
                        Console.WriteLine("Item Removido\n");

                        Console.WriteLine("Lista Atualizada!");

                        foreach (var item in value)
                        {
                            Console.Write(item + " ");
                        }

                        break;



                    case 3:
                        Console.WriteLine("Finalizando o Programa...");

                        break;

                    default:
                        break;

                }
                Console.WriteLine("\n");
            } while (code != 0);
        }
    }
}


