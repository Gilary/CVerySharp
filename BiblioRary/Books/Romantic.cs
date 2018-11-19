using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books
{
    public abstract class Romantic : Book
    {
        protected Romantic()
        {
        }

        protected Romantic(int weight, string titel = null)
          : base(weight, titel)
        {
        }

        protected Romantic(int weight, DateTime date, string titel = null)
            : base(weight, date, titel)
        {
        }

        //public int NumberOfHiddenLetters { get; set; }
    }
}
