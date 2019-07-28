using System;
namespace HelloWorld.Text
{
    public class Example2
    {
        static void Main(string[] arg)
        {
            var fullName = "Mosh Hamedani ";
            fullName.Trim();//  "Mosh Hamedani"
            fullName.Trim().ToUpper();//  "MOSH ... "

            var index = fullName.IndexOf(' '); //

            var firstName = fullName.Substring(0, index); // Mosh
            var lastName = fullName.Substring(index + 1); // Hamedani

            // Splid

            var names  = fullName.Split(' ');

            //names[0];// Mosh 
            //names[1];// Hamedani


            // Replase

            fullName.Replace("Mosh", "Moshfegh");
            fullName.Replace('o', 'O');
            fullName.Replace(' ', '');


            // all there methods returns new string



            if (String.IsNullOrEmpty(null))
                Console.Write("Invalid"); // Invalid 

            // '' - false 

            if (String.IsNullOrEmpty(""))
                Console.Write("Invalid"); // Invalid 


            // ' '
            if (String.IsNullOrEmpty(" "))
                Console.Write("Invalid"); // passed

            // ' '
            if (String.IsNullOrEmpty(" ".Trim()))
                Console.Write("Invalid"); // Invalid


            // ' '
            if (String.IsNullOrWhiteSpace(" "))
                Console.Write("Invalid"); // Invalid


            // Convert  Numbers to Srting

            var age = "25";
            Convert.ToByte(age);


            float price = 29.95f;
            price.ToString("C0");//30












        }
    }
}
