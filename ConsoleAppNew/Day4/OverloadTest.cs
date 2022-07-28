using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day4
{
    internal class OverloadTest
    {
        internal void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }
        internal void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;

        }
        internal void Swap(StringBuilder s1, StringBuilder s2)
        {
            //StringBuilder temp = s1;
            //s1 = s2;
            //s2 = temp;
            s1.Append("India");
            s2.Insert(0,"CDAC");
        }
        internal void Swap(ref float num1, ref float num2)
        {
            float temp = num1;
            num1 = num2;
            num2 = temp;

        }
        internal void Swap(ref char c1, ref char c2)
        {
            char temp = c1;
            c1 = c2;
            c2 = temp;

        }
    }
}
