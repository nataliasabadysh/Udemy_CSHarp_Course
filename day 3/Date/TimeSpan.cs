using System;
namespace HelloWorld.Arrays.Date
{
    public class TimeSpan
    {
        //TimeSpan

        static object Main(string[] args)
        {
            
            var timeSpan = new TimeSpan(1, 2, 3); // h,m, sec 

            var timeSpan = new TimeSpan(1, 0, 0);

            TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start; // 2 min

            // Properties
            timeSpan.Total;
            timeSpan.Minute;

            // Add

            timeSpan.Add(TimeSpan.FromMinutes(8));
            timeSpan.Subtract(TimeSpan.FromMinutes(2));

            // ToStrign Method
            timeSpan.ToString();


            // Partse

            timeSpan.Parse("01:03:10");




        }
    }
}
