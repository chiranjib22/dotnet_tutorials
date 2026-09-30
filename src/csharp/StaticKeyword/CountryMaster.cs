using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public class CountryMaster
    {
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        private string ComputerName
        {
            get
            {
                return CommonTask.GetComputerName();
            }
        }
        public void Insert()
        {
            if(CommonTask.IsNotEmpty(CountryName) && CommonTask.IsNotEmpty(CountryCode))
            {

                // logic to insert the country details into the database
                // ComputerName property tells from which computer the Record is being inserted
            }
        }
    }
}
