using System;
using ClassLib;


namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            double[] res = new double[5];
            MyMath.Operation operation = MyMath.Add;
            res[0] = math.DoMath(14,15, operation);
            operation = MyMath.Subtract;
            res[1] = math.DoMath(14, 15, operation);
            operation = MyMath.Multiply;
            res[2] = math.DoMath(14, 15, operation);
            operation = MyMath.Divide;
            res[3] = math.DoMath(14, 15, operation);
            operation = MyMath.Divide;
            res[4] = math.DoMath(14, 15, operation);

            Console.WriteLine(math.MathAdd(2,3));

            IntArray Arr = new IntArray(4,4);
            Arr.OverRange += new IntArray.OverRangeHandler(DisplayMessage);

            double sum = Arr.GetSum();
            Console.ReadKey();
        }

        static void DisplayMessage(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
