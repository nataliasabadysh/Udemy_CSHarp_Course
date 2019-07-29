using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SecondPart
{
    public class Program
    {


        public enum Season
        {
            Spring,
            Summer,
            Autom,
            Winter

        }
        public static void Main(string[] args)
        {



            // Conditional Statement

            // if else

            int hour = 20;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning");

            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");




            // 2


            bool isGoldCustomer = true;
            float price;

            if (isGoldCustomer) price = 19.95f;
            else price = 25.95f;

            // Condition

            float priceItem = (isGoldCustomer) ? 19.95f : 29.95f;

            // 








            // Swithch case

            // ? : 
        }
    }
}
