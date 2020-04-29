using System;
/*Базовий клас "Рядки": віртуальні функції
обчислення довжини і обробки рядка.

Похідний клас "Літери": значення рядка,
конструктор з параметром, 
віртуальні функції обчислення довжини
і перевертання рядка . 

Похідний клас "Цифри": значення рядка, 
конструктор з параметром, 
віртуальні функції обчислення довжини 
і збільшення рядка у два рази

Описати класи, об’єкти цих класів; обчислити
та вивести довжину; вивести оброблені
рядки, використовуючи поліморфізм
(вказівну/посилання базового класу)
 */
namespace lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Str str = new Str("dfghjkpoiuytvb");
            Letters let = new Letters("srfdhjklti");
            Number num = new Number("12345");

            Console.WriteLine("Length Str: " + str.Len);
            Console.WriteLine("Length Letters: " + let.Len);
            Console.WriteLine("Length Number: " + num.Len);

            Console.WriteLine();

            str.Processing();
            let.Processing();
            num.Processing();
            Console.WriteLine("After processing Str: " + str.str);
            Console.WriteLine("After processing Letters: " + let.str);
            Console.WriteLine("After processing Number: " + num.str);
            Console.WriteLine("Length Number: " + num.Len);

            Console.ReadKey();
        }
    }
}
