//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.Inheritance
//{
//     interface ICalc1
//    {
//        int Add(int x, int y);

//        int Subtract(int x, int y);
       

//    }
//    interface ICalc2: ICalc1
//    {
//        int Multiply(int x, int y);

//        int Divide(int x, int y);


//    }
//    //Interface Implementation
//    public class Calculator : ICalc1, ICalc2  //Multiple Inheritance like
//    {
//        public int Add(int x, int y)
//        {
//            return x + y;
//        }
//        public int Subtract(int x, int y)
//        {
//            return (x - y);
//        }
//        //Explicit Interface Implementation
//        int ICalc1.Subtract(int x, int y)
//        {
//            Console.WriteLine("ICalc1 Subtract version");
//            return x + (~y + 1);
//        }
//        int ICalc2.Subtract(int x, int y)
//        {
//            Console.WriteLine("ICalc2 Subtract version");
//            return (~y + 1)+x;
//        }

//        public int Divide(int x, int y)
//        {
//            return (x / y);
//        }
//        public int Multiply(int x, int y)
//        {
//            return (x * y);
//        }

//    }
//    internal class InterfaceDemo
//    {
//        public static void Main(string[] args)
//        {
//            Calculator calc = new Calculator();
//            //Console.WriteLine(calc.Add(40,20));
//            Console.WriteLine(calc.Multiply(10,10));
            
//            //We can create reference
//            ICalc1 icalc1 =calc;
//            Console.WriteLine(icalc1.Subtract(50,30));
//            //Console.WriteLine(icalc1.Multiply(10,20));//invalid
            
//            ICalc2 icalc2 =calc;
//            Console.WriteLine(icalc2.Multiply(20,10));
//            Console.WriteLine(icalc2.Subtract(20, 10));
//        }
//    }
//}
