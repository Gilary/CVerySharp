using BiblioRary.Books.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books.Romantics
{
    public class AchtienPlusBoeken : Romantic, IRomantic
    {
        // public FiftyShadesOfPeach(int weight)
        public AchtienPlusBoeken(int weight)
            : base(weight, "FiftyShadesOfPeach")
        {
        }

        public void kiss()
        {
            Console.WriteLine("mwuh mwuah oelala");
        }
    }
}
