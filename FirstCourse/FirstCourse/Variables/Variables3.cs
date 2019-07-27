using System;

namespace FirstCourse.Variables
{
    public class Variables3
    {
        static void Main(string[] arg)
        {
            // Implicit type conversion in action

            int b = 1;

            byte i = (byte)b;

            Console.Write(i); // 1


            //  we will lost some of thre bits, because byte max = 255

            int a = 1000;

            byte c = (byte)a;

            Console.Write(c); // 232


            // Non compatible types


            string number = "1234";
            int p = Convert.ToInt32(number);    // byte can't convert, Unhandled Exception
            Console.WriteLine(p);


            // Handle the Exception
            try
            {
                string numbers = "1234";
                int t = Convert.ToInt32(number);
                Console.WriteLine(t);
            }
            catch(Exception)
            {
                Console.WriteLine("The number could not  be converted to a bite.");
            }


            // Handle the Exception - string and bool are not compatible, we can't use explicit castign, but we can use Convert class 
            try
            {
                string str = "true";
                bool d = Convert.ToBoolean(str);
                Console.WriteLine(d); // True 
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not  be converted to a bite.");
            }

        }
    }
}
