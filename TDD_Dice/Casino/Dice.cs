using System;
using System.Reflection.Metadata;

namespace Casino
{
    public class Dice
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Dice()
        {
            
        }

        public void Roll()
        {
            var rand = new Random();
            First = rand.Next() % 5 + 1;
            Second = rand.Next() % 5 + 1;
        }

        public override string ToString() => $"{First}-{Second}";
    }
}
