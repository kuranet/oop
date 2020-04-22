using System;

namespace lab5._2
{
    class Str
    {
        public string str { get; protected set; }
        public double Len { get; protected set; }
        public bool error { get; protected set; }

        public  Str() { str = ""; Len = 0; error = false; }
        public Str(string s) { str = s; Len = str.Length;  error = false; }

        public virtual void Lenght()
        {
            Len = str.Length;
        }
        public virtual void Processing() {}
    }
}
