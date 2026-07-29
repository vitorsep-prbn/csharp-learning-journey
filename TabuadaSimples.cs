public class tabuadaSimples
{
    public static void Executar()
    {

        int num1;

        Console.WriteLine("Digite um número para ver sua tabuada até X 10 :o");
        num1 = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Mostrando a tabuada do " + num1 + " Em 3, 2, 1!" );
        Thread.Sleep(3000);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num1 + "X" + i +"=" + (num1 * i));
        }
    }
}