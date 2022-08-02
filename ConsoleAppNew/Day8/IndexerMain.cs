//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.Day8
//{
//    class Employee
//    {
//        long[] _ContactNo;
//        public Employee()
//        {
//            _ContactNo = new long[5]; 
//        }
//        //Indexer
//        public long this[int index]
//        {
//            get { return _ContactNo[index]; }
//            set { _ContactNo[index] = value; }
//        }
//        /*
//        //INdexer Overloading
//        public long this[int row,int col]
//        {
//            get { return _ContactNo[index]; }
//            set { _ContactNo[index] = value; }
//        }
//        */

//        //Readonly property to get ContactNo length
//        public long ContactNoLength
//        {
//            get => _ContactNo.Length;
//        }
//    }
//    internal class IndexerMain
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
//            employee[0] = 8600409685;//write operaation,set accessor
//            long contactNo = employee[0];//read operation, get accessor
//            Console.WriteLine($"{contactNo}");
//            //string str = "gjghfj";
//            //Console.WriteLine(str[3]);

//            for (int i = 0; i < employee.ContactNoLength; i++)
//            {
//                Console.WriteLine($"Input contact no {i+1}:");
//                employee[i] = Int64.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Employee Contact details are:");
//            for (int i = 0; i < employee.ContactNoLength; i++)
//            {
//                Console.WriteLine(employee[i]);
//            }




//        }
//    }
//}
