using BiblioRary.Books;
using BiblioRary.Books.funnys;
using BiblioRary.Books.Interface;
using BiblioRary.Books.Romantics;
using BiblioRary.Books.Scarys;
using System;
using System.Collections.Generic;
using System.Linq;
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
            books.Add(new AchtienPlusBoeken(50));
            books.Add(new AchtienPlusBoeken(50));
            books.Add(new GrappigeBoeken(100));
            books.Add(new EngeBoeken(80));
            books.Add(new EngeBoeken(80));
        }

        public void AddEngeBoeken(int weight)
        {
            books.Add(new EngeBoeken(weight));
        }
        public void PrintInfo()
        {
            PrintNumberOfBooks();

            PrintBookInfo();
        }

        public void PrintNumberOfBooks()
        {
            var type = typeof(Book);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsSubclassOf(type) && !p.IsAbstract);

            foreach (var typeOfBooks in types)
                Console.WriteLine(
                    $"Type boek: {typeOfBooks.Name}, " +
                    $"Aantal boeken: {books.Count(x => x.GetType() == typeOfBooks)}");
        }

        private void PrintBookInfo()
        {
            Console.WriteLine("Boeken in the Bibliorary");
            foreach (var book in books)
            {
                Console.WriteLine($"Type boeken: {book.GetType().Name}. " +
                                  $"Titel: {book.Titel}, " +
                                  $"Gewicht: {book.Weight}.");
                Console.Write("Reaction:");
                book.Reaction();
            }
        }

        public int GetNumberOfBooks()
        {
            return books.Count;
        }

        //public void AddFiftyShadesOfPeach(int weight)
        //{
        //    books.Add(new FiftyShadesOfPeach(weight));
        //}
    }
}
