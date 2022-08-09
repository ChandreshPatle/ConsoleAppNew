using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.CollectionDemo
{
    class A { }//Base Type
    class B : A { }//Derive Type
    class C:A { }//Derive Type

    class GenericTest1<T> where T : A {
            public void Display(T t1)
                {
                    Console.WriteLine(t1);
                }
    
    }


    internal class GenericDemo1
    {
        static void Main(string[] args)
        {
            //GenericTest1<string> obj1 = new GenericTest1<string>();
            //obj1.Display("astric");

            GenericTest1<A> obj3 = new GenericTest1<A>();
            obj3.Display(new A());

            GenericTest1<C> obj4 = new GenericTest1<C>();
            obj4.Display(new C());

        }
    }
}
