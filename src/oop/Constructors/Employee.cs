using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        // User defined default constructor
        public Employee()
        {
            Id = 100;
            Age = 30;
            Address = "Nalapara";
            IsPermanent = false;
            Name = "Thakur";
        }
    }
}
