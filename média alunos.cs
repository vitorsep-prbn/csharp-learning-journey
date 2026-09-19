public class MediaAlunos
{
    public static void Executar()
    {
        int[,] notas =
        {
            { 8, 7, 9, 6 },
            { 10, 8, 7, 9 }
        };

        for (int linha = 0; linha < 2; linha++)
        {
            int soma = 0;

            for (int coluna = 0; coluna < 4; coluna++)
            {
                soma += notas[linha, coluna];
            }

            double media = soma / 4.0;

            Console.WriteLine("Média do aluno " + (linha + 1) + ": " + media);
        }
    }
}