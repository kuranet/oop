using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /*Відрізки: координати початку та кінця відрізка, конструктор за умовчанням,
    конструктор з параметрами, конструктор копіювання, метод
    обчислення довжини відрізка методи отримання даних відрізка,
    перевантаження операторів додавання, вирахування*/

    /*Описати клас, три об'єкти W1, W2, W3,
    використовуючи різні конструктори; "зсунути"
    об’єкт W3 на 3 одиниці ліворуч по вісі ОХ; "скласти"
    об’єкти W3 та W2 і результат "помістити" до об’єкта W1;
    результат дій вивести на*/



    class Program
    {
        static void Main(string[] args)
        {
            Tochka start1 = new Tochka();            
            Tochka end1 = new Tochka(3, 9);
            Tochka start2 = new Tochka(end1);
            Vidrizok W1 = new Vidrizok(start1, end1);            
            Vidrizok W2 = new Vidrizok(start2,8,5);
            Vidrizok W3 = new Vidrizok(W2);
            W3.Sdvig(3, 0);
            W3 = W1 + W2;
        }
    }
}
