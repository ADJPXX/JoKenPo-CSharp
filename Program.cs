using System;
using System.Threading;
namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int quantidadeJogadas = 0;
            int quantidadeVitorias = 0;
            int quantidadeDerrotas = 0;
            int quantidadeEmpates = 0;

            while (true)
            {
                Console.Clear();
                Console.Write(@"----------
JOKENPO
----------
[ 1 ]PEDRA
[ 2 ]PAPEL
[ 3 ]TESOURA
[ 4 ]ESTATISTICAS
[ 5 ]LIMPAR ESTATISTICAS
[ 0 ]SAIR
----------
Escolha sua opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    if (opcao == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("OBRIGADO POR USAR O PROGRAMA!");
                        Console.WriteLine("SAINDO EM\n3...");
                        Thread.Sleep(1000);
                        Console.WriteLine("2...");
                        Thread.Sleep(1000);
                        Console.WriteLine("1...");
                        Thread.Sleep(1000);
                        break;
                    }

                    if (opcao == 1)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        (quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates) = JogadaPedra(quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates);
                    }

                    else if (opcao == 2)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        (quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates) = JogadaPapel(quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates);
                    }

                    else if (opcao == 3)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        (quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates) = JogadaTesoura(quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates);
                    }

                    else if (opcao == 4)
                        Estatisticas(quantidadeJogadas, quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates);

                    else if (opcao == 5)
                    {
                        quantidadeJogadas = 0;
                        quantidadeVitorias = 0;
                        quantidadeDerrotas = 0;
                        quantidadeEmpates = 0;

                        Console.Clear();
                        Console.WriteLine("TODAS AS ESTATISTICAS FORAM LIMPAS!");
                        Console.WriteLine();
                        Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INVÁLIDA, APERTE ENTER E DIGITE UMA OPÇÃO VÁLIDA!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA, APERTE ENTER E DIGITE UMA OPÇÃO VÁLIDA!");
                    Console.ReadKey();
                }
            }
        }
        static (int quantidadeVitorias, int quantidadeDerrotas, int quantidadeEmpates) JogadaPedra(int vitorias, int derrotas, int empates)
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU PEDRA!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nEMPATE!!"); empates += 1; break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ PERDEU!!"); derrotas += 1; break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ GANHOU!!"); vitorias += 1; break;
            }
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();

            return (vitorias, derrotas, empates);
        }

        static (int quantidadeVitorias, int quantidadeDerrotas, int quantidadeEmpates) JogadaPapel(int vitorias, int derrotas, int empates)
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU PAPEL!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ GANHOU!!"); vitorias += 1; break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nEMPATE!!"); empates += 1; break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ PERDEU!!"); derrotas += 1; break;
            }
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();

            return (vitorias, derrotas, empates);
        }

        static (int quantidadeVitorias, int quantidadeDerrotas, int quantidadeEmpates) JogadaTesoura(int vitorias, int derrotas, int empates)
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU TESOURA!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ PERDEU!!"); derrotas += 1; break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ GANHOU!!"); vitorias += 1; break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nEMPATE!!"); empates += 1; break;
            }

            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();

            return (vitorias, derrotas, empates);
        }

        static void Estatisticas(int jogadas, int vitorias, int derrotas, int empates)
        {
            Console.Clear();
            Console.WriteLine($"Partidas jogadas: {jogadas}");
            Console.WriteLine($"Vitórias: {vitorias}");
            Console.WriteLine($"Derrotas: {derrotas}");
            Console.WriteLine($"Empates: {empates}");
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();
        }
    }
}