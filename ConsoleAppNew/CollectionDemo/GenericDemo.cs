//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.CollectionDemo
//{
//    class GenericTest<Key, Value>
//    {
//        Key id;
//        Value pass;
//        public GenericTest(Key id, Value pass)
//        {
//            this.id = id;
//            this.pass = pass;
//        }
//        public GenericTest()
//        {
//            id = default(Key);
//            pass = default(Value);
//        }
//        public void SetDetails(Key id, Value pass)
//        {
//            this.id = id;
//            this.pass = pass;
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine($"ID:{id}\tPassword:{pass}"); 
//        }
//    }

//    internal class GenericDemo
//    {
//        static void Main(string[] args)
//        {
//            GenericTest<int, string> obj = new GenericTest<int, string>();
//            obj.DisplayDetails();
//            obj.SetDetails(101, "hari@123");
//            obj.DisplayDetails();


//            GenericTest<string, int> obj2 = new GenericTest<string, int>("emp101",2345);
//            obj2.DisplayDetails();
//            obj2.SetDetails("emp102", 5678);
//            obj2.DisplayDetails();
//        }
//    }
//}
