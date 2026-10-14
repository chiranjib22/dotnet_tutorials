using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
