using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    public class Third : Second
    {
        ~Third()
        {
            Console.WriteLine("Destructor of Third Called");
        }
    }
}
