public class SomaMatriz
{
    public static void Executar()
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int soma = 0;

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                soma += matriz[linha, coluna];
            }
        }

        Console.WriteLine("Soma: " + soma);
    }
}