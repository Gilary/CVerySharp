using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Person.Interface
{
    public interface IPerson
    {
        string Name { get; set; }
        bool RentBook { get; set; }
        bool ReturnBook { get; set; }
    }
}
