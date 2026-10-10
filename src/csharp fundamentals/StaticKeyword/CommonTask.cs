using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public static class CommonTask
    {
        public static bool IsNotEmpty(string value)
        {
            return (value.Length > 0) ? true : false; 
        }

        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }
    }

}
