using System;

class Solution
{

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr)
    {
        int min = -100;
        int max = 100;
        int sum1 = 0;
        int sum2 = 0;
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i][j] >= -100 && arr[i][j] <= 100)
                {
                    if (i == j)
                    {
                        sum1 = sum1 + arr[i][j];
                    }
                }
            }
        }

        int z = arr.Length - 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i][z] >= -100 && arr[i][z] <= 100)
            {
                sum2 = sum2 + arr[i][z];

            }
            z--;
        }
        res = sum1 - sum2;
        return Math.Abs(res);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        Console.WriteLine(result);
        Console.ReadLine();

    }
}
