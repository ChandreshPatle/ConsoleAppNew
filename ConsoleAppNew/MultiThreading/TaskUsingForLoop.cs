//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.MultiThreading
//{
//    internal class TaskUsingForLoop
//    {
//        static void Main(string[] args)
//        {
//            DateTime startTime = DateTime.Now;
//            Console.WriteLine($"Execution started at:{startTime.ToLongTimeString()}");
//            for (int i = 0; i < 15; i++)
//            {
//                long result = AddNumbers();
//                Console.WriteLine($"{i}:{result}");
//            }
//            DateTime endTime = DateTime.Now;
//            Console.WriteLine($"Execution ended at:{endTime.ToLongTimeString()}");
//            TimeSpan span = endTime - startTime;
//            Console.WriteLine($"Total time consume in execution:{span.Milliseconds}");

//        }

//        static long AddNumbers()
//        {
//            long sum = 0;
//            for (int i = 0; i < 1000000000; i++)
//            {
//                sum += i;
//            }
//            return sum;
//        }

//    }
//}
