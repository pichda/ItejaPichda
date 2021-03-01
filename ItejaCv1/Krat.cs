using System;

namespace ItejaCv1
{
    public class Krat : Uzel
    {
        public Krat(Uzel left, Uzel right)
        {
            this.left = left;
            this.right = right;
        }

        public override void write_prefix()
        {
            Console.Write("(* ");
            left.write_prefix();
            Console.Write(" ");
            right.write_prefix();
            Console.Write(" )");
        }

        public override void write_infix()
        {
            Console.Write("( ");
            left.write_infix();
            Console.Write(" * ");
            right.write_infix();
            Console.Write(" )");
        }

        public override void write_postfix()
        {
            left.write_postfix();
            Console.Write(" ");
            right.write_postfix();
            Console.Write(" *");
        }

        public override double eval()
        {
            return left.eval() * right.eval();
        }
    }
}