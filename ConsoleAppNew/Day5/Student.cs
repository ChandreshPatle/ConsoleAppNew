using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day5
{
    internal class Student
    {
        private int _RollNo;
        private String _Name;
        private static string _CollegeName;
        private float _Mark;

        static Student()
        {
            _CollegeName = "C-DAC";
        }

        //static & Read-only
        public static string CollegeName
        {
            get { return _CollegeName; }
        }
        public int RollNo
        {
            set {
                if (value > 0)
                    _RollNo = value;
                else
                {
                    Console.WriteLine("Only +ve value allowed for rollno");
                }
            }
            get { return _RollNo; }
        }
        //Ready-write property
        public String Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        //write-only property
        public float SetMark
        {
            set { _Mark = value; }
            
        }

        //read-only property
        public float GeMark
        {
            get { return _Mark; }
        }
        //auto implemented property

        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
