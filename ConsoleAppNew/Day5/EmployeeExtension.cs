using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day5
{
    internal static class EmployeeExtension
    {
        public static void DisplayEmployee(this Employee employee)
        {
            Console.WriteLine($"Employee:{employee.EmpCode},{employee.FullName}");
        }
    }
}
