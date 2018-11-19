using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books
{
    public abstract class Scary : Book
    {
        protected Scary()
        {
        }

        protected Scary(int weight, string titel = null)
            : base(weight, titel)
        {
        }

        protected Scary(int weight, DateTime date, string titel = null)
            : base(weight, date, titel)
        {
        }
    }
}
