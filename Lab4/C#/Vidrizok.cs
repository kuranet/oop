using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Vidrizok
    {
        Tochka start;
        Tochka end;
        public double Dlina { get; private set; }

        public Vidrizok() : this(new Tochka(), new Tochka()) { }
        public Vidrizok(Tochka s, Tochka e)
        {
            start = s;
            end = e;
            Getdlina();
        }
        public Vidrizok(double x1, double y1, double x2, double y2)
        {

            start = new Tochka(x1, y1);
            end = new Tochka(x2, y2);
            Getdlina();
        }
        public Vidrizok(Vidrizok obj) : this(obj.start, obj.end) { }
        public Vidrizok(Tochka s, double x2, double y2)
        {
            start = s;
            end = new Tochka(x2, y2);
            Getdlina();
        }
        public Vidrizok(double x1, double y1, Tochka e)
        {
            start = new Tochka(x1, y1);
            end = e;
            Getdlina();
        }
        void Getdlina()
        {
            Dlina = Math.Sqrt(Math.Pow(start.x - end.x, 2) + Math.Pow(start.y - end.y, 2));
        }
        public static Vidrizok operator +(Vidrizok obj1, Vidrizok obj2)
        {
            Vidrizok result = new Vidrizok();
            result.start = obj1.start + obj2.start;
            result.end = obj1.end + obj2.end;
            result.Getdlina();
            return result;
        }
        public static Vidrizok operator -(Vidrizok obj1, Vidrizok obj2)
        {
            Vidrizok result = new Vidrizok();
            result.start = obj1.start - obj2.start;
            result.end = obj1.end - obj2.end;
            result.Getdlina();
            return result;
        }
        public void Sdvig(double x, double y)
        {
            this.start = this.start + new Tochka(x, y);
            this.end = this.end + new Tochka(x, y);
            this.Getdlina();
        }
    }
}
