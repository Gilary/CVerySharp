using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books
{
    public abstract class Funny : Book
    {
        protected Funny()
        {
        }

        protected Funny(int weight, string titel = null)
          : base(weight, titel)
        {
        }

        protected Funny(int weight, DateTime date, string titel = null)
            : base(weight, date, titel)
        {
        }
    }
}
