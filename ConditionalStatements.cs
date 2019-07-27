using System;

namespace HelloWorld
{
    public class ConditionalStatements
    {
        // if / else
        // swith
        // ? ..:

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            /*

            int hour = 10;

            if (hour > 0 && hour < 12)
                 Console.WriteLine("It's morning. ");
            else if (hour >= 12 && hour < 18)
                 Console.WriteLine("It's afternoon.");
            else
                 Console.WriteLine("It's evening. ");

            */

            bool isGoldCustomer = true;
            /*
            float price;

            if (isGoldCustomer)
                price = 19.95f;

            else price = 29.95f;
            */

            // With Conditional Operator

            float price = (isGoldCustomer) ? 19.95f : 29.95f;


            // Swith case

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's automn and a beatiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect time for beach.");
                    break;

                default:
                    Console.WriteLine("I don't undestand that season!");
                    break;
            }


        }

    }
}
