using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Employee
    {
        private int _EmpId; // private data member
        private string? _EmpName;

        public int EmpId    // read-write property
        {
            // the default accessibility specifier of the accessor is the same as the accessibility of the property.
            set // means public set{}
            {
                _EmpId = value; // here value recieve the value which is assigned to the property
            }
            get // public get{}
            {
                return _EmpId;
            }
        }
        public string EmpName // read-write property
        {
            set
            {
                _EmpName = value;
            }
            get
            {
                return _EmpName ?? string.Empty;
            }
        }
    }
}
