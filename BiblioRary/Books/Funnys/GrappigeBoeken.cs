using BiblioRary.Books.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioRary.Books.funnys
{
    public class GrappigeBoeken : Funny, IFunny
    {
        public GrappigeBoeken(int weight)
            : base(weight, "DaddyDayCare")
        {
        }
        public void makeSmile()
        {
            Console.WriteLine("whahaha");
        }
        public override void Reaction()
        {
            makeSmile();
        }
    }
}
