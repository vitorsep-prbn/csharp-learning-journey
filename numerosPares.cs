public class NumerosPares
{
    public static void Executar()
    {
        int[,] matriz =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 10 }
        };

        int pares = 0;

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (matriz[linha, coluna] % 2 == 0)
                {
                    pares++;
                }
            }
        }

        Console.WriteLine("Quantidade de pares: " + pares);
    }
}