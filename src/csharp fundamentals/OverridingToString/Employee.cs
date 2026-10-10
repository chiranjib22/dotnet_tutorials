using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingToString
{
    public class Employee
    {
        public string? FirstName;
        public string? LastName;

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
