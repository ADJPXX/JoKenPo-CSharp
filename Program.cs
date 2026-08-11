namespace Jokenpo;

public static class Program
{
    private static int _quantidadeJogadas;
    private static int _quantidadeVitorias;
    private static int _quantidadeDerrotas;
    private static int _quantidadeEmpates;

    private static int _quantidadeJogadasGerais;
    private static int _quantidadeVitoriasGerais;
    private static int _quantidadeDerrotasGerais;
    private static int _quantidadeEmpatesGerais;

    private static readonly string TxtPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stats.txt");

    public static void Main(string[] args)
    {
        TxtExiste();
        LerTxt();
        Menu();
    }


    private static void Menu()
    {
        while (true)
        {
            Console.Clear();

            EscreverTxt();

            Console.WriteLine("""
                              ----------
                              JOKENPO
                              ----------
                              [ 1 ]PEDRA
                              [ 2 ]PAPEL
                              [ 3 ]TESOURA
                              [ 4 ]ESTATISTICAS
                              [ 5 ]LIMPAR ESTATISTICAS
                              [ 0 ]SAIR
                              ----------
                              """);

            var opcao = LerInt("Escolha sua opção: ");
            
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

            switch (opcao)
            {
                case 1:
                    _quantidadeJogadas++;
                    _quantidadeJogadasGerais++;
                    Console.Clear();
                    JogadaPedra();
                    break;
                case 2:
                    _quantidadeJogadas++;
                    _quantidadeJogadasGerais++;
                    Console.Clear();
                    JogadaPapel();
                    break;
                case 3:
                    _quantidadeJogadas++;
                    _quantidadeJogadasGerais++;
                    Console.Clear();
                    JogadaTesoura();
                    break;
                case 4:
                    MenuEstatisticas();
                    break;
                case 5:
                    _quantidadeJogadas = 0;
                    _quantidadeVitorias = 0;
                    _quantidadeDerrotas = 0;
                    _quantidadeEmpates = 0;

                    Console.Clear();
                    Console.WriteLine("TODAS AS ESTATISTICAS FORAM LIMPAS!\n");
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA, APERTE ENTER E DIGITE UMA OPÇÃO VÁLIDA!");
                    Console.ReadKey();
                    break;
            }
            
        }
    }


    private static void JogadaPedra()
    {
        var rnd = new Random();

        var jogadaCpu = rnd.Next(1, 4);

        Console.WriteLine("VOCÊ JOGOU PEDRA!!");

        switch (jogadaCpu)
        {
            case 1:
                Console.WriteLine("COMPUTADOR JOGOU PEDRA\nEMPATE!!");
                _quantidadeEmpates++;
                _quantidadeEmpatesGerais++;
                break;
            case 2:
                Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ PERDEU!!");
                _quantidadeDerrotas++;
                _quantidadeDerrotasGerais++;
                break;
            case 3:
                Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ GANHOU!!");
                _quantidadeVitorias++;
                _quantidadeVitoriasGerais++;
                break;
        }

        Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
        Console.ReadKey();
    }


    private static void JogadaPapel()
    {
        var rnd = new Random();

        var jogadaCpu = rnd.Next(1, 4);

        Console.WriteLine("VOCÊ JOGOU PAPEL!!");

        switch (jogadaCpu)
        {
            case 1:
                Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ GANHOU!!");
                _quantidadeVitorias++;
                _quantidadeVitoriasGerais++;
                break;
            case 2:
                Console.WriteLine("COMPUTADOR JOGOU PAPEL\nEMPATE!!");
                _quantidadeEmpates++;
                _quantidadeEmpatesGerais++;
                break;
            case 3:
                Console.WriteLine("COMPUTADOR JOGOU TESOURA\nVOCÊ PERDEU!!");
                _quantidadeDerrotas++;
                _quantidadeDerrotasGerais++;
                break;
        }

        Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
        Console.ReadKey();
    }


    private static void JogadaTesoura()
    {
        var rnd = new Random();

        var jogadaCpu = rnd.Next(1, 4);

        Console.WriteLine("VOCÊ JOGOU TESOURA!!");

        switch (jogadaCpu)
        {
            case 1:
                Console.WriteLine("COMPUTADOR JOGOU PEDRA\nVOCÊ PERDEU!!");
                _quantidadeDerrotas++;
                _quantidadeDerrotasGerais++;
                break;
            case 2:
                Console.WriteLine("COMPUTADOR JOGOU PAPEL\nVOCÊ GANHOU!!");
                _quantidadeVitorias++;
                _quantidadeVitoriasGerais++;
                break;
            case 3:
                Console.WriteLine("COMPUTADOR JOGOU TESOURA\nEMPATE!!");
                _quantidadeEmpates++;
                _quantidadeEmpatesGerais++;
                break;
        }

        Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");
        Console.ReadKey();
    }


    private static void MenuEstatisticas()
    {
        Console.Clear();
        Console.WriteLine("[ 0 ]VOLTAR\n[ 1 ]ESTATISTICAS DESSA SESSÃO\n[ 2 ]ESTATISTICAS GERAL");

        var opcao = LerInt("Escolha sua opção: ");

        switch (opcao)
        {
            case 0:
            {
                return;
            }

            case 1:
            {
                Estatisticas();
                break;
            }

            case 2:
            {
                EstatisticasGeral();
                break;
            }
        }
    }


    private static void Estatisticas()
    {
        Console.Clear();

        Console.WriteLine($"Partidas jogadas: {_quantidadeJogadas}");
        Console.WriteLine($"Vitórias: {_quantidadeVitorias}");
        Console.WriteLine($"Derrotas: {_quantidadeDerrotas}");
        Console.WriteLine($"Empates: {_quantidadeEmpates}");

        Console.WriteLine("\n\nAPERTE ENTER PARA JOGAR DE NOVO >:");

        Console.ReadKey();
    }


    private static void EstatisticasGeral()
    {
        Console.Clear();

        var texto = File.ReadAllText(TxtPath);

        Console.WriteLine($"{texto}\n\nAperte qualquer tecla para voltar:");
        Console.ReadKey();
    }


    private static void EscreverTxt()
    {
        var texto =
            $"Partidas jogadas: {_quantidadeJogadasGerais}\nVitórias: {_quantidadeVitoriasGerais}\nDerrotas: {_quantidadeDerrotasGerais}\nEmpates: {_quantidadeEmpatesGerais}";

        File.WriteAllText(TxtPath, texto);
    }


    private static void LerTxt()
    {
        var linhas = File.ReadAllLines(TxtPath);

        _quantidadeJogadasGerais = int.Parse(linhas[0].Split(':')[1].Trim());
        _quantidadeVitoriasGerais = int.Parse(linhas[1].Split(':')[1].Trim());
        _quantidadeDerrotasGerais = int.Parse(linhas[2].Split(':')[1].Trim());
        _quantidadeEmpatesGerais = int.Parse(linhas[3].Split(':')[1].Trim());
    }


    private static void TxtExiste()
    {
        if (File.Exists(TxtPath))
        {
            return;
        }

        File.Create(TxtPath).Close();

        var texto =
            $"Partidas jogadas: {_quantidadeJogadasGerais}\nVitórias: {_quantidadeVitoriasGerais}\nDerrotas: {_quantidadeDerrotasGerais}\nEmpates: {_quantidadeEmpatesGerais}";

        File.WriteAllText(TxtPath, texto);
    }


    private static int LerInt(string msg)
    {
        while (true)
        {
            try
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine()?.Trim(), out var inteiro))
                {
                    return inteiro;
                }
            }
            
            catch
            {
                //ignored
            }
        }
    }
}