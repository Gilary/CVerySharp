using BiblioRary.Books.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books
{
    public class Book : IBook
    {
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int Weight { get; set; }
        public bool IsTaken { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        protected Book()
        {
        }
        protected Book(int weight, string name = null)
        : this(weight, DateTime.Now, name)
        {
        }
        protected Book(int weight, DateTime date, string titel = null)
        {
            Weight = weight;
            Date = date;
            Titel = titel;
        }
        //public Book(int weight, DateTime date, string titel = null)
        //{
        //    Weight = weight;
        //    Date = date;
        //    Titel = titel;
        //}
    }
}
