using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Line
    {
        protected Tochka start;
        protected Tochka end;
        public double Length { get; private set; }
        public Line() :this(new Tochka(),new Tochka()){ }
        public Line(Tochka s, Tochka e)
        {
            start = s;
            end = e;
            Length = GetLength();
        }
        protected double GetLength()
        {
            double len = Math.Sqrt(Math.Pow((start.x-end.x),2)+ Math.Pow((start.y - end.y), 2));
            return len;
        } 
    }
}
