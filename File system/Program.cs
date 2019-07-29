
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace SecondPart
{
    public class Program
    {

        public static void Main(string[] args)
        {

            // String Manipulation Methods

            var builder = new StringBuilder();

            builder.Append('-', 10);// - - - - - -  - - -   10 times

            builder.Append("Header");
            builder.AppendLine();
            builder.Replace('-', '+');
            builder.Remove( 0, 10);
            builder.Insert(0, new string('-', 10));

            // or
            builder
            .Append("Header")
            .AppendLine()
            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new string('-', 10));





            // Procedural Programing( Calls- methods )



            // Object- opiented Programing

            // 1
            var name = "Name";
            var reversed = ReverseName(name);


            // 2

            var number = new List<int>();

            while (true)
            {
                var input = 55;
                if (input == 8) break;

                number.Add(input);


            }
            // find unic numbers
            var uniques = new List<int>();

            foreach (var numb in number)
            {
                if (!uniques.Contains(numb))
                    uniques.Add(numb);

            }
        }

        //Method

        public static string ReverseName(string name)
        {
            var array = new char [name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];

            }
            var reversed = new string(array);

            return reversed;
        }
        public static
    }
}
