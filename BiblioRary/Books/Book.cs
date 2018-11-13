using BiblioRary.Books.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books
{
    public class Book : IBook
    {
        public string Titel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Genre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsTaken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
