using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            MathExpression[] expression = new MathExpression[50];
            double[] result = new double[expression.Length];
            string[] loglist = new string[expression.Length];

            var rand = new Random();
            for (int i = 0; i < expression.Length; i++)
                expression[i] = new MathExpression(rand.Next(-5, 5), rand.Next(-5, 5), rand.Next(15, 25), rand.Next(-5, 5));

            for (int i = 0; i < expression.Length; i++)
            {
                try
                {
                    result[i] = expression[i].GetRes();
                    loglist[i] = "Success";
                }
                catch (Exception ex)
                {
                    loglist[i] = ex.Message;
                }
            }
            ExampleFunction();

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Ann\oop\Lab6\C#\lab6\loglist.txt"))
            {
                foreach (string log in loglist)
                {
                    
                    file.WriteLine(log);
                    
                }
            }
        }

        static void ExampleFunction()
        {
            double res;
            string[] loglist = new string[3];
            //Root Expression must be >= 0
            try
            {
                res = new MathExpression(1, 2, 22, -30).GetRes();
                loglist[0] = "Success";
            }
            catch (Exception ex)
            {
                loglist[0] = ex.Message;
            }
            //Division by 0 by parameter b
            try
            {
                res = new MathExpression(1, 0, 3, 4).GetRes();
                loglist[1] = "Success";
            }
            catch (Exception ex)
            {
                loglist[1] = ex.Message;
            }
            //Denominator is 0
            try
            {
                res = new MathExpression(-6, 1, 0, 12).GetRes();
                loglist[2] = "Success";
            }
            catch (Exception ex)
            {
                loglist[2] = ex.Message;
            }
        }
    }
}
