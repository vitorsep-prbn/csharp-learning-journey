public class somade1ateN
{
    public static void Executar()
    {

        int total = 0;

        for (int i = 1; i <= 3; i++)
        {
            int j = 1;

            while (j <= 2)
            {

                if ((i + j) % 2 == 0)
                {
                    total = total + i;
                }  
                else
                {    
                    total = total + j;
                }
                
                j++;
            }



        }
        Console.WriteLine("Resultado" +total);








    }
}