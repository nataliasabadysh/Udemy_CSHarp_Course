using System;
namespace FirstCourse.Class
{
    public class Calculator
    {
        // we use static modifier when we want to present a concept that only a single instanse of that should  exist  in memory

        public static int Add(int a, int b)
        {
            return a + b;
        }

        int result = Calculator.Add(1, 2); 


    }
}
