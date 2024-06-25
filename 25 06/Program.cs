using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] rimskArray = new string[4000];
        for (int i = 1; i <= 3999; i++)
        {
            rimskArray[i - 1] = ToRimsk(i);
        }
        for (int i = 0; i < 3999; i++)
        {
            Console.WriteLine($"{i + 1}: {rimskArray[i]}");
        }
    }
    static string ToRimsk(int number)
    {
        StringBuilder result = new StringBuilder();

        string[] rimskSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        for (int i = 0; i < values.Length; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                result.Append(rimskSymbols[i]);
            }
        }

        return result.ToString();
    }
}

// dvumerniy massiv 

/*using System;

class Program
{
    static void Main()
    {
        int N = 5; 
        int M = 6; 

        int[,] array = new int[N, M];
        FillArray(array, N, M);
        PrintArray(array, N, M);
    }

    static void FillArray(int[,] array, int N, int M)
    {
        int num = 1;
        for (int j = 0; j < M; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < N; i++)
                {
                    array[i, j] = num++;
                }
            }
            else
            {
                for (int i = N - 1; i >= 0; i--)
                {
                    array[i, j] = num++;
                }
            }
        }
    }

    static void PrintArray(int[,] array, int N, int M)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " "); 
            }
            Console.WriteLine();
        }
    }
}

*/