using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /*
     Клас-рядок, який містить методи, необхідні для роботи методів класу-контейнера.
Клас-контейнер, який є абстракцією тексту та складається з об’єктів класу-рядка та методів
додавання рядка до тексту, \/
видалення рядка з тексту, \/
очищення тексту, \/
повернення чаcтоти появи заданого символу (кількість символів/загальна кількість символів), \/
заміни заданого підрядка в тексті іншим заданим підрядком, \/
пошук та видалення дублюючих рядків.\/
*/   
    
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            var str1 = new Stroka("23423aaaadfkg");
            text.AddString(str1);
            str1 = new Stroka("23423aaaadfkg");
            text.AddString(str1);
            str1 = new Stroka("sdfghak");
            text.AddString(str1);
            str1 = new Stroka("fdjgsdfkjfgnldfkg");
            text.AddString(str1);
            str1 = new Stroka("fdjgsdfkjfgnldfkg");
            text.AddString(str1);
            int n = 2;
            text.RemoveString(n);
            text.Output();
            text.StrChange(3,"dkj");
            text.SameString();
            text.Output();
            char find = 'a';
            float freq = 0;
            text.TextFreq(find,ref freq);
            text.TextClean();
            Console.WriteLine(freq);
            Console.ReadKey();
            
        }
    }
}
