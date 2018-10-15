using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter a word");
          Console.ReadLine();  
        
        }
    
          public static string TranslateWord(string str)
        {
            string pigWord = "";
            string sentence = "";
            string firstLetter;
            string restOfWord;
            string vowels = "AEIOUaeiou";
            int letterPosition;

            while (sentence.ToLower() != "quit")
            {
                Console.WriteLine("Please enter a word or sentence:");

                sentence = Console.ReadLine();

                foreach (string newstr in sentence.Split())
                {
                    firstLetter = str.Substring(0, 1);
                    restOfWord = str.Substring(1, str.Length - 1);

                    letterPosition = vowels.IndexOf(firstLetter);

                    if (letterPosition == -1)
                    {
                        // it's a consonant
                        pigWord = restOfWord + firstLetter + "ay";
                    }
                    else
                    {
                        // it's a vowel
                        pigWord = str + "yay";
                    } // end if

                    Console.Write("{0} ", pigWord);
                    return newstr;

                } 
            } 
        } 
    } 
} 