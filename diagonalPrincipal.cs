public class DiagonalPrincipal
{
    public static void Executar()
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }
}