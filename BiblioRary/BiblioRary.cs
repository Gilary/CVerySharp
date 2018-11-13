using BiblioRary.Books.Interface;
using BiblioRary.Books.Romantic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary
{
    public class BiblioRary
    {
        private static BiblioRary _instance;
        private readonly IList<IBook> books = new List<IBook>();

        public static BiblioRary Instance()
        {
            if (_instance == null) _instance = new BiblioRary();

            return _instance;
        }

        public void FillBiblioRary() 
        {
            Console.WriteLine("ik ben een book");
        }
    }
}
