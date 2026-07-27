public class AcessarWifi
{
    public static void Executar()
    {

        Console.WriteLine("Digite a senha do Wi-Fi:");
        string wifi = Console.ReadLine();

        if (wifi == "senha123")
        {
            Console.WriteLine("Senha correta, conectado!");
        }
        else
        {
            Console.WriteLine("Senha incorreta, tente novamente.");
        }

    }
}