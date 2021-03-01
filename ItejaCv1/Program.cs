using System;

namespace ItejaCv1
{
    //public class podmineny_vyraz : Uzel
    //{
    //}

    internal class Program
    {
        private static void Main(string[] args)
        {
            Soucet strom = new Soucet(new Konstanta(2), new Krat(new Konstanta(3), new Konstanta(4)));

            strom.write_infix();
            Console.WriteLine();
            strom.write_prefix();
            Console.WriteLine();
            strom.write_postfix();
            Console.WriteLine();

            Console.Write(strom.eval());
        }
    }
}