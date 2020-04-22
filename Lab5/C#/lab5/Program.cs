using System;

#region Опис класів

#region Базовий клас
//Лінії: координати початку та кінця, конструктор з
//параметрами, метод обчислення довжини лінії
#endregion

#region Похідний клас
/*Відрізки: конструктор з параметрами, метод
збільшення відрізка у 2 рази, методи отримання
даних об’єкту*/
#endregion

#endregion

#region Завдання
//Описати класи, об’єкт похідного класу;
//вивести дані об’єкта;
//обчислити і вивести довжину
#endregion


namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Section var0 = new Section (new Tochka(),new Tochka(2, 5) );
            Line var1 = new Section(new Tochka(6,0), new Tochka(6, 3));
            Line var2 = new Line(new Tochka(1,1), new Tochka(4, 10));
            
            var0 = var0.Increase2();

            Console.WriteLine("X: " + var0.EndCoord.XCoord + " Y: " + var0.EndCoord.YCoord);
            Console.WriteLine("Lengths: ");
            Console.WriteLine(var0.Length);
            Console.WriteLine(var1.Length);
            Console.WriteLine(var2.Length);
            Console.ReadKey();
        }
    }
}
