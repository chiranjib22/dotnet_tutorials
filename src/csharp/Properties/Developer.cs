using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Developer
    {
        public int Id { get; set; } // those properties are create private backing field automatically by the compiler,
                                    // so we don't need to create private data members for those properties.
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Skill { get; set; }
    }
}
