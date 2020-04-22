using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Section : Line
    {
        public Section() : base(new Tochka(), new Tochka()) { }
        public Section(Tochka s, Tochka e) : base(s, e) { }
        
        public Section Increase2()
        { 
            Tochka tempStart = new Tochka( start * 2);
            Tochka tempEnd = new Tochka(end * 2);
            return new Section(tempStart, tempEnd);
        }
        public Tochka StartCoord => start;
        public Tochka EndCoord => end;

    }
}
