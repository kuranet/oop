using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;            
            Increment(out n);
            Console.WriteLine("new n = {0}", n);
            bool k = Compare();
            Console.WriteLine(k);
            Console.ReadKey();
                            
        }

        public static void Increment(out int n)
        {
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int mask = 1;
            if (n == 0) { n = -1; }
            else { 
                while (Convert.ToBoolean(n & mask))
                {
                     n &= ~mask;
                    mask = mask << 1;
                }
                n |= mask;
            }
        }
        public static bool Compare()
        {
            int n, m;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            m = Convert.ToInt32(Console.ReadLine());
            bool output = false;
            char res = '=';
            if (!Convert.ToBoolean(n >> 31) && !Convert.ToBoolean(m >> 31))
            {
                for (int i = sizeof(int) * 8 - 1; i >= 0; --i)
                {
                    int z = 1 << i;
                    res = res == '=' ? (
                        Convert.ToBoolean(n & z ^ m & z) ? (Convert.ToBoolean(n & z) ? '>' : '<') : '='
                    ) : res;
                } 
            }
            else if (Convert.ToBoolean(n >> 31) && Convert.ToBoolean(m >> 31))
            {
                for (int i = sizeof(int) * 8 - 1; i >= 0; --i)
                {
                    int z = 1 << i;
                    res = res == '=' ? (
                        Convert.ToBoolean(~n & z ^ ~m & z) ? (Convert.ToBoolean(~n & z) ? '<' : '>') : '='
                    ) : res;
                }
            }
            else if (!Convert.ToBoolean(n >> 31) && Convert.ToBoolean(m >> 31)) res = '>'; else res = '<';
            Console.WriteLine("{0} {1} {2}", n, res, m);
            output = (res == '=') ? (false) : (res == '>'? false : true);
            return output;
        }
       
    }    
}
