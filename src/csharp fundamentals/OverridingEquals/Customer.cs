using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingEquals
{
    public class Customer
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override bool Equals(object? obj)
        {
            // if the passed object is null, return false
            if (obj == null) return false;

            // if the passed object is not the same type as calling object , return false
            if (!(obj is Customer)) return false;

            return (this.FirstName == ((Customer)obj).FirstName) 
                && (this.LastName == ((Customer)obj).LastName); 
        }

        public override int GetHashCode() // equals object return same hashcode
        {
            return this.GetHashCode();
        }
    }
}
