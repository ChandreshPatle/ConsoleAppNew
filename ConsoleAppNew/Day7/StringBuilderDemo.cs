//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.Day7
//{
//    internal class StringBuilderDemo
//    {
//        static void Main(string[] args)
//        {
//            StringBuilder sb = new StringBuilder();
//            Console.WriteLine($"Length:{sb.Length}");
//            Console.WriteLine($"Capacity:{sb.Capacity}");
//           // Console.WriteLine(Int32.MaxValue);
//            Console.WriteLine($"MaxCapacity:{sb.MaxCapacity}");

//            sb.Append("C sharp ");
//            Console.WriteLine("==========================");
//            Console.WriteLine($"Length:{sb.Length}");//8
//            Console.WriteLine($"Capacity:{sb.Capacity}");//16
//            Console.WriteLine("Data:"+sb);

//            sb.Append("Programming Language.");
//            Console.WriteLine("==========================");
//            Console.WriteLine($"Length:{sb.Length}");//29
//            Console.WriteLine($"Capacity:{sb.Capacity}");//32
//            Console.WriteLine("Data:" + sb);


//            sb.Insert(8,"Object Oriented ");
//            Console.WriteLine("==========================");
//            Console.WriteLine($"Length:{sb.Length}");//29+16=>45
//            Console.WriteLine($"Capacity:{sb.Capacity}");//32+16(new)=>48
//            Console.WriteLine("Data:" + sb);

//            sb.AppendLine();
//            sb.AppendLine("It's case sensitive");
//            Console.WriteLine("==========================");
//            Console.WriteLine($"Length:{sb.Length}");//29+16=>45+19=>64
//            Console.WriteLine($"Capacity:{sb.Capacity}");//48*2=>96
//            Console.WriteLine("Data:" + sb);
//        }
//    }
//}
