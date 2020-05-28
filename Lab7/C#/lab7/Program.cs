using System;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                float node = (float)(rnd.NextDouble() * rnd.Next(1, 10));
                Console.WriteLine("New node: " + node);
                myList.AddAfterSecond(node);
                myList.PrintList();
            }

            int k = myList.FindCount(3.14f);

            myList.DeleteGreater();
            myList.PrintList();

            Console.ReadKey();
        }
    }
}
