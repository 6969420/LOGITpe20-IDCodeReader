using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string somestring = "interpolation";
            Console.WriteLine($"{somestring.Length}");
            string newstring = somestring.Substring(0, 5);
            Console.WriteLine(newstring);
            string polationstring = somestring.Substring(5, 8);
            Console.WriteLine(polationstring);
        }
    }
}
