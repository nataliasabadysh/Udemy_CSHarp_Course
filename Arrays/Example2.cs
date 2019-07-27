using System;
namespace HelloWorld.Arrays
{
    public class Example2
    {
       static void Main(string[] argg) {

            // Properties and Methods in Arrays

            var numbers = new[] { 1, 2, 3, 18, 9 };  // int[] numbers = new int[] { 1, 2, 3, 8, 9 };
            Console.WriteLine("Lenght" + numbers.Length);  // 6


            // IndexOf(); - returns an integer 
            var index = Array.IndexOf(numbers, 9); // 2 - [3] element in an Array


            // Clear();
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            {
                Console.Write(n); // 0, 0, 3, 18, 9
            }


            // Cope();
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray , 3);//  0 0 3

            foreach (var n in anotherArray)
            {
                Console.Write(n); 
            }

            // Sort()

            Array.Sort(numbers);

            foreach (var n in numbers)
            {
                Console.Write(n); //  0 0 3 9 18
            }

            // Reverse();

            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.Write(n); //  18, 9, 3, 0, 0
            }

        }
    }
}
