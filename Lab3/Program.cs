using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Клас інкапсулює двовимірний масив з елементів цілого типу.
//Створити одновимірний індексатор, що повертає суму всіх елементів
//заданого індексом стовпця масиву.Створити властивість, доступну
//для читання закритого елементу-даного, що містить
//середньоквадратичне значення всіх елементів масиву

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3 , 4);
            array.GenData();
            int sum;
            sum = array[2];
            double sqrt;
            sqrt = array.SumSquare;
        }
    }
}
