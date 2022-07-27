//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew
//{
//  //  internal class Program
//  //{
//  // object id;  //valid
//  //dynamic mark; //valid
//  //var //invalid

///* static void Main(string[] args)
// { /*
//     //Console.WriteLine("Welcome to C#");
//     Console.WriteLine("This is NextLine");
//     Console.WriteLine();
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine(i);
//     }
//     Console.WriteLine("Mains Ends");*/

////using Read() method
///*
//int charUnicode;
//Console.WriteLine("Enter any character:");

//charUnicode=Console.Read();
//Console.WriteLine("Char unicode is:"+charUnicode);
//*/
///*
//int id;
//string name;
//float salary;
//char grade;

//Console.WriteLine("Input details:");

//Console.WriteLine("Enter ID:");
//id = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter Name:");
//name = Console.ReadLine();

//Console.WriteLine("Enter Salary:");
//salary = Single.Parse(Console.ReadLine());

//Console.WriteLine("Enter Grade:");
//grade = Char.Parse(Console.ReadLine());
//*/
//// Int32.Parse(string);
//// Single.Parse(string);
////Char.parse(string)

////Console.WriteLine("Details are:");
///*
//Console.Write("\tID:" + id);
//Console.Write("\tName:"+ name);
//Console.Write("\tSalary:" + salary);
//Console.WriteLine("\tGrade:" + grade);
//*/
///*
//Console.WriteLine("ID:"+id+"\tName:"+name+"\tSalary:"+salary+"\tGrade:"+grade);
//Console.WriteLine("ID:{0}\tName:{1}\tSalary:{2}\tGrade:{3}", id,name,salary, grade);
//Console.WriteLine("ID:{id}\tName:{name}\tSalary:{salary}\tGrade:{grade}");
//*/

////using ReadKey() => returns ConsoleKeyInfo(its a predefined structure)
///*
//            Console.WriteLine("Press any key:");
//            //ConsoleKeyInfo ck = Console.ReadKey();
//            ConsoleKeyInfo ck = Console.ReadKey(true);
//            Console.Write("*");

//            //ConsoleKey
//            Console.WriteLine("\nPressed Key:"+ ck.Key);
//            Console.WriteLine("Pressed KeyChar:"+ ck.KeyChar);
//*/

///*
//            Console.Write("Enter Password :");
//            string pwd = "";

//            ConsoleKeyInfo ck = Console.ReadKey(true);

//            while (ck.Key != ConsoleKey.Enter)
//            {
//                Console.Write("*");
//                pwd = pwd + ck.KeyChar;
//                ck = Console.ReadKey(true);
//            }
//            Console.Write($"\nPassword is:{pwd}");
//*/

////Boxing-> conversion from value type to reference type

///*int x = 20;
//object obj = x;//boxing, implicit
//Console.WriteLine($"value:{obj}\t type:{obj.GetType()}");//20, object

////UnBoxing
////
//int y = (int)obj;
//Console.WriteLine($"value:{y}\t type:{y.GetType()}");//20, int

//float z =(int)obj;
//Console.WriteLine($"value:{z}\t type:{z.GetType()}");//20,Single

//var obj1 = x;
//int a = obj1;
//Console.WriteLine($"value:{obj1}\t type:{obj1.GetType()}");//20, int

//var obj2 = new StringBuilder("string data");

//dynamic d = x;
//int b = d;
//Console.WriteLine($"value:{d}\t type:{d.GetType()}");//20, int*/
///*
//int choice = 20;

//switch (choice)
//{
//    case 1:
//        //Console.WriteLine("Once");
//        //break;
//    case 2:
//        Console.WriteLine("simgle digit");
//        break;

//    default:
//        Console.WriteLine("invalid");
//        break;
//}

////foreach loop
//int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine("Array data:");
//foreach(var item in arr)
//{
//    Console.WriteLine(item);    
//}
///* foreach(type identifier in collection-name){
// * statement
// * 
// * its forward only loop
// * its readonly 
// * }


//}
//}
//} */
