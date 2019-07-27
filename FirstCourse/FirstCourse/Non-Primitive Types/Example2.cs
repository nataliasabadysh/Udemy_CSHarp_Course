using System;
namespace FirstCourse.Arrays
{
    public class Example2
    {
        public static void Main(string[] args)
        {

            //int[] numbers = new int[3] { 1, 2, 3 };

            var numbers = new int[3] { 1, 2, 3 };
            numbers[0] = 1;

            // Array elements have default value = 0 | false 

            var flag = new bool[3];
            flag[0] = true;

            Console.WriteLine(flag[0]); // true
            Console.WriteLine(flag[1]); // false 
            Console.WriteLine(flag[2]); // false


            var names = new string[3] { "Jack", "John", "Marry" };

        }
    }
}
