using System.Security.AccessControl;

public class locadoradeFilmes
{
    public static void Executar()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-- LOCADORA IDHEM --");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("-LOGIN- ");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite seu usuário:");
        string usuario = Console.ReadLine();

        Console.WriteLine("Digite a senha:");
        string senha = Console.ReadLine();

        if (usuario == "vitor123" && senha == "senha123")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login realizado com sucesso");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Usuário ou senha incorretos.");
        }

        Thread.Sleep(2500);

        string meusFilmes = "";
        int opcao = 0;

        while (opcao != 4)
        {
            Console.Clear();
            Console.WriteLine("1 - ALUGAR FILMES");
            Console.WriteLine("2 - MEUS FILMES");
            Console.WriteLine("3 - DEVOLVER FILMES");
            Console.WriteLine("4 - SAIR");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("ALUGAR FILMES:");
                Console.WriteLine("");
                Console.WriteLine("Qual filme deseja alugar? (digite apenas o número)");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" 1 - Vingadores: Ultimato - R$8 a diária");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 2 - Homem-Aranha: Um novo dia - R$15 a diária");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 3 - Gente Grande 3 - R$5 a diária");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" 4 - O poderoso chefão - R$10 a diária");

                int filme = int.Parse(Console.ReadLine());

                Console.Clear();
                if (filme == 1)
                {
                    meusFilmes = "Vingadores: Ultimato";
                    Console.WriteLine("Parabéns, filme alugado com sucesso. Para acessá-lo (em breve)");
                }
                else if (filme == 2)
                {
                    meusFilmes = "Homem-Aranha: Um novo dia";
                    Console.WriteLine("Parabéns, filme alugado com sucesso. Para acessá-lo (em breve)");
                }
                else if (filme == 3)
                {
                    meusFilmes = "Vingadores: Ultimato";
                    Console.WriteLine("Parabéns, filme alugado com sucesso. Para acessá-lo (em breve)");
                }
                else if (filme == 4)
                {
                    meusFilmes = "O poderoso chefão";
                    Console.WriteLine("Parabéns, filme alugado com sucesso. Para acessá-lo (em breve)");
                }
                else
                {
                    Console.WriteLine("Filme inválido, tente novamente");
                }

                Console.ReadLine();
            }
            else if (opcao == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1000);
                Console.WriteLine("Meus Filmes");
                Console.WriteLine(meusFilmes);

                Console.ReadLine();
            }


            else if (opcao == 3)
            {
                Console.Clear();
                if (meusFilmes == "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Não tem filmes para devolver.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("FILMES ALUGADOS:");
                    Console.WriteLine(meusFilmes);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Deseja devolver o filme? s/n?");
                    string devolver = Console.ReadLine();

                    if (devolver == "s" || devolver == "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.WriteLine("Filme devolvido com sucesso!");
                        meusFilmes = "";
                    }
                    else
                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Devolução cancelada.");
                    }
                }


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }


        }
    }
}