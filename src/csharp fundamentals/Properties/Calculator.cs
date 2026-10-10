using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Calculator
    {
        int _Num1, _Num2, _Result; // by default its all are private data members

        // write only properites
        public int SetNum1
        {
            set
            {
                _Num1 = value;
            }

            private get // accessiable inside the class
            {
                return _Num1;
            }
        }
        public int SetNum2
        {
            set
            {
                _Num2 = value;
            }
        }


        // read only properties
        public int GetResult
        {
            private set // means we cannot access the GetResult = 10; from outside of the class, but inside the class we can access it.
            {
                _Result = value;
            }
            get
            {
                return _Result;
            }
        }


        public void Add()
        {
            _Result = _Num1 + _Num2;
            GetResult = 100; // here GetResult set property is private but it is accessible inside the class, so we can set the value of GetResult property inside the class.
        }
        public void Sub()
        {
            _Result = _Num1 - _Num2;
            // GetResult = SetNum1 + SetNum2; // here SetNum1 and SetNum2 are both write only properties,
            // so we cannot access them from outside of the class, but inside the class we can access them if we use the private get 
        }
        public void Mul()
        {
            _Result = _Num1 * _Num2;
        }
        public void Div()
        {
            _Result = _Num1 / _Num2;
        }

    }
}
