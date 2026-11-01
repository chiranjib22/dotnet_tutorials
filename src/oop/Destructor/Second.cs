using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class Second : First
    {
        ~Second()
        {
            Console.WriteLine("Destructor of Second called");
        }
    }
}
