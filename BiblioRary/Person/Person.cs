using BiblioRary.Person.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Person
{
    public class Person : IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool RentBook { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ReturnBook { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
