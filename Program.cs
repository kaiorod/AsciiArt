using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("  ||  ||  ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("  \\\\");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("()");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("//  ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" //");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("(__)");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\\\\ ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ||    || ");
            Console.ResetColor();

        }
    }
}
