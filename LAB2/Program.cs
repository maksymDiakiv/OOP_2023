using System;
using LAB2.Constructions;

namespace LAB2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, "Bric");
            Console.WriteLine(construction.Entrances);
        }
    }
}
