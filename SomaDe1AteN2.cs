public class somade1ateN2
{
    public static void Executar()
    {
        
        Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());

        int total = 0;
        

        for (int i = 1; i <= numero; i++)
        {
            total += i;
        }
        Console.Clear();
        Thread.Sleep(1500);

        Console.WriteLine("A soma de 1 até " + numero + " é " + total+ "." );

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
























    }
}