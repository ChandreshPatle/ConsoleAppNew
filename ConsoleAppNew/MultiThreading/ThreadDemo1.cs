//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleAppNew.MultiThreading
//{
//    class Test
//    {
//        public void Display()
//        {
//            int i;
//            for(i = 0; i <= 5; i++)
//            {
//                Console.WriteLine($"Current Thread:{Thread.CurrentThread.Name},value of i:{i}");
//                Thread.Sleep(1000);
//            }
//        }
//    }
//    class Test2
//    {
//        //this is power of multi threading in C sharp;
//        public void CheckCase(object str)
//        {
//            lock (this)
//            {
//                string data = str as string;
//                foreach (Char ch in data)
//                {
//                    Console.Write(ch);
//                    int uCode = (int)ch;
//                    if (uCode >= 97 && uCode <= 122)
//                    {
//                        uCode = uCode - 32;
//                        Thread.Sleep(300);
//                        Console.Write("\b");
//                        Console.Write((char)uCode);
//                    }
//                    Thread.Sleep(200);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//    internal class ThreadDemo1
//    {
//        static void Main(string[] args)
//        {/*
//            Console.WriteLine("Main Started");
//            Test test = new Test();
//            //ThreadStart threadStart = new ThreadStart(test.Display);
//            //Thread t1 = new Thread(new ThreadStart(new Test().Display));
//            //Thread t1 = new Thread(threadStart);
//            //creating thread one
//            Thread t1 = new Thread(test.Display);
//            t1.Name = "Test-th-1";
//            t1.Start();
//            Thread t2 = Thread.CurrentThread;
//            t2.Name = "MainThread";
//            //creating thread-2
//            Thread t3 = new Thread(test.Display);
//            t3.Name = "Test-th-2";
//            t3.Start();
//            //Console.WriteLine("Current Thread Name:"+t2.Name);
//            Console.WriteLine("Main Thread State:" + t2.ThreadState);
//            Console.WriteLine("T1 Thread State:" + t1.ThreadState);
//            Console.WriteLine("T2 Thread State:" + t3.ThreadState);
//            //ThreadState.
//            Console.WriteLine("Main ended");*/

//            Test2 test = new Test2();
//            Thread t1 = new Thread(new ParameterizedThreadStart(test.CheckCase));
//            Thread t2 = new Thread(test.CheckCase);

//            t1.Start("This is a Power of multi threading in C Sharp ");
            
//            t2.Start("Using ASYNC Nature of Threads");
//        }
//    }
//}
