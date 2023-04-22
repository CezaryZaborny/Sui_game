using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuicadeGame
{
    public class Calculations
    {
        public static String RandomPassword()
        {
            Random random = new Random();
            String[] words = File.ReadAllLines("Words.txt");
            String word = words[random.Next(words.Length)].ToUpper();
            return word;

        }
        public static String HashPassword(String password)
        {
            String result = "";
            foreach (char character in password)
            {
                if (Char.IsWhiteSpace(character))
                {
                    result += " ";
                }
                else
                {
                    result += "_";

                }

            }
            return result;

        }

    }

}
