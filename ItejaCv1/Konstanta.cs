using System;

namespace ItejaCv1
{
    public class Konstanta : Uzel
    {
        private int value;

        public Konstanta(int value)
        {
            this.value = value;
        }

        public override void write_prefix()
        {
            Console.Write(value);
        }

        public override void write_infix()
        {
            Console.Write(value);
        }

        public override void write_postfix()
        {
            Console.Write(value);
        }

        public override double eval()
        {
            return value;
        }
    }
}