using System;

namespace ClassLib

{
    public class IntArray
    {
        public delegate void OverRangeHandler(string message);
        public event OverRangeHandler OverRange;

        short[,] arr;
        int rows;
        int columns;

        public IntArray(int n, int m)
        {
            if (n <= 0 || m <= 0)
                throw new ArithmeticException("Wrong parametrs for array");
            rows = n;
            columns = m;
            arr = new short[n, m];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = (short)rnd.Next(2000,3000);
                }
            }
        }

        public double GetSum()
        {
            short sum =0;
            int temp = arr[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += arr[i, j];
                    if ((temp > 0 && arr[i, j] > 0 && sum < 0) || (temp < 0 && arr[i, j] < 0 && sum > 0))
                    {
                        OverRange?.Invoke("OverRanged");
                        break;
                    }
                    temp = arr[i, j];
                }
            }
            return sum;
        }
    }
}
