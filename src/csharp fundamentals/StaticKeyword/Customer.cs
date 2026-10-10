using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public class Customer
    {
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        private string MachineName = "";
        //public bool IsNotEmpty(string value)
        //{
        //    if (value.Length > 0) return true;
        //    return false;
        //}
        public Customer()
        {
            MachineName = CommonTask.GetComputerName();
        }
        public void Insert()
        {
            
            if(CommonTask.IsNotEmpty(CustomerCode) && CommonTask.IsNotEmpty(CustomerName))
            {
                // Insert the data
            }
        }
    }
}
