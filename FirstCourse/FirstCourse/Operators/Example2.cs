using System;
namespace FirstCourse.Operators
{
    public class Example2
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a / b); // 3
            Console.WriteLine((float)a / (float)b); // 3.333


            var d = 1;
            var f = 2;
            var c = 3;

            Console.WriteLine(a  + f * c ); // 2 * 3 = 6 + 1 =7
            Console.WriteLine((float)a / (float)b); // 3.333


            // Comparison operators

            Console.WriteLine(a > b); // true

            Console.WriteLine( d < f && c > f); // true

            Console.WriteLine(d < f || c == f);

            
        }
    }
}
