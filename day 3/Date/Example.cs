using System;
namespace HelloWorld.Arrays.Date
{
    public class Example
    {
        static void Main(string[] args)
        {
            // Date Objects


            var dateTime = new DateTime(2015, 1, 1);
            var timeNow = DateTime.Now;
            var today = DateTime.Today;

            // timeNow.Hour;
            // timeNow.Minute;
            timeNow.AddDays(1);// returns tomorrow  curent time
            timeNow.AddDays(-1);// returns yesterday  curent time


            //  Fomat to String

            timeNow.ToLongDateString(); //Saturdat 23 Mat 2015
            timeNow.ToShortDateString();//23/05/2015
            timeNow.ToLongDateString();//12:43 PM
            timeNow.ToString("yyyy-MM-dd-HH-mm");// 







        }
    }
}
