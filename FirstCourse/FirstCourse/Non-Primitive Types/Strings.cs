using System;
namespace FirstCourse.NonPrimitiveTypes
{
    public class Strings
    {
        // String

        string firstName = "Mosh";

        // Concat strings | Or string.Format

        // string name = firstName + " " + lastName;


        // String classes can have Field and Methods

        // string name = string.Format("{0} {1}", firstName, lastName);

  
        public static void Main(string[] args)
        {
            // Array of Obj, create String 

            var numb = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numb);// 1,2,3

            // String Elements

            string name = "Mosh";
            char firtsChar = name[0]; // M


            // Strings are imutable - we can't change them (Methods returns new String, original string is not change)



            // Escape Characters
            /*
             
            \n - new line
            \t - Tab
            \\ - backSlach
            \' - single Quotation mark

            */

            // Verbatim String  @

           // string path = "c:\\project\\folder\\projectname";

            string path = @"c:\project\folder\projectname";


        }

    }
}
