﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books.Interface
{
    public interface IBook
    {
        string Titel { get; set; }
        string Genre { get; set; }
        bool IsTaken { get; set; }
    }
}
