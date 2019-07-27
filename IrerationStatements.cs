using System;
namespace HelloWorld
{
    public class IrerationStatements
    {
        // for loop


        /*
         foreach loop  - used for iterate over of an Enumerable object
         anything that has same kind of list, array nature
         - string, array are  Enumerable
         */


        /*
         while loop

         */

        // do while loop

        static void Main(string[] args )
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);// 2, 4, 6, 8, 10
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);//10, 8, 6, 4, 2
                }
            }


            // Iterate String 

            // Foreach loop VS for  

            /*
            var name = "Jphn Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            */

            // Array

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            // while 
            var i = 0;
            while (i <= 10)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }


            while (true)
            {
                Console.Write("Type your name");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@Echo: " + input);
            }


            // continue

            while (true)
            {
                Console.Write("Type your name");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }






        }
    }
}
