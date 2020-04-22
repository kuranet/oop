using System;


namespace lab5._2
{
    class Letters: Str
    {
        public Letters() : base() { }
        public Letters(string s) : base(s) { }


        public override void Lenght()
        {
            int lettersInStr = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    lettersInStr++;
                }
                else { error = true; }
            }
            Len = lettersInStr;
        }

        public override void Processing()
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            this.str = new string(charArray);
            this.Lenght();
        }
    }
}
