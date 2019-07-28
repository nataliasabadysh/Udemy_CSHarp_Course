using System;
namespace HelloWorld.Text
{
    public class Example
    {
        static void Main(string[] args)
        {
            //___ String - class
            //___ imutable

            // Trim();
            // Tolower();

            // IndexOf();   Searching
            // LastIndexOf()

            //  Substring(startIndex, length) -   Substring


            //____ Null checking  ( or whitespase )
            // String.IsNullOrEmpty(str)
            // String.IsNullOrWhiteSpase(str)


            // Splitting

            string.split('');

            // Convert String to Number

            string s = "1234";
            int i = int.Parse(s);
            int j = Convert.ToInt32(s);


            // Number to Strign

            int a = 1233;
            string s = i.ToString();
            string t = i.ToString("c");
            string t = i.ToString("c0")



        }
    }
}
