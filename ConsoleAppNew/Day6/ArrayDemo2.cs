//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Working with 2-D Array

//namespace ConsoleAppNew.Day6
//{
//    internal class ArrayDemo2
//    {
//        static void Main(string[] args)
//        {
//            // int[,] matrix = new int[3, 4];
//            //int[,] matrix = new int[3, 3] { {1,2,3 },{4,5,6 },{7,8,9 } };

//            //int[,] matrix = new int[, ] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//            //int[,] matrix =  { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//            var matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//            Console.WriteLine("Input matrix data:");

//            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
//            {
//                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
//                {
//                    Console.WriteLine($"Input row {i+1} column {j+1} value:");
//                    matrix[i , j] = Int32.Parse(Console.ReadLine());
//                }

//            }
//            Console.WriteLine("Updated matrix data:");

//            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
//            {
//                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
//                {
//                    Console.Write($"{matrix[i , j]} ");
//                }
//                Console.WriteLine("\n");
//            }
//        }
//    }
//}
