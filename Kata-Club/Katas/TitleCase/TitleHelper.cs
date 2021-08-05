using System.Collections.Generic;
using System.Linq;

namespace Kata_Club.Katas.TitleCase
{
    public class TitleHelper
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(title)) return "";

            var minorWordsList = minorWords != null ? minorWords.Split(" ").ToList() : new List<string>();
            var titleArr = title.Split(" ");

            for (int i = 0; i < minorWordsList.Count; i++)
            {
                minorWordsList[i] = minorWordsList[i].ToLower();
            }

            for (int i = 0; i < titleArr.Length; i++)
            {
                var titleWord = titleArr[i] = titleArr[i].ToLower();

                if (!minorWordsList.Contains(titleWord) || i == 0)
                {
                    titleArr[i] = Capitalise(titleWord);
                }
            }

            return string.Join(" ", titleArr);
        }

        private static string Capitalise(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
