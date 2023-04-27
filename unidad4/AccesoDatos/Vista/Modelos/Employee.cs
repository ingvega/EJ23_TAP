using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public String LastName { get; set; }

        public String Title { get; set; }

        public String FullName { 
            get {
                return FirstName + " " + LastName;
            } 
        }
    }
}
