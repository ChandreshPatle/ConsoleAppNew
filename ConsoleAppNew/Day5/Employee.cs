using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day5
{
    internal class Employee
    {
        int _EmpCode;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Read only Expression Body Defn property 6.0 or above
        public string FullName => $"{FirstName} {LastName}";

        //Read-Write Expression Body Defn property 7.0 or above
        public int EmpCode{
            get => _EmpCode;
            set => _EmpCode = value;
        }
    }
}
