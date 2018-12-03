using BiblioRary.Books.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books.Scarys
{
    public class EngeBoeken : Scary, IScary
    {
        public EngeBoeken(int weight)
            : base(weight, "Waah")
        {
        }
        public void runsAway()
        {
            Console.WriteLine("*run* Waah *run*");
        }
        public override void Reaction()
        {
            runsAway();
        }
    }
}
