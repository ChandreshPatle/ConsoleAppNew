using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNew.Day8
{
    internal class DateTimeDemo
    {
        static void Main(string[] args)
        {

           // DateTime date = new DateTime(2022,07,25);//yyyy,mm,dd
            DateTime date = DateTime.Now;
            Console.WriteLine("Current Date & Time: " +date);
            /*
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.Millisecond);*/


           // DateTime newdate = date.AddMonths(5);
            DateTime newdate = date.AddMinutes(15);
            Console.WriteLine("Update Data:" +newdate);
            Console.WriteLine("=========================");
            Console.WriteLine("Date Formatting");
            Console.WriteLine("LongDate:" +date.ToLongDateString());
            Console.WriteLine("ShortDate:" + date.ToShortDateString());
            Console.WriteLine("LongTime:" + date.ToLongTimeString());
            Console.WriteLine("ShortDate:" + date.ToShortTimeString());

            //date.ToString();
            /*
            d->day
            M->month
            y-->year
            h,H-->hour
            m-->minute
            s-->second
            t-->am/pm
            K-->timezone
            f-->decimal fraction of second(milisecond)
            
            */
            Console.WriteLine(date.ToString("MM-dd-yy,H:m:s t"));
            Console.WriteLine(date.ToString("dd-MM-yy,H:m:ss tt"));
            Console.WriteLine(date.ToString("MMMM,yyyy"));
            Console.WriteLine(date.ToString("dddd,dd-MM-yyyy"));




            //reading date value from console
            Console.WriteLine("Input date value:");
            DateTime mydate;
            if (DateTime.TryParse(Console.ReadLine(), out mydate)){

                Console.WriteLine("date is :" +mydate);
                Console.WriteLine(mydate.ToString("MMMM,d-MM-yyyy"));
            }
            else
                Console.WriteLine("Input a valid date:");
           







        }
    }
}
