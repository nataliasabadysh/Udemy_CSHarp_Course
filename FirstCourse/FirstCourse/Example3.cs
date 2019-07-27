using System;
using System.Collections.Generic;
using FirstCourse.StringUtility;

namespace FirstCourse
{
    public class Example3
    {
        static void Main()
        {
            /*
            var sentence = "This is going to be a really really really long text";
            const int maxLenght = 20;


            if (sentence.Length < maxLenght)
            {
                Console.WriteLine(sentence);
            }
            else {
                // sentence.Substring(0, maxLenght);

                var words = sentence.Split(' ');
                var totalCharcters = 0;

                var summeryWords = new List<string>();

                foreach (var word in words)
                {
                    // add current word to the List
                    summeryWords.Add(word);

                    totalCharcters += word.Length + 1; // +1 space after word
                    if (totalCharcters > maxLenght) {
                        break;
                    }
                }
               // We need create a string and join all these words using whitespace
                var summery = String.Join(" ", summeryWords) + "...";
                Console.WriteLine(summery);
            }
            */

            // Move to the method


            var sentence = "This is going to be a really really really long text";
            var summery = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summery);
            
        }
        // Method
        /*
        static string SummerizeText(string text, int maxLenght = 20) // maxLenght = defaul value
        { 
            if (text.Length < maxLenght)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalCharcters = 0;

            var summeryWords = new List<string>();

            foreach (var word in words)
            {
                summeryWords.Add(word);

                totalCharcters += word.Length + 1;
                if (totalCharcters > maxLenght)
                {
                    break;
                }
            }

            return String.Join(" ", summeryWords) + "...";

        }
        */
    }
}