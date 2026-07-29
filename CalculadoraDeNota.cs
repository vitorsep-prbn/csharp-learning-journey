public class calculadoradenota
{
    public static void Executar()
    {


        Console.Clear();
        Thread.Sleep(2000);
        Console.WriteLine("Calculador de médias escolares :)");
        Thread.Sleep(3500);
        Console.Clear();


        Console.WriteLine("Digite a sua nota de Português:");
        int nota1 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite sua nota de Matemática");
        int nota2 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite a sua nota de História:");
        int nota3 = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite sua nota de Geografia");
        int nota4 = int.Parse(Console.ReadLine());
        Console.Clear();


        double resultado = (nota1 + nota2 + nota3 + nota4) / 4.0;

        Thread.Sleep(1500);
        if (resultado < 5)
        {
            Console.WriteLine("Sua média foi " + resultado + ", retenção. É necessário revisar o conteúdo para recuperação.");
        }
        else if (resultado < 7)
        {
            Console.WriteLine("Sua média foi " + resultado + ", atingiu a média, parabéns pelo desempenho.");
        }
        else if (resultado < 10)
        {
            Console.WriteLine("Sua média foi " + resultado + ", ótimo resultado! Continue mantendo esse excelente ritmo!");
        }
        else
        {
            Console.WriteLine("Sua média foi " + resultado + ", desempenho brilhante e domínio completo dos conteúdos!");
        }


    }
}