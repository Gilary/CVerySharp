using System;

namespace BiblioRary
{
    class Program
    {
        static void Main(string[] args)
        {
            var biblioRary = BiblioRary.Instance();
            biblioRary.FillBiblioRary();
            biblioRary.PrintInfo();
            Console.ReadLine();
        }
    }
}
