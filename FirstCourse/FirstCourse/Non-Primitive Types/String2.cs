using System;


namespace FirstCourse.NonPrimitiveTypes
{
    public class String2
    {
        public static void Main(string[] args)
        {
            // Primitive Types- are all Structures
            int number;


            // Non-Primitive Types are Class 
            var firstName = "Mosh";
            string lastName = "Hamedani";

            String lastName2 = "Hamedani"; // or String class, we need using System;


            // Cancat

            var fullName = firstName +  " " + lastName;
            var myFullName = string.Format("My  name is {0} {1}", firstName, lastName); // My  name is Mosh Hamedani

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names); //John,Jack,Mary


            var text = "Hi John\nLook into the following paths\nc:\\folder\\project";
            /*
                Hi John
                Look into the following paths
                c:\folder\project

            */

            // Verbatim String @"Text"

            var textVerb = @"Hi John
Look into the following paths
c:\\folder\\project";




        }
    }
}
