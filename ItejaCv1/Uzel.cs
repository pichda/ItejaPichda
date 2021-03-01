using System;

namespace ItejaCv1
{
    public class Uzel
    {
        protected Uzel left;
        protected Uzel right;

        public Uzel()
        {
            this.left = null;
            this.right = null;
        }

        public virtual void add_left(Uzel left)
        {
        }

        public virtual void add_right(Uzel right)
        {
        }

        public virtual void write_prefix()
        {
            Console.WriteLine("err prefix");
        }

        public virtual void write_infix()
        {
            Console.WriteLine("err infix");
        }

        public virtual void write_postfix()
        {
            Console.WriteLine("err postfix");
        }

        public virtual double eval()
        {
            throw new Exception("error");
        }
    }
}