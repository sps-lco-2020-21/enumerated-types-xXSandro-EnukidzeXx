﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsLib
{
    public static class CardFunctions
    {
        public static int longestRun(List<Cards> current)
        {
            int c = 0;
            int cv = (int)current[0];
            int gr = 0;
            for (int i = 0; i < current.Count; i++)
            {
                Cards card = current[i];
                if ((int)card == cv + 1)
                {
                    while ((int)card == cv + 1)
                    {
                        c += 1;
                        cv = (int)card;
                        i += 1;
                        if (i == current.Count)
                        {
                            break;
                        }
                        else
                        {
                            card = current[i];
                        }
                    }
                }
                if (c > gr)
                {
                    gr = c;
                }
                c = 1;
                if ((int)card == cv - 1)
                {
                    while ((int)card == cv - 1)
                    {
                        c += 1;
                        cv = (int)card;
                        i += 1;
                        if (i == current.Count)
                        {
                            break;
                        }
                        else
                        {
                            card = current[i];
                        }
                    }
                }
                if (c > gr)
                {
                    gr = c;
                }
                c = 1;
                cv = (int)card;
            }
            return (gr);
        }

        public static string StringToCard(string source)
        {
            string output = "";
            char firstChar = source[0];
            char secondChar = source[1];
            string firstWord = FirstToWord(firstChar);
            string secondWord = SecondToWord(secondChar);
            output = firstWord + " of " + secondWord;
            return (output);

        }

        public static CardClass StringToClass(string source) // Halfway done
        {
            char firstChar = source[0];
            char secondChar = source[1];
            Cards value;
            if (Char.IsDigit(firstChar))
            {
                value = (Cards)(Convert.ToInt32(firstChar.ToString()));
            }
            var letters = new[] { 'T', 'J', 'Q', 'K' };
            var words = new[] { 10, 11, 12, 13 };
            if (letters.Contains(firstChar))
            {
                int index = Array.IndexOf(letters, firstChar);
                value = (Cards)(words[index]);
            }
            else
            {
                Console.WriteLine("That's not a valid input");
            }
        }

        private static string FirstToWord(char firstChar)
        {
            if (Char.IsDigit(firstChar))
            {
                return(NumberToWords(Convert.ToInt32(firstChar.ToString())));
            }
            var letters = new[] { 'T', 'J', 'Q', 'K' };
            var words = new[] { "Ten", "Jack", "Queen", "King" };
            if(letters.Contains(firstChar))
            {
                int index = Array.IndexOf(letters, firstChar);
                return (words[index]);
            }
            else
            {
                return ("That's not a valid input");
            }
        }

        public static string SecondToWord(char secondChar)
        {
            foreach(string str in Enum.GetNames(typeof(Suits)))
            {
                if (str[0] == secondChar)
                    return str;
            }
            return ("Invalid input");
        }

        public static string NumberToWords(int number)
        {
            var unitsMap = new[] { "zero", "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }; //taken from stack overflow with some minor changes
            return (unitsMap[number]);
        }
    }
}
