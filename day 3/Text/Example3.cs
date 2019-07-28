using System;
namespace HelloWorld.Text
{
    public class Example3
    {
        static void Main(string[] args) {

            var text = "this is going to be really really long testxt";
            const int maxLenght = 20;

            if (text.Length < maxLenght)
                Console.Write(text)
             else
            {
                var worrds = text.Split(' ');
                var totalCharactors = 0;
                var summeryWorlds = new List<string>

                foreach (var word in worrds)
                {

                    summaryWorld.Add(word);

                    totalCharactors += word.Length + 1;

                    if (totalCharactors > maxLenght) break;

                }

                String.Join(" ", summeryWorlds) +  " ... ";

            }
        }

        static string SummerizeText(string text)

    }
}
