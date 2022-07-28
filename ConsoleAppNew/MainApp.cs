//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew
//{
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main started");
//            /*
//            Student student = new Student();//object creation
//            student.DisplayStudentDetails();
//            student.SetStudentDetails(101, "Chandresh", 30);
//            student.DisplayStudentDetails(); */
//            /*
//            var student = new Student();
//            student.SetStudentDetails(2000, "Aniket", 25);
//            student.DisplayStudentDetails();//2000,Aniket,25

//            new Student().SetStudentDetails(3000, "Tejas", 24);
//            new Student().DisplayStudentDetails();//0,null,0
//            */
//            Method calling
//            ref & out
//            MethodCalling methodCalling = new MethodCalling();
//            int a = 20, b = 30;
//            Console.WriteLine($"a:{a}\tb:{b}");//20,30

//            methodCalling.CallByValue(a, b);//from method:50, 50
//            methodCalling.CallByRef(ref a, ref b);

//            Console.WriteLine($"a:{a}\tb:{b}");//20,30
//            Console.WriteLine($"a:{a}\tb:{b}");//50,30

//            int sum, multiply;
//            methodCalling.CallByOut(a, b, out sum, out multiply);
//            Console.WriteLine($"Sum:{sum}\tMultiplication:{multiply}");//50,600
//            /*
//            int[] arr = {1,2,3,4};
//            int result = methodCalling.CallByVarArgs("astric",arr);
//            Console.WriteLine($"Sum is:{result}");
//            Console.WriteLine($"Sum is:{methodCalling.CallByVarArgs("astric",20,30)}");
//            Console.WriteLine($"Sum is:{methodCalling.CallByVarArgs("astric", 20,30,50)}");
//            Console.WriteLine($"Sum is:{methodCalling.CallByVarArgs("astric", 20,30,50,60,70)}");
//            */
//            methodCalling.Message("Narendra", "Patil", 20000);



//        }
//    }
//}

