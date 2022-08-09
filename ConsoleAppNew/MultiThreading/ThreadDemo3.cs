//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ConsoleAppNew.MultiThreading
//{
//    class Test4
//    {//inter-thread communication

//        public void Display()
//        {
//            for (int i = 0; i <= 10; i++)
//            {
//                Console.WriteLine($"Current Running Thread:{Thread.CurrentThread.Name},\t  Value:{Thread.CurrentThread.IsThreadPoolThread}");
//                Thread.Sleep(300);
//            }
//            this.RandomNum = new Random().Next(30, 70);//assigning a random value
//            Monitor.Pulse(this);//notifies the thread that is in waiting state/queue
//        }
//        public int RandomNum { get; set; }
//    }
//        internal class ThreadDemo3
//    {
//        static void Main(string[] args)
//        {
//            Test4 test = new Test4();
//            Thread th1 = new Thread(test.Display);
//            th1.Name = "Th-1";
//            th1.Start();

//            Thread t2 = Thread.CurrentThread;
//            t2.Name = "Main-TH";

//            lock (test)
//            {
//                Console.WriteLine("In Main: ");
//                Monitor.Wait(test);//wait for resource to b free
//                for (int i = 0; i < test.RandomNum; i++)
//                {
//                    Console.WriteLine($"Current Running Thread:{Thread.CurrentThread.Name},\t  Value:{Thread.CurrentThread.IsThreadPoolThread}");
//                }
//            }
           
//            Console.WriteLine("Main Ended");
//        }
//    }
//}
