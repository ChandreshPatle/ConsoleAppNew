//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppNew.DelegateEvents
//{
//    public delegate void MyEventHandler();//delegate decln


//    internal class Publisher
//    {
//        public event MyEventHandler MyEvent;//Event Decln

//        public void Notify()
//        {
//            if (MyEvent != null)
//            {
//                MyEvent.Invoke();
//            }
//            else
//                Console.WriteLine("No subscriber associated with event");
            
//        }

//    }
//    class Subscriber {

//        //handler method for event
//        public void Message()
//        {
//            Console.WriteLine("You Entered single digit number");
//        }
//        static void Main(string[] args)
//        {
//            Publisher eventDemo = new Publisher();
//            //Event instantiation/subscription
//            //eventDemo.MyEvent += new MyEventHandler(eventDemo.Message);
//            eventDemo.MyEvent += new Subscriber().Message;

//            //Invocation logic
//            int i = 0;
//            int num;
//            while (i <= 100)
//            {
//                Console.WriteLine("Input any number");
//                num = Int32.Parse(Console.ReadLine());
//                if (num > 0 && num < 10)
//                {
//                    //eventDemo.MyEvent();
//                    //if(eventDemo.MyEvent != null)
//                    eventDemo.Notify();//Notifying the publisher event
//                    //else
//                        //Console.WriteLine("No subscriber associated with event");
//                }else
//                    Console.WriteLine("Not a single digit number entered");
//                i++;
//            }

//        }
//    }
//}
