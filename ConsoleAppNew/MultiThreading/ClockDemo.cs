//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;


//namespace ConsoleAppNew.MultiThreading
//{
//    internal class ClockDemo
//    {
//        static void PrintTime()
//        {
//            //Interlocked
//            Console.WriteLine($"Current Time:{DateTime.Now.ToLongTimeString()}");
//        }
//        static void Main(string[] args)
//        {
//            //PrintTime();
//            Thread thread = new Thread(PrintTime);
//            thread.Start();

//        }
//    }
//}
