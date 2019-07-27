using System;
namespace FirstCourse
{
    public class Variables
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();

            //Primitive data type
            int number = 5;
            int Number = 5;

            // Constants - we can't change the value in this var 
            const float Pi = 3.14f;
            const int MaxZoom = 5;


            // Real Numbers
            float numberF = 1.2f;
            decimal numberD = 1.2m;

            // Non-Primitive Types - String, Array, Enum, Class

            // Initialize Var 
            byte numberVar = 2;
            int count = 10;
            float totalProce = 20.95f; // By defaul c# compiler traits real number as number , we need to say as a float with +f
            char character = 'A';

            string firstName = "Mosh";
            bool isworking = true;

            // Var - lets c# compiler detect that data for this variables
            var maxNumber = 2;

            Console.WriteLine(number);

            // Format String (tamplate) 
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // 0 , 255
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            // Overflowing

            checked  // with checked Overflowing will not happen in runtime
            {
                byte numberByte = 255;
                number = numberByte + 1;// 0
            }
            // Exception will be thrown


            // Scope
            {
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                    }
                }

            }

        }
    }
}
