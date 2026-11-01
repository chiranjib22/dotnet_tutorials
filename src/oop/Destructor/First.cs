using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class First
    {
        ~First()
        {
            Console.WriteLine("Destructor of first called");
        }
    }
}
