using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("Welcome to the Pig Latin Translator!\nEnter a line to be translated:");
            string str = Console.ReadLine();
            Console.WriteLine(ToPigLatin(str));

            
            
                Console.WriteLine("Do you wish to conitue?  (Y/N)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {

                }
                else
                {
                    break;
                }

            }
        }

        public static int indexOfVowel;
        public static string ToPigLatin(string str)
        
        {
            string lw = str.ToLower();
            string firstP = "";
            string secondP = "";

            if (IsVowel(lw))
            {
                return lw + "way";
            }
            else
            {
                foreach (char l in lw)
                {
                    if (IsVowel(l))
                    {
                        indexOfVowel = lw.IndexOf(l);
                        firstP = lw.Substring(0, indexOfVowel);
                        secondP = lw.Substring(indexOfVowel, lw.Length-indexOfVowel);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                return secondP + firstP + "ay";
            }
        }

        public static bool IsVowel(string x)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach( char vowel in vowels)
            {
                if(x[0]== vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }

            }

            return false;
        }

        public static bool IsVowel(char x)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)
            {
                if (x == vowel)
                {
                    return true;
                }
                else
                {
                    continue;
                }

            }

            return false;
        }
    }
}
