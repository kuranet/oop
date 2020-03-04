using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Text
    {
        Stroka[] Stroki;
        int size = 0;

        public void AddString(Stroka stroka)
        {
            Array.Resize(ref Stroki, ++size);
            Stroki[size - 1] = stroka;
        }
        public void RemoveString(int n)
        {
            var data = new Stroka[size - 1];
            for (int i = 0; i < n-1; i++)
            {
                data[i] = Stroki[i];
            }
            for(int i = n; i < size; i++)
            {
                data[i-1] = Stroki[i];
            }
            Array.Resize(ref Stroki, --size);
            Stroki = data;
        }
        public void TextClean()
        {
            this.Stroki = new Stroka[0];
            size = 0;
        }
        public void TextFreq(char find, ref float freq)
        {
            int kolvo = 0;
            int length = 0;
            for (int i = 0; i < size; i++)
            {
                Stroki[i].Frequency(find, ref kolvo, ref length);
            }
            freq = (float)kolvo / length;
        }
        public void SameString()
        {
            bool issame = true;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {              
                    issame = Stroka.IsSame(Stroki[i].getStrochka(), Stroki[j].getStrochka());
                    if (issame)
                    {
                        RemoveString(i+1);
                        i--;
                        RemoveString(j);
                        j-=2;
                    }
                }
            }
        }
        public void StrChange(int n, string str)
        {
            Stroki[n - 1] = new Stroka(str);
        }

        public void Output()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Stroki[i].getStrochka());
            }
            Console.WriteLine();
        }


    }
}
