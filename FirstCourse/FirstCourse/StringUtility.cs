using System;
using System.Collections.Generic;

namespace FirstCourse
{
    public class StringUtility
    {
        public string SummerizeText(string text, int maxLenght = 20) // maxLenght = defaul value
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
    }
}
