using System;

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
[ 0 ]SAIR
----------
Escolha sua opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    if (opcao == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("OBRIGADO POR USAR O PROGRAMA!");
                        break;
                    }

                    if (opcao == 1)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        JogadaPedra();
                    }

                    else if (opcao == 2)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        JogadaPapel();
                    }

                    else if (opcao == 3)
                    {
                        quantidadeJogadas += 1;
                        Console.Clear();
                        JogadaTesoura();
                    }

                    else if (opcao == 4)
                        Estatisticas(quantidadeJogadas, quantidadeVitorias, quantidadeDerrotas, quantidadeEmpates);

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
        static void JogadaPedra()
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU PEDRA!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nEMPATE!!"); break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ PERDEU!!"); break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ GANHOU!!"); break;
            }
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();
        }

        static void JogadaPapel()
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU PAPEL!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ GANHOU!!"); break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nEMPATE!!"); break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ PERDEU!!"); break;
            }
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();
        }

        static void JogadaTesoura()
        {
            Random rnd = new Random();

            int jogadaCpu = rnd.Next(1, 4);

            Console.WriteLine("VOCÊ JOGOU TESOURA!!");

            switch (jogadaCpu)
            {
                case 1: Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ PERDEU!!"); break;
                case 2: Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ GANHOU!!"); break;
                case 3: Console.WriteLine("COMPUTADOR JOGOU TESOURA\nEMPATE!!"); break;
            }

            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();
        }

        static void Estatisticas(int jogadas, int vitorias, int derrotas, int empates)
        {
            Console.Clear();
            Console.WriteLine($@"Partidas jogadas: {jogadas}");
            Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
            Console.ReadKey();
        }
    }
}