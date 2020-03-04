using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Stroka
    {
        char[] Strochka;
        public Stroka(string str)
        {
            Strochka = str.ToCharArray();
        }

        public char[] getStrochka()
        {
            return Strochka;
        }

        public void Frequency(char find, ref int kolvo, ref int lenght)
        {
            for (int i = 0; i < Strochka.Length; i++)
            {
                if (Strochka[i] == find)
                {
                    kolvo++;
                }
            }
            lenght += Strochka.Length;
        }
        public static bool IsSame(char[] str1, char[] str2)
        {
            bool issame = true;
            
            if (str1.Length == str2.Length)
            {
                int i = 0;
                while (issame == true && i < str1.Length)
                {
                    if (str1[i] != str2[i])
                        issame = false;
                    i++;
                }
            }
            else issame = false;
            return issame;
        }

    }
}
