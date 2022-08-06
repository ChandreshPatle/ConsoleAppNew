//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.DelegateEvents
//{
//     class Singleton
//    {
//        private static Singleton singleton;
//        private Singleton()
//        {
//            Console.WriteLine("Object created");
//        }

//        public static Singleton GetObject()
//        {
//            if(singleton == null)
//                singleton = new Singleton();
//            return singleton;
//        }

//        public void Display()
//        {
//            Console.WriteLine("Display from singleton");
//        }
//    }
//    internal class SingletonDemo
//    {
//        public static void Main(String[]agrs)
//        {
//            //Singleton singleton = new Singleton();

//            Singleton singleton = Singleton.GetObject();
//            singleton.Display();
//            singleton  = Singleton.GetObject();
//            singleton.Display();


//        }
//    }
//}
