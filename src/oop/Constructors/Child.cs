using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Child : Parent
    {
        public Child() //: base("Hello")
        {
            Console.WriteLine("Child class public constructor is called!");
        }
    }
}
