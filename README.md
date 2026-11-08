# JoKenPo C#

Jogo de Pedra, Papel e Tesoura para terminal, escrito em C# com .NET 10. Você joga contra o computador e pode consultar os resultados da sessão atual e o histórico acumulado.

## Funcionalidades

- Jogar Pedra, Papel ou Tesoura contra uma escolha aleatória do computador.
- Consultar partidas, vitórias, derrotas e empates da sessão atual.
- Consultar estatísticas acumuladas, salvas em `stats.txt`.
- Limpar as estatísticas da sessão atual.

## Regras

- Pedra vence Tesoura e perde para Papel.
- Papel vence Pedra e perde para Tesoura.
- Tesoura vence Papel e perde para Pedra.
- Escolhas iguais resultam em empate.

## Requisitos

- .NET SDK 10.0 ou superior compatível com o alvo `net10.0`.
- Um terminal interativo para navegar pelo menu e jogar.

## Executar

Na pasta do projeto, execute:

```bash
dotnet run --project Jokenpo.csproj
```

O menu oferece opções para jogar, abrir as estatísticas, limpar o placar da sessão ou sair.

## Estatísticas e persistência

As estatísticas da sessão existem apenas enquanto o programa está aberto. O histórico geral é armazenado em texto no arquivo `stats.txt`, criado automaticamente ao lado do executável quando necessário. Ao iniciar, o programa lê esse arquivo para continuar o acumulado.

A opção **Limpar estatísticas** zera somente as partidas, vitórias, derrotas e empates da sessão atual. Os números do histórico geral permanecem salvos.

## Compilar e publicar

Para compilar em modo Release:

```bash
dotnet build Jokenpo.csproj -c Release
```

O projeto também inclui uma publicação self-contained para Windows x64 em arquivo único:

```bash
dotnet publish ./Jokenpo.csproj -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:PublishTrimmed=false -o publish
```

O executável publicado fica em `publish/Jokenpo.exe`. O workflow manual **Build Release** em `.github/workflows/release.yml` executa essa publicação e cria uma release no GitHub.
