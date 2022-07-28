using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day4
{
    internal class Point
    {
        //datafields
        int x;
        int y;
        public Point(int x=20, int y=30)//constructor
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()//override method
        {
            return $"Point({x},{y})";
        }
        //Overloading of + operator
        public static Point operator +(Point p1,Point p2)//method should be static and agru should b 2
        {
            int x=p1.x +p2.x;
            int y=p1.y +p2.y;
            return new Point(x,y);
        }
        //Overloading of - operator
        public static Point operator -(Point p1, Point p2)//method should be static and agru should b 2
        {
            int x = p1.x - p2.x;
            int y = p1.y - p2.y;
            return new Point(x, y);
        }
    }
}
