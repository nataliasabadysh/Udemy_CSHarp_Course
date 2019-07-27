using System;

namespace FirstCourse
{
    public class Example2
    {
        public static void Main(string[] args)
        {
            // Class Random numbers 

            /*
             var random = new Random();
             for (var i = 0; i < 10; i++) {
                 Console.WriteLine(random.Next(1, 10));// 2 .. 9
             }
            */

            // Class Random string 
            /*
                var random = new Random();
                for (var i = 0; i < 10; i++)
                {
                    //  to cast the true character -> (char)
                    Console.Write((char)random.Next(97, 122)); // rxcjspkgyu
                }
            */
            
            var random = new Random();
            const int passwordLength = 10;

            var buffer = new char[passwordLength];// class for Storing the string in Array[10]

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26)); // rxcjspkgyu
                                                              
                var password = new string(buffer);
                Console.Write(password);
            }


        }
    }
}
