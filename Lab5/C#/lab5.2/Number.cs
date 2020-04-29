using System;


namespace lab5._2
{
    class Number: Str
    {
        public Number() : base() { }
        public Number(string s) : base(s) { }

        public override void Lenght()
        {
            int numbersInStr = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i]))
                {
                    numbersInStr++;
                }
                else { error = true; }
            }
            Len = numbersInStr;
        }

        public override void Processing()
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str[i]))
                {
                    str = str.Insert(++i, str[i-1].ToString());
                }
            }
            this.Lenght();
        }
    }
}
