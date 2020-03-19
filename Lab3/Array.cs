using System;

namespace Lab3
{
    class Array
    {
        private int[,] arr;
        private int rows, columns;
        private bool error;
        private double sumSquare;


        public Array(int r, int c)
        {
            arr = new int[r, c];
            rows = r;
            columns = c;
            GenData();
            error = false;
            sumsq();
        }
        private void GenData()
        {
            Random rn = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rn.Next(0, 25);
                }
            }
        }
        public int this[int index]
        {
            get
            {
                --index;
                if (ok(index))
                {
                    error = false;
                    int sum = 0;
                    for (int i = 0; i < rows; i++)
                        sum += arr[i, index];
                    return sum;
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
        }
        private bool ok(int index)
        {
            if (index >= 0 & index < columns) return true;
            return false;
        }

        private void sumsq()
        {
            double sumsq = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sumsq += Math.Pow(arr[i, j], 2);
                }
            }

            sumsq /= rows * columns;
            sumSquare = Math.Sqrt(sumsq);
        }
         public double SumSquare {
            get
            {
                return sumSquare;
            }
         }
    }
}
