# C# Learning Journey 🚀

Repositório com os meus exercícios e projetos enquanto aprendo **C#** e **.NET**, do zero até (um dia) profissional. A ideia é usar este repo como portfólio da minha evolução.

## Sobre

Este é um projeto de console (.NET) criado com o objetivo de praticar os fundamentos da linguagem: entrada/saída de dados, condicionais, estruturação de código em classes, etc.

## Exercícios

| Exercício | Arquivo | Descrição |
|---|---|---|
| Hello World | [`helloworld.cs`](helloworld.cs) | Primeiro programa, imprime `"Hello World"` no console. |
| Menor ou Maior de Idade | [`MenorMaiorIdade.cs`](MenorMaiorIdade.cs) | Lê a idade digitada pelo usuário e informa se é maior ou menor de idade (18 anos). |
| Acessar Wi-Fi | [`AcessarWIFI.cs`](AcessarWIFI.cs) | Simulação simples: compara a senha digitada com uma senha fixa no código e informa se está correta. |
| Tabuada | [`TabuadaSimples.cs`](TabuadaSimples.cs) | Lê um número e imprime sua tabuada de 1 a 10 usando um laço `for`, com efeito de contagem regressiva. |
| Soma de 1 até N | [`SomaDe1AteN2.cs`](SomaDe1AteN2.cs) | Lê um número e soma todos os valores de 1 até ele com um laço `for`, além de dizer se o número é par ou ímpar. |
| Calculadora de Média | [`CalculadoraDeNota.cs`](CalculadoraDeNota.cs) | Lê 4 notas escolares, calcula a média e mostra uma mensagem de desempenho colorida no terminal, de acordo com a faixa da nota. |

`SomaDe1AteN.cs` é uma primeira tentativa do exercício de soma, mantida no repositório como registro da evolução até chegar na versão atual.

O ponto de entrada do projeto é o [`Program.cs`](Program.cs), que chama os exercícios. Como só um exercício roda por vez, comente/descomente a chamada do exercício desejado no `Program.cs`.

## Como rodar

Pré-requisitos: [.NET SDK](https://dotnet.microsoft.com/download) (versão 10.0 ou superior).

```bash
git clone https://github.com/vitorsep-prbn/csharp-learning-journey.git
cd csharp-learning-journey
dotnet run
```

## Estrutura do projeto

```
workspace.csproj      # arquivo de projeto (.NET)
Program.cs             # ponto de entrada
helloworld.cs           # exercício: hello world
MenorMaiorIdade.cs       # exercício: maior ou menor de idade
AcessarWIFI.cs           # exercício: validação de senha de Wi-Fi
TabuadaSimples.cs        # exercício: tabuada com laço for
SomaDe1AteN.cs           # exercício: soma de 1 até N (primeira tentativa)
SomaDe1AteN2.cs          # exercício: soma de 1 até N (versão final) + par/ímpar
CalculadoraDeNota.cs     # exercício: calculadora de média com cores no terminal
```

## Roadmap

- [x] Hello World
- [x] Condicionais (maior/menor de idade, validação de senha)
- [x] Laços de repetição (tabuada, soma de 1 até N)
- [ ] Coleções (listas, arrays, dicionários)
- [ ] Orientação a objetos
- [ ] Projetos maiores (APIs, console apps completos, etc.)

---

Feito por [@vitorsep-prbn](https://github.com/vitorsep-prbn) enquanto aprendo C#.
