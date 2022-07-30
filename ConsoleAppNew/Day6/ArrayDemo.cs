//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.Day6
//{
//    internal class ArrayDemo
//    {
//        static void Main(string[] args)
//        {
//            //int[] score;//Array declaration

//            //score = new int[5];// Array initialization
//            /*
//            int[,,] score = new int[4,5,6];

//            Console.WriteLine($"ArrayLength:{score.Length}");//120
//            Console.WriteLine($"Array Rank:{score.Rank}");//Rank returns Array Dimensional

//            //From Rank 1 dimension index will be 0
//            //From Rank 2 dimension index will be  0, 1
//            //From Rank 1 dimension index will be 0, 1, 2

//            Console.WriteLine($"Dimension-1 specific Array Length :{score.GetLength(0)}");//4
//            Console.WriteLine($"Dimension-2 specific Array Length :{score.GetLength(1)}");//5
//            Console.WriteLine($"Dimension-3 specific Array Length :{score.GetLength(2)}");//6

//            Console.WriteLine($"Dimension-1 Upperbound :{score.GetUpperBound(0)}");//3
//            Console.WriteLine($"Dimension-2 Upperbound :{score.GetUpperBound(1)}");//4
//            Console.WriteLine($"Dimension-3 Upperbound :{score.GetUpperBound(2)}");//5
//            */

//            //int[] score = new int[5];//way-1
//            //int[] score = new int[5] {1,2,3,4,5};//way-2
//            //int[] score = new int[] { 1, 2, 3, 4, 5, 6, 7 };//way-3
//            /*
//            int[] score =  { 1, 2, 3, 4, 5 };//way-4

//            Console.WriteLine("Array Data:");
//            for (int i = 0; i < score.Length; i++)
//            {
//                Console.Write($"{score[i]} ");
//            }
//            Console.WriteLine();
//            //Assigning User input value
//            Console.WriteLine("Input array values:");
//            for (int i = 0; i < score.GetLength(0); i++)
//            {
//                Console.WriteLine($"Enter array element {i+1} value:");
//                score[i] = Int32.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Updated Array Data:");
//            for (int i = 0; i <= score.GetUpperBound(0); i++)
//            {
//                Console.Write($"{score[i]} ");
//            }
//            */

//            var states = new string[5] { "UP","MP","Punjab","Maharastra","Bihar"};

//            Console.WriteLine("States are:");
//            foreach (var state in states)
//            {
//                Console.WriteLine(state);
//            }
//           // Array.Sort(states);
//            Array.Reverse(states);

//            Console.WriteLine("Sorted States are:");
//            foreach (var state in states)
//            {
//                Console.WriteLine(state);
//            }
//            Console.WriteLine("=================");
//            Console.WriteLine(states.Min());
//            Console.WriteLine(states.Max());



//        }
//    }
//}
