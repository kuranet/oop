using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Tochka
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public Tochka(double s, double e)
        {
            x = s;
            y = e;
        }
        public Tochka(): this(0,0) { }
        public Tochka(Tochka obj): this(obj.x, obj.y) { }
        public static Tochka operator +(Tochka obj1, Tochka obj2)
        {
            Tochka result = new Tochka();
            result.x = obj1.x + obj2.x;
            result.y = obj1.y + obj2.y;
            return result;
        }
        public static Tochka operator -(Tochka obj1, Tochka obj2)
        {
            Tochka result = new Tochka();
            result.x = obj1.x - obj2.x;
            result.y = obj1.y - obj2.y;
            return result;
        }
    }
}
